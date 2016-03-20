using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Helpers;

namespace JWMSY
{
    public partial class WorkSSDeliveryReturn : Form
    {
        public WorkSSDeliveryReturn()
        {
            InitializeComponent();
        }

        private void WorkSSDeliveryReturn_Load(object sender, EventArgs e)
        {
            sS_DeliveryReturnTableAdapter.Connection.ConnectionString = BaseStructure.WmsCon;GetReturnHistory();
            GetWareHouse();
        }

        private void GetReturnHistory()
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);

            var cmd =
                new SqlCommand(
                    "select top 100 cOrderNumber,cOrderNumber+'----'+cOperator as cDisplayText from Log_OrderNumber where cType='销售退货'");
            var dt = wf.GetSqlTable(cmd);
            if (dt == null)
                return;

            if (tscbxReturnHistory.ComboBox != null)
            {

                tscbxReturnHistory.ComboBox.DisplayMember = "cDisplayText";
                tscbxReturnHistory.ComboBox.ValueMember = "cOrderNumber";
                tscbxReturnHistory.ComboBox.DataSource = dt;
            }

        }



        private void GetWareHouse()
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);

            var cmd =
                new SqlCommand("select * from WareHouse");
            var dt = wf.GetSqlTable(cmd);
            if (dt == null)
                return;
            cbxWarehouse.DisplayMember = "cWhName";
            cbxWarehouse.ValueMember = "cWhCode";
            cbxWarehouse.DataSource = dt;
        }

        private void txtcBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            if (string.IsNullOrEmpty(txtcBarCode.Text.Trim()))
                return;
            if (string.IsNullOrEmpty(lblcOrderNumber.Text.Trim()))
            {
                MessageBox.Show(@"请先新增");
                return;
            }

            



            var cBarCode = txtcBarCode.Text;
            var dtOrder = JudgeBarcodeIsOrder(cBarCode);
            //判断是否是扫描了单据条码
            if (dtOrder!=null&&dtOrder.Rows.Count>0)
            {
                for (var i = 0; i < dtOrder.Rows.Count; i++)
                {
                    var nRow = dataProductMain.SS_DeliveryReturn.NewSS_DeliveryReturnRow();
                    nRow.cCusName = "";
                    nRow.cInvCode = dtOrder.Rows[i]["cInvCode"].ToString();
                    nRow.cInvName = dtOrder.Rows[i]["cInvName"].ToString();
                    nRow.cLotNo = dtOrder.Rows[i]["cLotNo"].ToString();
                    nRow.cMemo = "";
                    nRow.cOperator = BaseStructure.LoginName;
                    nRow.cOrgOrderNumber = cBarCode;
                    nRow.dAddTime = DateTime.Now;
                    nRow.iQuantity = int.Parse(dtOrder.Rows[i]["iQuantity"].ToString());
                    nRow.cOrderNumber = lblcOrderNumber.Text;

                    dataProductMain.SS_DeliveryReturn.Rows.Add(nRow);
                }

                return;
            }

            //此处取消扫描的商品码功能
            if (txtcBarCode.Text.Length == 13)
            {
                cBarCode = GetInventoryMapping(txtcBarCode.Text);
            }



            if (!cBarCode.StartsWith("I*") || !cBarCode.Contains("*C*") || !cBarCode.Contains("*L*"))
            {
                MessageBox.Show(@"无效条码", @"Error");
                txtcBarCode.Text = "";
                txtcBarCode.Focus();
                return;
            }
            //物料编码
            var cInvCode = cBarCode.Substring(2, cBarCode.IndexOf("*C*") - 2);
            //产品序列号
            var cSerialNumber = cBarCode.Substring(cBarCode.IndexOf("*C*") + 3, cBarCode.IndexOf("*L*") - cBarCode.IndexOf("*C*") - 3);

            if (!JudgeInvCode(cInvCode))
                return;

            //产品批号
            var cLotNo = cBarCode.Substring(cBarCode.IndexOf("*L*") + 3, cBarCode.Length - cBarCode.IndexOf("*L*") - 3);
            if (cSerialNumber.StartsWith("ZZ"))
            {
                //此处添加如果是周转箱扫描，则查询取得它的真实批号
                cLotNo = GetProductBoxLotNo(cSerialNumber);
            }
            else
            {
                cLotNo = GetProductLotNo(cSerialNumber);
            }

            txtcInvCode.Text = cInvCode;
            txtcLotNo.Text = cLotNo;
            txtcOrgOrderNumber.Text = cSerialNumber;
            uteiQuantity.Value = 1;

        }


        private DataTable JudgeBarcodeIsOrder(string cOrderNumber)
        {
            var wf=new WmsFunction(BaseStructure.WmsCon);
            var cmd = new SqlCommand("select * from SS_Detail where cOrderNumber=@cOrderNumber");
            cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
            return wf.GetSqlTable(cmd);
        }

        /// <summary>
        /// 根据扫描的周转箱序列号取得该的周转箱的批号
        /// </summary>
        /// <param name="cSerialNumber"></param>
        /// <returns></returns>
        private string GetProductBoxLotNo(string cSerialNumber)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var LotCmd = new SqlCommand("select cLotNo,cInvName from  View_Bar_Product_Box_SerialNumber where cSerialNumber=@cSerialNumber");
            LotCmd.Parameters.AddWithValue("@cSerialNumber", cSerialNumber);
            var dt = wf.GetSqlTable(LotCmd);
            if (dt == null || dt.Rows.Count < 1)
                return string.Empty;
            return dt.Rows[0]["cLotNo"].ToString();
        }
        
        /// <summary>
        /// 根据扫描的周转箱序列号取得该的周转箱的批号
        /// </summary>
        /// <param name="cSerialNumber"></param>
        /// <returns></returns>
        private string GetProductLotNo(string cSerialNumber)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var LotCmd = new SqlCommand("select cLotNo,cInvName from  View_Bar_Product_SerialNumber where cSerialNumber=@cSerialNumber");
            LotCmd.Parameters.AddWithValue("@cSerialNumber", cSerialNumber);
            var dt = wf.GetSqlTable(LotCmd);
            if (dt == null || dt.Rows.Count < 1)
                return string.Empty;
            
            return dt.Rows[0]["cLotNo"].ToString();
        }

        // <summary>
        /// 判断出库的产品是否包含在出库单中
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <returns></returns>
        private bool JudgeInvCode(string cInvCode)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bOutAllCmd = new SqlCommand("select cInvCode,cInvName from IT_Product where cInvCode=@cInvCode");
            bOutAllCmd.Parameters.AddWithValue("@cInvCode", cInvCode);
            var dt = wf.GetSqlTable(bOutAllCmd);
            if (dt == null || dt.Rows.Count < 1)
            {
                MessageBox.Show(@"非系统产品！");
                txtcBarCode.Text = "";
                txtcBarCode.Focus();
                return false;

            }
            txtcInvName.Text = dt.Rows[0]["cInvName"].ToString();
            
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
            var cmd = new SqlCommand("select  cVirtualBarCode,cInvName  from BInventoryMapping where cEBarCode=@cEBarCode");
            cmd.Parameters.AddWithValue("@cEBarCode", cBarCode);

            var dt = wf.GetSqlTable(cmd);
            if (dt == null || dt.Rows.Count < 1)
                return string.Empty;
            txtcInvName.Text = dt.Rows[0]["cInvName"].ToString();
            return dt.Rows[0]["cVirtualBarCode"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iQuantity;
            if (uteiQuantity.Value == null || !int.TryParse(uteiQuantity.Value.ToString(), out iQuantity))
            {
                MessageBox.Show("请输入正确的数量");

                return;
            }


            if (string.IsNullOrEmpty(txtcInvCode.Text))
            {
                MessageBox.Show(@"请先扫描条码");
                return;
            }

            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
            {
                MessageBox.Show(@"请先点击新增，新增一退货单号");
                return;
            }

            var nRow = dataProductMain.SS_DeliveryReturn.NewSS_DeliveryReturnRow();
            nRow.cCusName = txtcCusName.Text;
            nRow.cInvCode = txtcInvCode.Text;
            nRow.cInvName = txtcInvName.Text;
            nRow.cLotNo = txtcLotNo.Text;
            nRow.cMemo = txtcMemo.Text;
            nRow.cOperator = BaseStructure.LoginName;
            nRow.cOrgOrderNumber = txtcOrgOrderNumber.Text;
            nRow.dAddTime = DateTime.Now;
            nRow.iQuantity = iQuantity;
            nRow.cOrderNumber = lblcOrderNumber.Text;

            dataProductMain.SS_DeliveryReturn.Rows.Add(nRow);
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var lotCmd = new SqlCommand("GenerateOrderNumber") { CommandType = CommandType.StoredProcedure };
            lotCmd.Parameters.AddWithValue("@cPrelix", "YFTF");
            lotCmd.Parameters.AddWithValue("@cType", "销售退货");
            lotCmd.Parameters.AddWithValue("@cOperator", BaseStructure.LoginName);
            lblcOrderNumber.Text = wf.ReturnFirstSingle(lotCmd);
            dataProductMain.SS_DeliveryReturn.Rows.Clear();
            txtcBarCode.Enabled = true;
            txtcBarCode.Text = "";
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (dataProductMain.SS_DeliveryReturn.Rows.Count < 1)
                return;
            if (string.IsNullOrEmpty(lblcOrderNumber.Text))
                return;

            if (cbxWarehouse.Value==null||string.IsNullOrEmpty(cbxWarehouse.Value.ToString()))
            {
                MessageBox.Show(@"请先选择仓库！");
                return;
            }
            uGridSsDelivery.UpdateData();
            sS_DeliveryReturnTableAdapter.Update(dataProductMain.SS_DeliveryReturn);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var lotCmd = new SqlCommand("GenerateWmsEas") { CommandType = CommandType.StoredProcedure };
            lotCmd.Parameters.AddWithValue("@cOrderNumber", lblcOrderNumber.Text);
            lotCmd.Parameters.AddWithValue("@cType", "销售退货");
            lotCmd.Parameters.AddWithValue("@cGuid", cbxWarehouse.Value);
            if (wf.ExecSqlCmd(lotCmd))
            {
                MessageBox.Show(@"更新成功");
            }
            txtcBarCode.Enabled = false;

        }

        private void tscbxReturnHistory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcOrderNumber.Text.Trim()))
            {
                return;
            }
            lblcOrderNumber.Text = txtcOrderNumber.Text;
            sS_DeliveryReturnTableAdapter.Fill(dataProductMain.SS_DeliveryReturn, lblcOrderNumber.Text);
            if (dataProductMain.SS_DeliveryReturn.Rows.Count < 0)
            {
                lblcOrderNumber.Text = "";
            }
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
