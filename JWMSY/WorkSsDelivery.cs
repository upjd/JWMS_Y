using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using JWMSY.DLL;
using DevExpress.XtraReports.UI;

namespace JWMSY
{
    /// <summary>
    /// 二次拣货桌面端
    /// </summary>
    public partial class WorkSsDelivery : Form
    {
        /// <summary>
        /// 二次拣货桌面端构造函数
        /// </summary>
        public WorkSsDelivery()
        {
            InitializeComponent();
        }

        private SDataSet sds=new SDataSet();


        /// <summary>
        /// 报单系统用加盐加密
        /// </summary>
        /// <param name="sDataIn"></param>
        /// <returns></returns>
        public static string GetMd5OrderService(String sDataIn)
        {
            //加盐  "@abc*i"
            sDataIn = sDataIn + "pvgi2eb8HD";
            //初始化System.Security.Cryptography.MD5CryptoServiceProvider的新实例
            var md5 = new MD5CryptoServiceProvider();
            //将String.String字符串中的字符编码为一个字节序列 返回byte[]
            var bytValue = Encoding.UTF8.GetBytes(sDataIn);
            //计算指定字节数组的Hash值 返回byte[]
            var bytHash = md5.ComputeHash(bytValue);
            //释放资源
            md5.Clear();
            var sTemp = "";
            for (var i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            return sTemp.ToUpper();
        }

       

        private void txtcOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            if (lblOutAll.Text.Equals("已完成") && string.IsNullOrEmpty(tslblStatus.Text))
            {
                if (MessageBox.Show("前一订单已经完成拣货，但没有审核，是否立即审核", "是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes
                    )
                {
                    ApproveOrder();
                }
            }
            //通过WebService获取报单系统数据
            var js = new OrderService.WMS();
            js.Url = Properties.Settings.Default.JWMSY_OrderService_WMS;
            var ckNo = txtcOrderNumber.Text.ToUpper();
            var ckNoMd5 = GetMd5OrderService(ckNo);



            lblcOrderNumber.Text = txtcOrderNumber.Text.ToUpper();
            //先判断是否波次订单已经下载
            if (BoolLoadWaveOrder())
            {
                var iExist = js.IsExists(ckNo, ckNoMd5);


                if (iExist != 0)
                {
                    MessageBox.Show(@"此出库单号不存在报单系统!", @"Warning");
                    return;
                }
                
                if (cbxWaveOrder.Checked)
                {
                    var wfWithoutWaveOrder = new WmsFunction(BaseStructure.WmsCon);
                    var cmd = new SqlCommand
                    {
                        CommandText = "GenWaveOrder",
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@cWaveOrderNumber", txtcOrderNumber.Text);
                    cmd.Parameters.AddWithValue("@cOrderNumber", txtcOrderNumber.Text);

                    wfWithoutWaveOrder.ExecSqlCmd(cmd);
                }
                else
                {
                    MessageBox.Show(@"该单据未下载波次订单明细，
请先下载波次订单明细", @"Warning");
                    tstxtcWaveOrderNumber.Focus();
                    txtcOrderNumber.Text = "";
                    lblcOrderNumber.Text = "";
                    return;
                }
                
            }
            if (!BoolCanOkDownLoad())
            {
                txtcBarCode.Focus();
                return;
            }
            

           

            var strOrder = string.Empty;
            var strHeader = string.Empty;
            var strBody = string.Empty;
           
            DataTable dtHeader;
            DataTable dtBody;
            try
            {
                strOrder = js.GetProductDetail2(ckNo, ckNoMd5);
                if (!strOrder.Contains("<head>"))
                {
                    MessageBox.Show("无法连接到下载服务器！" + strOrder + js.Url + ckNoMd5 + ckNo, @"Warning");
                    return;
                }
                strHeader = strOrder.Substring(strOrder.IndexOf("<head>"), strOrder.IndexOf("</head>") - strOrder.IndexOf("<head>") + 7);
                strBody = strOrder.Remove(strOrder.IndexOf("<head>"), strOrder.IndexOf("</head>") - strOrder.IndexOf("<head>") + 7);
                dtHeader = CXmlFileToDataSet(strHeader).Tables[0];
                dtBody = CXmlFileToDataSet(strBody).Tables[0];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + strOrder + js.Url + ckNoMd5 + ckNo, @"Warning");
                return;
            }
   

            if (dtBody == null || dtHeader == null)
            {
                MessageBox.Show(@"下载出错,请联系管理员", @"Warning");
                return;
            }


            if (dtBody.Rows.Count < 1 || dtHeader.Rows.Count < 1)
            {
                MessageBox.Show(@"无此出库单号!", @"Warning");
                return;
            }
            var xname = dtHeader.Rows[0]["xname"].ToString();
            var addr = dtHeader.Rows[0]["addr"].ToString();
            var KH = dtHeader.Rows[0]["KH"].ToString();


            sds.dSSDelivery.Rows.Clear();
            //进行循环判断是否属于当前库区 
            for (var i = 0; i < dtBody.Rows.Count; i++)
            {var dr = sds.dSSDelivery.NewdSSDeliveryRow();
                dr.cOrderNumber = ckNo;
                dr.cInvCode = dtBody.Rows[i]["erpNo"].ToString();
                dr.cInvName = dtBody.Rows[i]["pName"].ToString();
                dr.iQuantity = dtBody.Rows[i]["Num"].ToString();
                dr.cCusName = xname;
                dr.cCusAddress = addr;
                dr.cCardNumber = KH;
                dr.cWhCode = dtBody.Rows[i]["erpcode"].ToString();
                sds.dSSDelivery.Rows.Add(dr);
            }
            var wf = new WmsFunction(BaseStructure.WmsCon);
            for (var i = 0; i <= sds.dSSDelivery.Rows.Count - 1; i++)
            {
                var cmd = new SqlCommand
                {
                    CommandText = "insert into SS_Delivery(cOrderNumber,cInvCode,cInvName,cUnit,iQuantity,iScanQuantity,cCusName,cCusAddress,cCardNumber,cWhCode) values(@cOrderNumber,@cInvCode,@cInvName,@cUnit,@iQuantity,0,@cCusName,@cCusAddress,@cCardNumber,@cWhCode)"
                };
                cmd.Parameters.AddWithValue("@cOrderNumber", sds.dSSDelivery.Rows[i]["cOrderNumber"]);
                cmd.Parameters.AddWithValue("@cInvCode", sds.dSSDelivery.Rows[i]["cInvCode"]);
                cmd.Parameters.AddWithValue("@cInvName", sds.dSSDelivery.Rows[i]["cInvName"]);
                cmd.Parameters.AddWithValue("@cUnit", "1");
                cmd.Parameters.AddWithValue("@iQuantity", sds.dSSDelivery.Rows[i]["iQuantity"]);
                cmd.Parameters.AddWithValue("@cCusName", sds.dSSDelivery.Rows[i]["cCusName"]);
                cmd.Parameters.AddWithValue("@cCusAddress", sds.dSSDelivery.Rows[i]["cCusAddress"]);
                cmd.Parameters.AddWithValue("@cCardNumber", sds.dSSDelivery.Rows[i]["cCardNumber"]);
                cmd.Parameters.AddWithValue("@cWhCode", sds.dSSDelivery.Rows[i]["cWhCode"]);
                wf.ExecSqlCmd(cmd);
            }
            //写下载日志
            var logCmd = new SqlCommand("AddLogAction");
            logCmd.CommandType = CommandType.StoredProcedure;
            logCmd.Parameters.AddWithValue("@cFunction", "出库单下载");
            logCmd.Parameters.AddWithValue("@cDescription", BaseStructure.LoginName + "下载出库单：" + sds.dSSDelivery.Rows[0]["cOrderNumber"]);
            
            wf.ExecSqlCmd( logCmd);
             sds.dSSDeliveryDetail.Clear();
             lblcBoxNumber.Text = "";
            RefreshGrid();
            txtcBarCode.Focus();
        }

        /// <summary>
        /// 读取Xml文件信息,并转换成DataSet对象
        /// </summary>
        /// <remarks>
        /// DataSet ds = new DataSet();
        /// ds = CXmlFileToDataSet("/XML/upload.xml");
        /// </remarks>
        /// <param name="xmlFilePath">Xml文件地址</param>
        /// <returns>DataSet对象</returns>
        public static DataSet CXmlFileToDataSet(string xmlStr)
        {
            if (!string.IsNullOrEmpty(xmlStr) && !xmlStr.Equals("-1"))
            {

                StringReader StrStream = null;
                XmlTextReader Xmlrdr = null;
                try
                {


                    DataSet ds = new DataSet();
                    //读取文件中的字符流
                    StrStream = new StringReader(xmlStr);
                    //获取StrStream中的数据
                    Xmlrdr = new XmlTextReader(StrStream);
                    //ds获取Xmlrdr中的数据
                    ds.ReadXml(Xmlrdr);
                    return ds;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    //释放资源
                    if (Xmlrdr != null)
                    {
                        Xmlrdr.Close();
                        StrStream.Close();
                        StrStream.Dispose();
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 是不可以满足下载出库通知单的条件
        /// </summary>
        /// <returns></returns>
        private bool BoolCanOkDownLoad()
        {
            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
                return true;
            
            var bCmd = new SqlCommand("select * from SS_Delivery where cOrderNumber=@cOrderNumber");
            bCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var dt = wf.GetSqlTable(bCmd);
            if (dt==null||dt.Rows.Count<1)
            {
               
                return true;
            }

            RefreshGrid();
            return false;
        }


        /// <summary>
        /// 是不可以满足下载波次订单的条件
        /// </summary>
        /// <returns></returns>
        private bool BoolLoadWaveOrder()
        {
            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
                return true;

            var bCmd = new SqlCommand("select top 1 cWaveOrderNumber from SF_Order where cOrderNumber=@cOrderNumber");
            bCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var strcWaveOrderNumber = wf.ReturnFirstSingle(bCmd);
            if (string.IsNullOrEmpty(strcWaveOrderNumber))
            {
                return true;
            }lblcWaveOrderNumber.Text = strcWaveOrderNumber;
            return false;
        }

        /// <summary>
        /// 产成品名称
        /// </summary>
        private string _cInvName;

        private string _cWhCode;

        /// <summary>
        /// 理论重量
        /// </summary>
        private int _TheoryiWeight;


        /// <summary>
        /// 箱规
        /// </summary>
        private int _iBoxFormat;
        /// <summary>
        /// 保存出库扫描,并重新进入出库单号的扫描获取
        /// </summary>
        private void SaveOutWareHouse(string cSerialNumber, string cInvCode, string cInvName, int iQuantity, decimal iWeight, string cLotNo)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var sqLiteCmd = new SqlCommand("insert into SS_Detail(cSerialNumber,cBoxNumber,cOrderNumber,cInvCode,cInvName,iQuantity,cUser,iWeight,dDate,dScanTime,cLotNo,cWhCode) " +
                                              "values(@cSerialNumber,@cBoxNumber,@cOrderNumber,@cInvCode,@cInvName,@iQuantity,@cUser,@iWeight,getdate(),getdate(),@cLotNo,@cWhCode)");
            sqLiteCmd.Parameters.AddWithValue("@cSerialNumber", cSerialNumber);
            sqLiteCmd.Parameters.AddWithValue("@cBoxNumber", lblcBoxNumber.Text);
            sqLiteCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            sqLiteCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            sqLiteCmd.Parameters.AddWithValue("@cInvName", cInvName);
            sqLiteCmd.Parameters.AddWithValue("@iQuantity", iQuantity);
            sqLiteCmd.Parameters.AddWithValue("@cUser", BaseStructure.LoginName);
            sqLiteCmd.Parameters.AddWithValue("@iWeight", iWeight);
            sqLiteCmd.Parameters.AddWithValue("@cLotNo", cLotNo);
            sqLiteCmd.Parameters.AddWithValue("@cWhCode", _cWhCode);
            wf.ExecSqlCmd(sqLiteCmd);

            var PlusCmd = new SqlCommand("update SS_Delivery set iScanQuantity=isnull(iScanQuantity,0)+@iQuantity where cOrderNumber=@cOrderNumber and cInvCode=@cInvCode ");
            PlusCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            PlusCmd.Parameters.AddWithValue("@iQuantity", iQuantity);
            PlusCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            wf.ExecSqlCmd(PlusCmd);
            txtcBarCode.Text = "";
            txtcBarCode.Focus();
            RefreshGrid();

        }


        private void RefreshGrid()
        {

            var wf = new WmsFunction(BaseStructure.WmsCon);

            var selectCmd = new SqlCommand("select * from SS_Detail where cOrderNumber=@cOrderNumber order by autoid desc");
            selectCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);

            uGridSsDeliveryDetail.DataSource = wf.GetSqlTable(selectCmd);
           

            var selectDeliveryCmd = new SqlCommand("select * from SS_Delivery where cOrderNumber=@cOrderNumber order by autoid desc");
            selectDeliveryCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            uGridSsDelivery.DataSource = wf.GetSqlTable(selectDeliveryCmd);

            foreach (var uRow in uGridSsDelivery.Rows)
            {
                if (uRow.Cells["iQuantity"].Value.ToString().Equals(uRow.Cells["iScanQuantity"].Value.ToString()))
                {
                    uRow.Appearance.BackColor = Color.LightGreen;
                }
                else
                {
                    uRow.Appearance.BackColor = Color.White;
                }
            }
            var bOutAllCmd = new SqlCommand("select * from SS_Delivery where cOrderNumber=@cOrderNumber and isnull(iScanQuantity,0)<isnull(iQuantity,0)");
            bOutAllCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            var cOrderNumber = lblcOrderNumber.Text;
            if (wf.BoolExistTable(bOutAllCmd))
            {
                lblOutAll.Text = @"未完成";
                tsbtnApprove.Enabled = false;
                tslblStatus.Text = "";

            }
            else
            {

                lblOutAll.Text = @"完成";
                txtcOrderNumber.Text = "";
                var bDelete = IsDeleteFromOrder(lblcOrderNumber.Text);
                if (bDelete)
                {
                    //var Deletecmd = new SqlCommand("delete from SS_Delivery_detail where cOrderNumer=@cOrderNumber");
                    //Deletecmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
                    //wf.ExecSqlCmd(Deletecmd);
                }
                txtcOrderNumber.Focus();
                tsbtnApprove.Enabled = true;

            }

            var cmd = new SqlCommand("update SF_Order set cState=@cState,dLastUpdate=getdate(),cOperator=@cOperator  where cOrderNumber=@cOrderNumber");
            cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
            cmd.Parameters.AddWithValue("@cState", lblOutAll.Text);
            cmd.Parameters.AddWithValue("@cOperator", BaseStructure.LoginName);
            wf.ExecSqlCmd(cmd);
            BoolLoadWaveOrder();
            BoolApproveOrder();
            GetSFOrderDetail(lblcWaveOrderNumber.Text);
            
        }



        private void BoolApproveOrder()
        {
            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
                return;

            var bCmd = new SqlCommand("select * from Wms_M_Eas where cOrderNumber=@cOrderNumber");
            bCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bA = wf.BoolExistTable(bCmd);
            if (bA)
            {
                tslblStatus.Text = @"已审核";
            }
            else
            {
                tslblStatus.Text = "";
            }
        }

        private void RefreshGrid(string cOrderNumber)
        {

            var wf = new WmsFunction(BaseStructure.WmsCon);

            var selectCmd = new SqlCommand("select * from SS_Detail where cOrderNumber=@cOrderNumber order by autoid desc");
            selectCmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);

            uGridSsDeliveryDetail.DataSource = wf.GetSqlTable(selectCmd);


            var selectDeliveryCmd = new SqlCommand("select * from SS_Delivery where cOrderNumber=@cOrderNumber order by autoid desc");
            selectDeliveryCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            uGridSsDelivery.DataSource = wf.GetSqlTable(selectDeliveryCmd);

            foreach (var uRow in uGridSsDelivery.Rows)
            {
                if (uRow.Cells["iQuantity"].Value.ToString().Equals(uRow.Cells["iScanQuantity"].Value.ToString()))
                {
                    uRow.Appearance.BackColor = Color.LightGreen;
                }
                else
                {
                    uRow.Appearance.BackColor = Color.White;
                }
            }
            var bOutAllCmd = new SqlCommand("select * from SS_Delivery where cOrderNumber=@cOrderNumber and isnull(iScanQuantity,0)<isnull(iQuantity,0)");
            bOutAllCmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);

            if (wf.BoolExistTable(bOutAllCmd))
            {
                lblOutAll.Text = @"未完成";
                tsbtnApprove.Enabled = false;
                tslblStatus.Text = "";
                
            }
            else
            {
                lblOutAll.Text = @"完成";
                lblcOrderNumber.Text = "";
                txtcOrderNumber.Text = "";
                tsbtnApprove.Enabled = true;
                txtcOrderNumber.Focus();
            }


            var cmd = new SqlCommand("update SF_Order set cState=@cState  where cOrderNumber=@cOrderNumber");
            cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
            cmd.Parameters.AddWithValue("@cState", lblOutAll.Text);
            wf.ExecSqlCmd(cmd);


            BoolLoadWaveOrder();
            GetSFOrderDetail(lblcWaveOrderNumber.Text);
        }

        /// <summary>
        /// 判断出库产品的序列号是否已经出库
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <returns></returns>
        private bool JudgeBarCode(string cSerialNumber)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bDeliveryCmd = new SqlCommand("select cInvCode,cInvName from SS_Detail where cSerialNumber=@cSerialNumber");
            bDeliveryCmd.Parameters.AddWithValue("@cSerialNumber", cSerialNumber);
            if (wf.BoolExistTable(bDeliveryCmd))
            {
                MessageBox.Show(@"该序列号已经扫描！");
                txtcBarCode.Text = "";
                txtcBarCode.Focus();
                return false;
            }
            return true;
        }


        /// <summary>
        /// 获取波次单未完成单据数
        /// </summary>
        /// <param name="cWaveOrderNumber"></param>
        /// <returns></returns>
        private void GetSFOrderDetail(string cWaveOrderNumber)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bSFCmd = new SqlCommand("GetSFOrderDetail"){CommandType=CommandType.StoredProcedure};
            bSFCmd.Parameters.AddWithValue("@cWaveOrderNumber", cWaveOrderNumber);
            var sTemp = wf.ReturnFirstSingle(bSFCmd);
            tslbliRQuantity.Text = sTemp;
        }



        /// <summary>
        /// 判断出库的产品是否包含在出库单中
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <returns></returns>
        private bool JudgeInvCode(string cInvCode)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bOutAllCmd = new SqlCommand("select cInvCode,cInvName,cWhCode from SS_Delivery where cInvCode=@cInvCode and cOrderNumber=@cOrderNumber");
            bOutAllCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            bOutAllCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            var dt = wf.GetSqlTable(bOutAllCmd);
            if (dt == null || dt.Rows.Count < 1)
            {
                MessageBox.Show(@"该出库单不包含此产品！");
                txtcBarCode.Text = "";
                txtcBarCode.Focus();
                return false;

            }
            _cInvName = dt.Rows[0]["cInvName"].ToString();
            _cWhCode = dt.Rows[0]["cWhCode"].ToString();
            return true;
        }


        /// <summary>
        /// 判断该产品的批号是否全部出完
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <returns></returns>
        private bool OutAll(string cInvCode, int iQuantity)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bOutAllCmd = new SqlCommand("select * from SS_Delivery where cInvCode=@cInvCode and (isnull(iScanQuantity,0)+@iQuantity)<=iQuantity and cOrderNumber=@cOrderNumber");
            bOutAllCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            bOutAllCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            bOutAllCmd.Parameters.AddWithValue("@iQuantity", iQuantity);
            if (!wf.BoolExistTable(bOutAllCmd))
            {
                MessageBox.Show(@"该产品已经拣货完成");
                txtcBarCode.Text = "";
                txtcBarCode.Focus();
                return false;

            }
            return true;
        }

        /// <summary>
        /// 根据商品码取得虚拟条码
        /// </summary>
        /// <param name="cBarCode"></param>
        /// <returns></returns>
        private string GetInventoryMapping(string cBarCode)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var cmd = new SqlCommand("select  cVirtualBarCode  from BInventoryMapping where cEBarCode=@cEBarCode");
            cmd.Parameters.AddWithValue("@cEBarCode", cBarCode);

            var cVirtualBarCode = wf.ReturnFirstSingle(cmd);

            return cVirtualBarCode;
        }

        private bool ExistsBoxNumber(string cBoxNumber)
        {
            if (cBoxNumber.Equals(bcMain.Text))
                return true;
            var wf=new WmsFunction(BaseStructure.WmsCon);
            var cmd = new SqlCommand("select  * from SS_Box where cBoxNumber=@cBoxNumber");
            cmd.Parameters.AddWithValue("@cBoxNumber", cBoxNumber);
            return wf.BoolExistTable(cmd);
        }

        private bool ExistsBoxNumberInOtherOrder(string cBoxNumber,string cOrderNumber)
        {
            if (cBoxNumber.Equals(bcMain.Text))
                return false;
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var cmd = new SqlCommand("select  * from SS_Detail where cBoxNumber=@cBoxNumber and cOrderNumber!=@cOrderNumber");

            cmd.Parameters.AddWithValue("@cBoxNumber", cBoxNumber);
            cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
            return wf.BoolExistTable(cmd);
        }

        private void txtcBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            

            var cBarCode = txtcBarCode.Text;
            if (string.IsNullOrEmpty(lblcBoxNumber.Text) || cBarCode.Contains("BX"))
            {
                if (!cBarCode.Contains("BX"))
                {
                    MessageBox.Show(@"请先扫描箱号", @"Error");
                    txtcBarCode.Text = "";
                    txtcBarCode.Focus();
                    lblcBoxNumber.Text = "";
                    return;
                }
                var indexBox = cBarCode.IndexOf("boxnumber=");
                var lengthBox = cBarCode.Length;
                if (indexBox < 1&&lengthBox==14)
                {
                    if (!ExistsBoxNumber(cBarCode))
                    {
                        MessageBox.Show(@"此箱号不正确，非系统箱号");
                        txtcBarCode.Text = "";
                        txtcBarCode.Focus();
                        lblcBoxNumber.Text = "";
                        return;
                    }

                    //if (ExistsBoxNumberInOtherOrder(cBarCode, lblcOrderNumber.Text))
                    //{
                    //    MessageBox.Show(@"此箱号已被其他订单所使用，请注意！");
                    //    txtcBarCode.Text = "";
                    //    txtcBarCode.Focus();
                    //    lblcBoxNumber.Text = "";
                    //    return;
                    //}
                    lblcBoxNumber.Text = cBarCode;
                    txtcBarCode.Text = "";
                    txtcBarCode.Focus();
                    return;
                }
                if (indexBox < 1)
                {
                    MessageBox.Show(@"请输入正确的箱号");
                    txtcBarCode.Text = "";
                    txtcBarCode.Focus();
                    lblcBoxNumber.Text = "";
                    return;
                }
                var cBoxNumber = cBarCode.Substring(indexBox + 10, lengthBox - indexBox - 10);
                if (!ExistsBoxNumber(cBoxNumber))
                {
                    MessageBox.Show(@"此箱号不正确，非系统箱号");
                    txtcBarCode.Text = "";
                    txtcBarCode.Focus();
                    lblcBoxNumber.Text = "";
                    return;
                }

                //if (ExistsBoxNumberInOtherOrder(cBoxNumber, lblcOrderNumber.Text))
                //{
                //    MessageBox.Show(@"此箱号已被其他订单所使用，请注意！");
                //    txtcBarCode.Text = "";
                //    txtcBarCode.Focus();
                //    lblcBoxNumber.Text = "";
                //    return;
                //}


                lblcBoxNumber.Text = cBarCode.Substring(indexBox + 10, lengthBox - indexBox - 10);
                txtcBarCode.Text = "";
                return;
            }
            //此处取消扫描的商品码功能
            //if (txtcBarCode.Text.Length == 13)
            //{
            //    cBarCode = GetInventoryMapping(txtcBarCode.Text);
            //}

            if (lblcBoxNumber.Text.Equals(bcMain.Text))
            {
                if(MessageBox.Show(@"当前正在使用虚拟整箱用箱条码，
只有当不需要真实拼箱时才能使用虚拟箱条码，如果不是请点击否！",@"是否为整箱",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)!=DialogResult.Yes)
                    return;
            }

            if (cBarCode.Length == 12 || cBarCode.Length == 14)
            {
                cBarCode = DllWmsMain.GetBarCodeBySerialNumber(cBarCode);
            }if (!cBarCode.Contains("I*") || !cBarCode.Contains("*C*") || !cBarCode.Contains("*L*"))
            {
                MessageBox.Show(@"无效条码", @"Error");
                txtcBarCode.Text = "";
                txtcBarCode.Focus();
                return;
            }
            //物料编码
            var cInvCode = cBarCode.Substring(cBarCode.IndexOf("I*") + 2, cBarCode.IndexOf("*C*") - 2 - cBarCode.IndexOf("I*"));
            //产品序列号
            var cSerialNumber = cBarCode.Substring(cBarCode.IndexOf("*C*") + 3, cBarCode.IndexOf("*L*") - cBarCode.IndexOf("*C*") - 3);

            //产品批号
            var cLotNo = cBarCode.Substring(cBarCode.IndexOf("*L*") + 3, cBarCode.Length - cBarCode.IndexOf("*L*") - 3);


            //判断该产品序列号是否已经被扫描
           

            //判断波次订单中是否存在此出库要求产品
            if (!JudgeInvCode(cInvCode))
                return;

            //判断要拣货的产品是否已经全部拣完
            if (spMain.IsOpen)
            {
                spMain.Close();
            }
            //获取当前产品剩余量
            var iRemainQuantity = GetRemainQuantity(cInvCode);
            if (iRemainQuantity == 0)
            {
                MessageBox.Show(@"当前扫描产品的未拣货量为0，请检查！");
                txtcBarCode.Focus();
                return;
            }

            _TheoryiWeight = GetTheoryWeight(cInvCode);
            _iBoxFormat = GetBoxFormat(cInvCode);

            if (cSerialNumber.StartsWith("ZZ"))
            {
                //此处添加如果是周转箱扫描，则查询取得它的真实批号
                cLotNo = GetProductBoxLotNo(cSerialNumber);
                using (var pgq = new PdaGetIntQuantity(cInvCode, _cInvName, cLotNo, false, iRemainQuantity, _TheoryiWeight, _iBoxFormat,cSerialNumber))
                {
                    if (pgq.ShowDialog() != DialogResult.Yes)
                    {
                        txtcBarCode.Text = "";
                        return;
                    }
                    if (!OutAll(cInvCode, pgq.IQuantity))
                    {
                        txtcBarCode.Text = "";
                        return;
                    }
                    //通过校验后进行波次拣货保存
                    SaveOutWareHouse(cSerialNumber, cInvCode, _cInvName, pgq.IQuantity,pgq.IWeight,pgq.cNewLotNo);
                    txtcBarCode.Text = "";
                }
            }
            else
            {
                cLotNo = GetProductLotNo(cSerialNumber);
                if (!JudgeBarCode(cSerialNumber))
                    return;

                if (!OutAll(cInvCode, 1))
                {
                    txtcBarCode.Text = "";
                    return;
                }

                using (var pgq = new PdaGetIntQuantity(cInvCode, _cInvName, cLotNo, true, iRemainQuantity, _TheoryiWeight, _iBoxFormat,cSerialNumber))
                {
                    if (pgq.ShowDialog() != DialogResult.Yes)
                    {
                        txtcBarCode.Text = "";
                        return;
                    }
                    if (!OutAll(cInvCode, pgq.IQuantity))
                    {
                        txtcBarCode.Text = "";
                        return;
                    }
                    //通过校验后进行波次拣货保存
                    SaveOutWareHouse(cSerialNumber, cInvCode, _cInvName,pgq.IQuantity,pgq.IWeight,pgq.cNewLotNo);
                    txtcBarCode.Text = "";
                }
            }
            txtcBarCode.Text = "";
        }

        private void WorkSsDelivery_Load(object sender, EventArgs e)
        {
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);

            //获取当前所有打印机
            for (var i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                cbxPrint.Items.Add(PrinterSettings.InstalledPrinters[i]);
            }
        }

        /// <summary>
        /// 根据扫描的周转箱序列号取得该的周转箱的批号
        /// </summary>
        /// <param name="cSerialNumber"></param>
        /// <returns></returns>
        private string GetProductBoxLotNo(string cSerialNumber)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var LotCmd = new SqlCommand("select cLotNo from  View_Bar_Product_Box_SerialNumber where cSerialNumber=@cSerialNumber");
            LotCmd.Parameters.AddWithValue("@cSerialNumber", cSerialNumber);
            return wf.ReturnFirstSingle(LotCmd);
        }

        /// <summary>
        /// 根据扫描的周转箱序列号取得该的周转箱的批号
        /// </summary>
        /// <param name="cSerialNumber"></param>
        /// <returns></returns>
        private string GetProductLotNo(string cSerialNumber)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var LotCmd = new SqlCommand("select cLotNo from  View_Bar_Product_SerialNumber where cSerialNumber=@cSerialNumber");
            LotCmd.Parameters.AddWithValue("@cSerialNumber", cSerialNumber);
            return wf.ReturnFirstSingle(LotCmd);
        }

        private int GetRemainQuantity(string cInvCode)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bOutAllCmd = new SqlCommand("select isnull(iQuantity,0)-isnull(iScanQuantity,0) iQuantity from SS_Delivery where cInvCode=@cInvCode  and cOrderNumber=@cOrderNumber");
            bOutAllCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            bOutAllCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            int iRemainQuantity;
            var cRemainQuantity = wf.ReturnFirstSingle(bOutAllCmd);
            if (int.TryParse(cRemainQuantity, out iRemainQuantity))
            {
                return iRemainQuantity;
            }
            return 0;
        }

        private int GetTheoryWeight(string cInvCode)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bOutAllCmd = new SqlCommand("select isnull(iWeight,0) iWeight from IT_Product where cInvCode=@cInvCode");
            bOutAllCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            int iTheoryWeight;
            var cTheoryWeight = wf.ReturnFirstSingle(bOutAllCmd);
            if (int.TryParse(cTheoryWeight, out iTheoryWeight))
            {
                return iTheoryWeight;
            }
            return 0;
        }

        private int GetBoxFormat(string cInvCode)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bOutAllCmd = new SqlCommand("select isnull(iBoxFormat,0) iWeight from IT_Product where cInvCode=@cInvCode");
            bOutAllCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            int iBoxFormat;
            var cBoxFormat = wf.ReturnFirstSingle(bOutAllCmd);
            if (int.TryParse(cBoxFormat, out iBoxFormat))
            {
                return iBoxFormat;
            }
            return 0;
        }


        private void tsbtnAddBox_Click(object sender, EventArgs e)
        {
            lblcBoxNumber.Text = string.Empty;
            txtcBarCode.Focus();
        }

        private void uGridSsDeliveryDetail_Click(object sender, EventArgs e)
        {
            txtcBarCode.Focus();
        }

        private void uGridSsDelivery_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            txtcBarCode.Focus();
        }

        private void tsbtnReplaceBox_Click(object sender, EventArgs e)
        {
            var cOrderNumber = uGridSsDeliveryDetail.Rows[0].Cells["cOrderNumber"].Value.ToString();
            if (uGridSsDeliveryDetail.Rows.Count < 1)
                using (var ssd = new WorkSSReplaceBox(lblcBoxNumber.Text, cOrderNumber)
            )
            {
                ssd.ShowDialog();
            }
            RefreshGrid(cOrderNumber);
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uGridSsDeliveryDetail_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblcBoxNumber.Text))
            {
                MessageBox.Show(@"箱号必输");
                return;

            }


            var cmd = new SqlCommand("update SS_Box set iWeight=@iWeight,dWeight=Getdate() where cBoxNumber=@cBoxNumber");
            cmd.Parameters.AddWithValue("@iWeight", uteiWeight.Value ?? 0);
            cmd.Parameters.AddWithValue("@cBoxNumber", lblcBoxNumber.Text);

            var wf = new WmsFunction(BaseStructure.WmsCon);
            if (wf.ExecSqlCmd(cmd))
            {
                MessageBox.Show(@"箱重量更新成功");
                lblcBoxNumber.Text = "";
            }
            else
            {
                MessageBox.Show(@"更新失败,请检查箱号是否存在！");
            }

            if (!spMain.IsOpen) return;
            spMain.Close();
            txtcBarCode.Focus();

        }

        private void uteiWeight_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (spMain.IsOpen)
            {
                return;
            }
            try
            {
                spMain.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Com1口打开失败
" + ex.Message);
            }
        }
        
        private void spMain_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //判断Com口是否打开
                if(spMain== null)
                    return;
                if (!spMain.IsOpen) return;
                Thread.Sleep(200);
                var bytes = spMain.BytesToRead;
                var buffer = new byte[bytes];
                spMain.Read(buffer, 0, bytes);
                var strbuffer = Encoding.ASCII.GetString(buffer);

                //判断获取的值是否正常
                if (strbuffer.Length < 5)
                    return;
                var strWeight = strbuffer.Substring(2, 5);
                decimal iWeight;
                if (decimal.TryParse(strWeight, out iWeight))
                {
                    uteiWeight.Value = iWeight;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void uGridSsDeliveryDetail_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            decimal iWeight;
            var cWeight = e.Cell.Value.ToString();
            if (decimal.TryParse(cWeight, out iWeight))
            {
                var cmd = new SqlCommand("update SS_detail set iWeight=@iWeight where autoid=@autoid");
                cmd.Parameters.AddWithValue("@iWeight", iWeight);
                cmd.Parameters.AddWithValue("@autoid", e.Cell.Row.Cells["AutoID"].Value);

                var wf = new WmsFunction(BaseStructure.WmsCon);
                if (wf.ExecSqlCmd(cmd))
                {
                    MessageBox.Show(@"更新成功");
                }
                else
                {
                    MessageBox.Show(@"更新失败！");
                }
                txtcBarCode.Focus();
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            if (MessageBox.Show(@"确定删除当前行?", @"确定删除?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button3) != DialogResult.Yes) return;


            var minusCmd = new SqlCommand("DeleteFromDeliverySScan"){CommandType = CommandType.StoredProcedure};
            minusCmd.Parameters.AddWithValue("@AutoID", uGridSsDeliveryDetail.ActiveRow.Cells["AutoID"].Value);
            minusCmd.Parameters.AddWithValue("@cOrderNumber", uGridSsDeliveryDetail.ActiveRow.Cells["cOrderNumber"].Value);
            minusCmd.Parameters.AddWithValue("@cInvCode", uGridSsDeliveryDetail.ActiveRow.Cells["cInvCode"].Value);
            minusCmd.Parameters.AddWithValue("@iQuantity", uGridSsDeliveryDetail.ActiveRow.Cells["iQuantity"].Value);
            wf.ExecSqlCmd(minusCmd);

            RefreshGrid();
        }

        private void uGridSsDelivery_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            if (string.IsNullOrEmpty(lblcBoxNumber.Text))
            {
                MessageBox.Show(@"请先扫描箱号");
                
                return;
            }
            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
            {
                MessageBox.Show(@"请先扫描单号");
                return;
            }


            var cInvCode = e.Row.Cells["cInvCode"].Value.ToString();
            //产品序列号
            var cSerialNumber = "ZNoLot0000";

            //产品批号
            var cLotNo = "";


            //判断该产品序列号是否已经被扫描


            //判断波次订单中是否存在此出库要求产品
            if (!JudgeInvCode(cInvCode))
                return;

            //判断要拣货的产品是否已经全部拣完
            if (spMain.IsOpen)
            {
                spMain.Close();
            }
            //获取当前产品剩余量
            var iRemainQuantity = GetRemainQuantity(cInvCode);
            if (iRemainQuantity == 0)
            {
                MessageBox.Show(@"当前扫描产品的未拣货量为0，请检查！");
                txtcBarCode.Focus();
                return;
            }

            _TheoryiWeight = GetTheoryWeight(cInvCode);
            _iBoxFormat = GetBoxFormat(cInvCode);

            if (cSerialNumber.StartsWith("Z"))
            {
                using (var pgq = new PdaGetIntQuantity(cInvCode, _cInvName, cLotNo, false, iRemainQuantity, _TheoryiWeight, _iBoxFormat,cSerialNumber))
                {
                    if (pgq.ShowDialog() != DialogResult.Yes)
                    {
                        txtcBarCode.Text = "";
                        return;
                    }
                    if (!OutAll(cInvCode, pgq.IQuantity))
                    {
                        txtcBarCode.Text = "";
                        return;
                    }
                    //通过校验后进行波次拣货保存
                    SaveOutWareHouse(cSerialNumber, cInvCode, _cInvName, pgq.IQuantity, pgq.IWeight,pgq.cNewLotNo);
                    txtcBarCode.Text = "";
                }
            }
            txtcBarCode.Focus();
            txtcBarCode.Text = "";
        }

        private void tstxtcWaveOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            var wf = new WmsFunction(BaseStructure.WmsCon);
           
            var cWaveOrder = tstxtcWaveOrderNumber.Text.ToUpper();
            var cWaveNumberMd5 = GetMd5OrderService(cWaveOrder);



            var strOrder = string.Empty;
            var strBody = string.Empty;
            //通过WebService获取报单系统数据
            var js = new OrderService.WMS();
            js.Url = Properties.Settings.Default.JWMSY_OrderService_WMS;
            DataTable dt;
           try
           {
                strOrder = js.GetBatchRunno(cWaveOrder, cWaveNumberMd5);


                strBody = strOrder.Substring(strOrder.IndexOf("<root>")+6, strOrder.IndexOf("</root>") - strOrder.IndexOf("<head>") - 7);
                
                dt = CXmlFileToDataSet(strBody).Tables[0];

            }
            
            catch (Exception ex)
           {

               MessageBox.Show(ex.Message + strOrder + js.Url , @"Warning");
              return;
            }  

            for (var i = 0; i <= dt.Rows.Count - 1; i++)
            {
                var cmd = new SqlCommand
                {
                    CommandText = "GenWaveOrder",CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@cWaveOrderNumber",tstxtcWaveOrderNumber.Text);
                cmd.Parameters.AddWithValue("@cOrderNumber", dt.Rows[i][0]);
                
                wf.ExecSqlCmd(cmd);
            }
            //写下载日志
            var logCmd = new SqlCommand("AddLogAction");
            logCmd.CommandType = CommandType.StoredProcedure;
            logCmd.Parameters.AddWithValue("@cFunction", "波次单下载");
            logCmd.Parameters.AddWithValue("@cDescription", string.Format("{0}下载波次单：{1}", BaseStructure.LoginName, cWaveOrder));

            wf.ExecSqlCmd(logCmd);
            lblcWaveOrderNumber.Text = cWaveOrder;
            //BoolLoadWaveOrder();
            tstxtcWaveOrderNumber.Text = "";
            txtcOrderNumber.Focus();
            GetSFOrderDetail(cWaveOrder);
        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            
            ApproveOrder();
        }

        private void ApproveOrder()
        {
            if (!lblOutAll.Text.Equals("完成"))
            {
                MessageBox.Show(@"未完成订单不允许审核，导入EAS");
                return;
            }
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var dCmd = new SqlCommand("DeliveryToMidEas");
            dCmd.CommandType = CommandType.StoredProcedure;
            dCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            dCmd.Parameters.AddWithValue("@cGuid", Guid.NewGuid());
            wf.ExecSqlCmd(dCmd);
            MessageBox.Show(@"审核成功，不再允许修改此订单，导入EAS");
            tslblStatus.Text = @"已审核";
        }

        private void bcMain_DoubleClick(object sender, EventArgs e)
        {
            lblcBoxNumber.Text = bcMain.Text;
        }

        private void tsbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
                return;
            var wf=new WmsFunction(BaseStructure.WmsCon);
            var cmd = new SqlCommand("update SF_Order set cState=@cState,dLastUpdate=getdate(),cOperator=@cOperator  where cOrderNumber=@cOrderNumber");
            cmd.Parameters.AddWithValue("@cOrderNumber", lblcBoxNumber.Text);
            cmd.Parameters.AddWithValue("@cState", "完成");
            cmd.Parameters.AddWithValue("@cOperator", BaseStructure.LoginName);
            wf.ExecSqlCmd(cmd);
        }


        private bool IsDeleteFromOrder(string cOrderNumber)
        {
            var ckNo = cOrderNumber.ToUpper();
            var ckNoMd5 = GetMd5OrderService(ckNo);
            //通过WebService获取报单系统数据
            var js = new OrderService.WMS();
            js.Url = Properties.Settings.Default.JWMSY_OrderService_WMS;
            var iExist = js.IsExists(ckNo, ckNoMd5);


            if (iExist != 0) return false;
            MessageBox.Show(@"此出库单号，已经被报单系统撤单，无法出库
系统将清除此次所有子记录!", @"Warning");
            return true;
        }

        private void btnPrintBoxDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblcOrderNumber.Text)||string.IsNullOrEmpty(lblcBoxNumber.Text))
                return;
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var cmd = new SqlCommand("GetBoxDetailByBoxNumber") {CommandType = CommandType.StoredProcedure};

            cmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cBoxNumber", lblcBoxNumber.Text);
            var dt =wf.GetSqlTable(cmd);
            PrintDialog("print", dt, lblcBoxNumber.Text);
        }


        /// <summary>
        /// 打印操作
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="dtSource"></param>
        public void PrintDialog(string operation,DataTable dtSource,string cBoxNumber)
        {

            var xtreport = new XtraReport();
            // _btApp = new BarTender.Application();
            //判断当前打印模版路径是否存在
            var temPath = Application.StartupPath + @"\Stencil\SSDeliveryBoxDetail.repx";

            if (!File.Exists(temPath))
            {
                MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xtreport.ShowDesigner();
                return;
            }
            xtreport.LoadLayout(temPath);
            xtreport.PrinterName = cbxPrint.Text;
            xtreport.RequestParameters = false;
            xtreport.ShowPrintStatusDialog = false;
            xtreport.ShowPrintMarginsWarning = false;
            //模板赋值
            for (var i = 0; i < uGridSsDelivery.DisplayLayout.Bands[0].Columns.Count; i++)
            {
                var cKey = uGridSsDelivery.DisplayLayout.Bands[0].Columns[i].Key;
                string cValue;
                if (uGridSsDelivery.Rows.Count>0)
                {
                    cValue = uGridSsDelivery.Rows[0].Cells[i].Value.ToString();
                }
                else
                {
                    cValue = "";
                }
                DLL.DllWorkPrintLabel.SetParametersValue(xtreport, cKey, cValue);
            }
            DLL.DllWorkPrintLabel.SetParametersValue(xtreport, "cBoxNumber", cBoxNumber);
            xtreport.DataSource = dtSource;
            switch (operation)
            {
                case "print":
                    xtreport.Print();
                    break;
                case "design":
                    xtreport.ShowDesigner();
                    break;
                case "preview":
                    xtreport.ShowPreview();
                    break;
            }

        }

        private void tsbtnLotPrintBoxDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
                return;
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var cmdBox = new SqlCommand("select cBoxNumber from SS_Detail where cOrderNumber=@cOrderNumber group by cBoxNumber ");
            cmdBox.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            var dtBox = wf.GetSqlTable(cmdBox);
            if (dtBox == null || dtBox.Rows.Count < 1)
            {
                return;
            }
            for (var i = 0; i < dtBox.Rows.Count; i++)
            {
                var cmd = new SqlCommand("GetBoxDetailByBoxNumber") { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
                cmd.Parameters.AddWithValue("@cBoxNumber", dtBox.Rows[i]["cBoxNumber"].ToString());
                var dt = wf.GetSqlTable(cmd);
                PrintDialog("print", dt,lblcBoxNumber.Text);
            }

        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblcOrderNumber.Text) || string.IsNullOrEmpty(lblcBoxNumber.Text))
                return;
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var cmd = new SqlCommand("GetBoxDetailByBoxNumber") { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cBoxNumber", lblcBoxNumber.Text);
            var dt = wf.GetSqlTable(cmd);
            PrintDialog("design", dt,lblcBoxNumber.Text);
        }
           
    }
}
