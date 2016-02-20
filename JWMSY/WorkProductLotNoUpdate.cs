using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JWMSY.DLL;

namespace JWMSY
{
    public partial class WorkProductLotNoUpdate : Form
    {
        public WorkProductLotNoUpdate()
        {
            InitializeComponent();
        }

        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            if (txtcInvCode.Value == null || string.IsNullOrEmpty(txtcInvCode.Value.ToString()))
            {
                MessageBox.Show(@"产品编码必输");
                return;
            }
            if (string.IsNullOrEmpty(tstxtStart.Text.Trim()))
            {
                if (cbxOnlyUnUpdate.Checked)
                {
                    pageChange.WhereStr = " cInvCode='" + txtcInvCode.Value + "' and ManualLotNo is null";
                }
                else
                {
                    pageChange.WhereStr = " cInvCode='" + txtcInvCode.Value + "' ";
                }
            }
            else
            {
                if (cbxOnlyUnUpdate.Checked)
                {
                    pageChange.WhereStr = " cInvCode='" + txtcInvCode.Value + "' and cSerialNumber>='" + tstxtStart.Text + "' and cSerialNumber<='" + tstxtEnd.Text + "' and ManualLotNo is null";
                }
                else
                {
                    pageChange.WhereStr = " cInvCode='" + txtcInvCode.Value + "' and cSerialNumber>='" + tstxtStart.Text + "' and cSerialNumber<='" + tstxtEnd.Text + "' ";
                }

            }
            
            pageChange.GetRecord();
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtcInvCode.Value == null || string.IsNullOrEmpty(txtcInvCode.Value.ToString()))
            {
                MessageBox.Show(@"产品编码必输");
                return;
            }
            if (!WmsFunction.IsNumAndEnCh(tstxtLotNo.Text))
            {
                MessageBox.Show(@"请输入正确的批次格式，只允许有数字与字母");
                return;
            }
            var cmd = new SqlCommand("update Bar_Product_SerialNumber set cLotNo='" + tstxtLotNo.Text + "' where cSerialNumber in " +
                                     "(select cSerialNumber from View_Bar_Product_SerialNumber where " + pageChange.WhereStr +")");

            var wf = new WmsFunction(BaseStructure.WmsCon);
            wf.ExecSqlCmd(cmd);
            pageChange.GetRecord();

            DllWmsMain.RecordLogAction(@"成品更新批号", BaseStructure.LoginName + " 更新了" + pageChange.WhereStr + "范围的批号"+tstxtLotNo.Text);
        }

        private void WorkProductLotNoUpdate_Load(object sender, EventArgs e)
        {
            GetRawMaterial();
            pageChange.Constr = BaseStructure.WmsCon;
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
            
        }



        private void GetRawMaterial()
        {
            iT_ProductTableAdapter.Connection.ConnectionString = BaseStructure.WmsCon;
            iT_ProductTableAdapter.Fill(dataInventory.IT_Product, true);
        }
    }
}
