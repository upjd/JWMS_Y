using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using JWMSY.DLL;
using System.Data.SqlClient;


namespace JWMSY
{
    /// <summary>
    /// WMS与EAS销售出库对照表
    /// </summary>
    public partial class Rpt_WmsAndEasCompareSaleDeliveryOrder : Form
    {
        /// <summary>
        /// WMS与EAS销售出库对照表
        /// </summary>
        public Rpt_WmsAndEasCompareSaleDeliveryOrder()
        {
            InitializeComponent();
        }

        private void Rpt_ProPrintRecord_Load(object sender, EventArgs e)
        {
            
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
            txtOrderPrefix.EditValue = "NBCK";
            
        }

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (beidDate.EditValue == null)
            {
                beidDate.EditValue = DateTime.Now.Date;
            }
            if (beiEndDate.EditValue == null)
            {
                beiEndDate.EditValue = DateTime.Now.Date;
            }
            var cdDate = beidDate.EditValue.ToString();
            var cdEndDate = beiEndDate.EditValue.ToString();
            var orderPrefix = txtOrderPrefix.EditValue.ToString();
            DateTime dDate;
            DateTime dEndDate;

            if (!DateTime.TryParse(cdDate, out dDate))
            {
                dDate = DateTime.Now.Date.AddDays(-10);
            }
            if (!DateTime.TryParse(cdEndDate, out dEndDate))
            {
                dEndDate = DateTime.Now.Date.AddDays(10);
            }
            //通过WebService获取报单系统数据
            var js = new CompareService.EasAndWmsCompareReport();

            //var easData = js.GetSaleOrder(dDate, dEndDate);
            var easData = js.GetSaleOrder(dDate, dEndDate, orderPrefix);

            var wf = new WmsFunction(BaseStructure.WmsCon);
            var cGuid = Guid.NewGuid();
            //写临时表
            for (var i = 0; i < easData.Rows.Count; i++)
            {
                var cmdInsertTemp = new SqlCommand("insert into Tmp_Compare(cOrderNumber,cGuid) " +
                                    "Values(@cOrderNumber,@cGuid)");
                cmdInsertTemp.Parameters.AddWithValue("@cOrderNumber", easData.Rows[i]["cOrderNumber"].ToString());
                cmdInsertTemp.Parameters.AddWithValue("@cGuid", cGuid);
                wf.ExecSqlCmd(cmdInsertTemp);
            }

            var cmd = new SqlCommand("CompareSaleDeliveryOrder") { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@dDate", dDate);
            cmd.Parameters.AddWithValue("@dEndDate", dEndDate);
            cmd.Parameters.AddWithValue("@cGuid", cGuid);
            cmd.Parameters.AddWithValue("@cOrderPrefix", orderPrefix);
            cmd.Parameters.AddWithValue("@isDifference", chkDifference.Checked ? 1 : 0);
            
            uGridProBoxBarCode.DataSource=wf.GetSqlTable(cmd);

            //var cmdDelete = new SqlCommand("Delete from Tmp_Compare where cGuid=@cGuid");
            //cmdDelete.Parameters.AddWithValue("@cGuid", cGuid);
            //wf.ExecSqlCmd(cmdDelete);
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

    }
}
