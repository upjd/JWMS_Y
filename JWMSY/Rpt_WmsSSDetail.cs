using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.MetroUI;

namespace JWMSY
{

    /// <summary>
    /// 二次拣货记录表
    /// </summary>
    public partial class Rpt_WmsSSDetail : Form
    {
        /// <summary>
        /// 二次拣货记录表构造函数
        /// </summary>
        public Rpt_WmsSSDetail()
        {
            InitializeComponent();
        }

        private void Rpt_ProSSDetail_Load(object sender, EventArgs e)
        {
            pageListMain.Constr = BaseStructure.WmsCon;
            pageListMain.GetRecord();
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);

            
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
            var strTemp = bfun.GetWhereSqlStr("WMSSS_Detail");
            if (string.IsNullOrEmpty(strTemp))
                return;
            pageListMain.Condition = "View_WmsSSDetail where " + strTemp;
            pageListMain.WhereStr = strTemp;
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageListMain.WhereStr = "";
            pageListMain.Condition = "View_WmsSSDetail";
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }
    }
}
