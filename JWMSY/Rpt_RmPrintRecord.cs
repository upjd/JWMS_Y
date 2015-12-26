using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace JWMSY
{
    /// <summary>
    /// 原料标签记录表
    /// </summary>
    public partial class Rpt_RmPrintRecord : Form
    {
        /// <summary>
        /// 原料标签记录表
        /// </summary>
        public Rpt_RmPrintRecord()
        {
            InitializeComponent();
        }

        private void Rpt_RmPrintRecord_Load(object sender, EventArgs e)
        {
            pageChange.Constr = BaseStructure.WmsCon;
            pageChange.GetRecord();
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fname"></param>
        /// <returns></returns>
        private Form FormIsExist(string fname)
        {
            return ParentForm == null ? null : ParentForm.MdiChildren.FirstOrDefault(cform => cform.Name.Equals(fname));
        }

        private void uGridRawMaterial_DoubleClickCell(object sender, Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs e)
        {
            if (e.Cell.Row.Index < 0)
                return;
            if (e.Cell.Row.Cells["AutoID"].Value == null)
                return;
            var lid = e.Cell.Row.Cells["AutoID"].Value.ToString();
            if (string.IsNullOrEmpty(lid))
                return;
            var bdoForm = (WorkRmPrintLabel)FormIsExist("WorkRmPrintLabel");
            if (bdoForm == null)
            {
                var wrp = new WorkRmPrintLabel(lid) { MdiParent = ParentForm };
                wrp.Show();
                return;
            }
            bdoForm.Activate();
            bdoForm.SetPanelVlaue(lid);
            
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bfun = new WmsFunction(BaseStructure.WmsCon);
            var strTemp = bfun.GetWhereSqlStr("Rm_StoreDetail");
            if (string.IsNullOrEmpty(strTemp))
                return;
            pageChange.WhereStr = strTemp;
            pageChange.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageChange.WhereStr = "";
            pageChange.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }
    }
}
