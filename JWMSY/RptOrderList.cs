using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors.Design;
using DevExpress.XtraReports.UI;
using JWMSY.DLL;


namespace JWMSY
{
    public partial class RptOrderList : Form
    {
        public RptOrderList()
        {
            InitializeComponent();
        }

        SDataSet sds = new SDataSet();

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnAnalysis_Click(object sender, EventArgs e)
        {
            //清除原数据
            TruncateTmpTable();var cWaveOrder = tstxtcWaveOrderNumber.Text.ToUpper();
            var cWaveNumberMd5 = GetMd5OrderService(cWaveOrder);



            var strOrder = string.Empty;
            var strBody = string.Empty;
            //通过WebService获取报单系统数据
            var js = new OrderService.WMS();

            DataTable dt;
            try
            {
                strOrder = js.GetBatchRunno(cWaveOrder, cWaveNumberMd5);


                strBody = strOrder.Substring(strOrder.IndexOf("<root>") + 6, strOrder.IndexOf("</root>") - strOrder.IndexOf("<head>") - 7);

                dt = CXmlFileToDataSet(strBody).Tables[0];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + strOrder + js.Url, @"Warning");
                return;
            }

            var cGuid = Guid.NewGuid().ToString();

            for(var i=0;i<dt.Rows.Count;i++)
            {
                SaveOrderList(cWaveOrder, dt.Rows[i][0].ToString(), cGuid);
            }


            sds.OrderListDetail.Clear();
            sds.OrderListDetailSecond.Clear();
            //分析波次数据
            //GetWave(tstxtcGuid.Text);

            //取产品数据
            GetInventory(cGuid, sds.OrderListDetail);
            //获取订单数据
            var dtOrderNumber = GetOrderList(cGuid);

            sds.OrderListDetailSecond.Rows.Clear();

            pbMain.Maximum = sds.OrderListDetail.Rows.Count - 1;
            for (var i = 0; i < sds.OrderListDetail.Rows.Count; i++)
            {
                pbMain.Value = i;
                Application.DoEvents();
                var cInvCode = sds.OrderListDetail.Rows[i]["cInvCode"].ToString();
                var bFirst = true;
                for (var j = 0; j < dtOrderNumber.Rows.Count; j++)
                {
                    var cOrderNumber = dtOrderNumber.Rows[j]["cOrderNumber"].ToString();
                    var dtQuantity = GetInvAndQuantity(cInvCode, cOrderNumber, cGuid);
                    if (dtQuantity.Rows.Count > 0)
                    {

                        var dr = sds.OrderListDetailSecond.NewOrderListDetailSecondRow();

                        if (bFirst)
                        {
                            dr.cInvCode = sds.OrderListDetail.Rows[i]["cInvCode"].ToString();
                            dr.iQuantity = sds.OrderListDetail.Rows[i]["iQuantity"].ToString();
                            dr.cInvName = sds.OrderListDetail.Rows[i]["cInvName"].ToString();
                        }
                        bFirst = false; dr.cOrderNumber = cOrderNumber;

                        dr.iOrderQuantity = dtQuantity.Rows[0]["iQuantity"].ToString(); 
                        dr.cCusName = dtQuantity.Rows[0]["cCusName"].ToString();

                        dr.iBox = string.IsNullOrEmpty(dtQuantity.Rows[0]["iBox"].ToString())
                            ? ""
                            : dtQuantity.Rows[0]["iBox"].ToString();
                        dr.iTa = dtQuantity.Rows[0]["iTa"].ToString().Equals("0")
                            ? ""
                            : dtQuantity.Rows[0]["iTa"].ToString();

                        dr.iOdd = dtQuantity.Rows[0]["iOdd"].Equals("0") || string.IsNullOrEmpty(dtQuantity.Rows[0]["iOdd"].ToString())
                            ? ""
                            : dtQuantity.Rows[0]["iOdd"].ToString(); 
                        sds.OrderListDetailSecond.Rows.Add(dr);
                    }

                }
            }
            uGridOrderMain.DataSource = sds.OrderListDetailSecond;
            //var data = from a in sds.OrderListDetailSecond
            //               group a by new { a.cInvCode, a.cInvName } 
            //               into b
            //               select new {GroupId = b.Key.cInvCode,
            //                   Id = b.Key.cInvCode,
            //                   cSumBox = b.Sum(c => c.iBox),
            //                   cUnionBox = b.Sum(c => c.iOdd)
            //               };

            //uGridOrderMain.DataSource = sds.OrderListDetailSecond;

            //ugWave.DataSource = data;

            //分析波次数据
            GetUnionBox(cGuid);
        }


        private void SaveOrderList(string cWaveOrderNumber, string cOrderNumber, string cGuid)
        {
            var ckNo = cOrderNumber;
            var ckNoMd5 = GetMd5OrderService(ckNo);



            var strOrder = string.Empty;
            var strHeader = string.Empty;
            var strBody = string.Empty;
            //通过WebService获取报单系统数据
            var js = new OrderService.WMS();

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

            var wf = new WmsFunction(BaseStructure.WmsCon);
            //进行循环判断是否属于当前库区 
            for (var i = 0; i < dtBody.Rows.Count; i++)
            {
                var cmd = new SqlCommand
                {
                    CommandText = "insert into Tmp_OrderList(cGuid,cWaveOrderNumber,cOrderNumber,cInvCode,cInvName,iQuantity,cCusName,cCusAddress,cCardNumber) values(@cGuid,@cWaveOrderNumber,@cOrderNumber,@cInvCode,@cInvName,@iQuantity,@cCusName,@cCusAddress,@cCardNumber)"
                };
                cmd.Parameters.AddWithValue("@cGuid", cGuid);
                cmd.Parameters.AddWithValue("@cWaveOrderNumber", cWaveOrderNumber);
                cmd.Parameters.AddWithValue("@cOrderNumber", ckNo);
                cmd.Parameters.AddWithValue("@cInvCode", dtBody.Rows[i]["erpNo"].ToString());
                cmd.Parameters.AddWithValue("@cInvName", dtBody.Rows[i]["pName"].ToString());
                cmd.Parameters.AddWithValue("@iQuantity", dtBody.Rows[i]["Num"].ToString());
                cmd.Parameters.AddWithValue("@cCusName", xname);
                cmd.Parameters.AddWithValue("@cCusAddress",addr);
                cmd.Parameters.AddWithValue("@cCardNumber", KH);
                wf.ExecSqlCmd(cmd);
            }
        }






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

        private void tsbtnTest_Click(object sender, EventArgs e)
        {
            //分析波次数据
            //GetWave(tstxtcGuid.Text);
            
            //取产品数据
            var cGuid = tstxtcGuid.Text;//取产品数据
            GetInventory(cGuid, sds.OrderListDetail);
            //获取订单数据
            var dtOrderNumber = GetOrderList(cGuid);

            sds.OrderListDetailSecond.Rows.Clear();

            pbMain.Maximum = sds.OrderListDetail.Rows.Count - 1;
            for (var i = 0; i < sds.OrderListDetail.Rows.Count; i++)
            {
                pbMain.Value = i;
                Application.DoEvents();
                var cInvCode = sds.OrderListDetail.Rows[i]["cInvCode"].ToString();
                var bFirst = true;
                for (var j = 0; j < dtOrderNumber.Rows.Count; j++)
                {
                    var cOrderNumber = dtOrderNumber.Rows[j]["cOrderNumber"].ToString();
                    var dtQuantity = GetInvAndQuantity(cInvCode, cOrderNumber, cGuid);
                    if (dtQuantity.Rows.Count > 0)
                    {

                        var dr = sds.OrderListDetailSecond.NewOrderListDetailSecondRow();

                        if (bFirst)
                        {
                            dr.cInvCode = sds.OrderListDetail.Rows[i]["cInvCode"].ToString();
                            dr.iQuantity = sds.OrderListDetail.Rows[i]["iQuantity"].ToString();
                            dr.cInvName = sds.OrderListDetail.Rows[i]["cInvName"].ToString();
                        }
                        bFirst = false; dr.cOrderNumber = cOrderNumber;

                        dr.iOrderQuantity = dtQuantity.Rows[0]["iQuantity"].ToString();
                        dr.cCusName = dtQuantity.Rows[0]["cCusName"].ToString();

                        dr.iBox = string.IsNullOrEmpty(dtQuantity.Rows[0]["iBox"].ToString())
                            ? ""
                            : dtQuantity.Rows[0]["iBox"].ToString();
                        dr.iTa = dtQuantity.Rows[0]["iTa"].ToString().Equals("0")
                            ? ""
                            : dtQuantity.Rows[0]["iTa"].ToString();

                        dr.iOdd = dtQuantity.Rows[0]["iOdd"].Equals("0") || string.IsNullOrEmpty(dtQuantity.Rows[0]["iOdd"].ToString())
                            ? ""
                            : dtQuantity.Rows[0]["iOdd"].ToString();
                        sds.OrderListDetailSecond.Rows.Add(dr);
                    }

                }
            }
            uGridOrderMain.DataSource = sds.OrderListDetailSecond;
            //var data = from a in sds.OrderListDetailSecond
            //               group a by new { a.cInvCode, a.cInvName } 
            //               into b
            //               select new {GroupId = b.Key.cInvCode,
            //                   Id = b.Key.cInvCode,
            //                   cSumBox = b.Sum(c => c.iBox),
            //                   cUnionBox = b.Sum(c => c.iOdd)
            //               };

            //uGridOrderMain.DataSource = sds.OrderListDetailSecond;

            //ugWave.DataSource = data;

            //分析波次数据
            GetUnionBox(cGuid);
        }

        private DataTable GetInvAndQuantity(string cInvCode, string cOrderNumber,string cGuid)
        {
            var sqlcmd = "GetSSRptOrderDetail";
            var cmd = new SqlCommand(sqlcmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cGuid", cGuid);
            cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
            cmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            var wf=new WmsFunction(BaseStructure.WmsCon);
            return wf.GetSqlTable(cmd);
        }


        private void GetInventory(string cGuid, DataTable dt)
        {
            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                using(var cmd=new SqlCommand("select cInvCode,Max(cInvName) cInvName,sum(iQuantity) iQuantity from Tmp_OrderList where cGuid=@cGuid group by cInvCode  order by cInvname"))
                {
                    cmd.Parameters.AddWithValue("@cGuid", cGuid);
                    cmd.Connection = con;
                    var da=new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
        }

        /// <summary>
        /// 波次数据分析
        /// </summary>
        /// <param name="cGuid"></param>
        //private void GetWave(string cGuid)
        //{
        //    using (var con = new SqlConnection(BaseStructure.WmsCon))
        //    {
        //        using (var cmd = new SqlCommand("GetWaveOrderDetail"))
        //        {
        //            cmd.CommandType=CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@cGuid", cGuid);
        //            cmd.Connection = con;
        //            var dt=new DataTable("dWave");
        //            var da = new SqlDataAdapter(cmd);
        //            da.Fill(dt);
        //            ugWave.DataSource = dt;
        //        }
        //    }
        //}


        private void GetUnionBox(string cGuid)
        {
            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                using (var cmd = new SqlCommand("GetUnionBox"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cGuid", cGuid);
                    cmd.Connection = con;
                    var dt = new DataTable("dWave");
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    ugWave.DataSource = dt;
                }
            }
        }
        private DataTable GetOrderList(string cGuid)
        {
            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                using (var cmd = new SqlCommand("select cOrderNumber from Tmp_OrderList where cGuid=@cGuid group by cOrderNumber"))
                {
                    cmd.Parameters.AddWithValue("@cGuid", cGuid);
                    cmd.Connection = con;
                    var da = new SqlDataAdapter(cmd);
                    var dt=new DataTable("cOrder");
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void TruncateTmpTable ()
        {
            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                using (var cmd = new SqlCommand("Truncate Table Tmp_OrderList"))
                {
                    
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void RptOrderList_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnPreview_Click(object sender, EventArgs e)
        {
            PrintDialog("preview", "SSReport", (DataTable)uGridOrderMain.DataSource);
        }


        /// <summary>
        /// 打印操作
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="cTemplet"></param>
        /// <param name="dSource"></param>
        public void PrintDialog(string operation,string cTemplet,DataTable dSource)
        {
            var xtreport = new XtraReport();
            // _btApp = new BarTender.Application();
            //判断当前打印模版路径是否存在
            var temPath = string.Format("{0}\\Stencil\\{1}.repx", Application.StartupPath, cTemplet);

            if (!File.Exists(temPath))
            {
                MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xtreport.ShowDesigner();
                return;
            }
            xtreport.LoadLayout(temPath);

            xtreport.RequestParameters = false;
            xtreport.ShowPrintStatusDialog = false;
            xtreport.ShowPrintMarginsWarning = false;
            xtreport.DataSource = dSource;
            

            //模板赋值
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
        //PrintDialog("design", "WaveReport", (DataTable)ugWave.DataSource);

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog("print", "SSReport", (DataTable)uGridOrderMain.DataSource);
        }

        private void tsbtnDesign_Click(object sender, EventArgs e)
        {
            PrintDialog("design", "SSReport", (DataTable)uGridOrderMain.DataSource);
        }

        private void tsbtnDesignWave_Click(object sender, EventArgs e)
        {
            PrintDialog("design", "WaveReport", (DataTable)ugWave.DataSource);
        }

        private void tsbtnPrintWave_Click(object sender, EventArgs e)
        {
            PrintDialog("print", "WaveReport", (DataTable)ugWave.DataSource);
        }

        private void tsbtnPreviewWave_Click(object sender, EventArgs e)
        {
            PrintDialog("preview", "WaveReport", (DataTable)ugWave.DataSource);
        }
    }
}
