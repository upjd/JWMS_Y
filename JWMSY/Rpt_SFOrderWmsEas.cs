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

namespace JWMSY
{
    public partial class Rpt_SFOrderWmsEas : Form
    {
        public Rpt_SFOrderWmsEas()
        {
            InitializeComponent();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bfun = new WmsFunction(BaseStructure.WmsCon);
            var strTemp = bfun.GetWhereSqlStr("View_SFOrderAndWmsEAS");
            if (string.IsNullOrEmpty(strTemp))
                return;
            pageListMain.Condition = " View_SFOrderAndWmsEAS where " + strTemp;
            pageListMain.WhereStr = strTemp;
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageListMain.WhereStr = "";
            pageListMain.Condition = "View_SFOrderAndWmsEAS";
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }

        private void Rpt_SFOrderWmsEas_Load(object sender, EventArgs e)
        {
            pageListMain.Constr = BaseStructure.WmsCon;
            pageListMain.GetRecord();
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

        private void uGridProBoxBarCode_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Row.Index < 0)
                return;

            var cOrderNumber = e.Cell.Row.Cells["cOrderNumber"].Value.ToString();
            var cState = e.Cell.Row.Cells["cState"].Value.ToString();
            if (!cState.Equals("完成"))
            {
                MessageBox.Show(@"订单必需是完成状态，才允许操作");
                return;
            }
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var lotCmd = new SqlCommand("GenerateWmsEas") { CommandType = CommandType.StoredProcedure };
            lotCmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
            lotCmd.Parameters.AddWithValue("@cType", "销售出库");
            lotCmd.Parameters.AddWithValue("@cGuid", Guid.NewGuid());
            lotCmd.Parameters.AddWithValue("@bReUpdate", 1);
            if (wf.ExecSqlCmd(lotCmd))
            {
                MessageBox.Show(@"写入中间表成功");
            }
            pageListMain.Constr = BaseStructure.WmsCon;
            pageListMain.GetRecord();
        }
    }
}
