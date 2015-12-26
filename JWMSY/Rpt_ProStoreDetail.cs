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
    /// 产成品生产入库记录表
    /// </summary>
    public partial class Rpt_ProStoreDetail : Form
    {
        /// <summary>
        /// 产成品生产入库记录表构造函数
        /// </summary>
        public Rpt_ProStoreDetail()
        {
            InitializeComponent();
        }

        private void Rpt_ProStoreDetail_Load(object sender, EventArgs e)
        {
            pageChange.Constr = BaseStructure.WmsCon;
            pageChange.GetRecord();
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
            var strTemp = bfun.GetWhereSqlStr("Pro_StoreDetail");
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
