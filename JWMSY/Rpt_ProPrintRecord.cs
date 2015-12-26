using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Docking2010.Views.MetroUI;
using JWMSY.DLL;

using System.Windows.Forms;

namespace JWMSY
{
    /// <summary>
    /// 产成品序列号标签记录表
    /// </summary>
    public partial class Rpt_ProPrintRecord : Form
    {

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cTempletFileName;

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cCaption;

        /// <summary>
        /// 打印机
        /// </summary>
        private string _cPrinter;
        /// <summary>
        /// 产成品序列号标签记录表构造函数
        /// </summary>
        public Rpt_ProPrintRecord()
        {
            InitializeComponent();
        }

        private void Rpt_ProPrintRecord_Load(object sender, EventArgs e)
        {
            pageListMain.Constr = BaseStructure.WmsCon;
            pageListMain.GetRecord();
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);

            DllWorkPrintLabel.GetTemplet("产成品标签", ref _cCaption, ref _cPrinter, ref _cTempletFileName);
            
        }

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uGridProBarCode.UpdateData();
            var dt = new DataUseTableFormat().Bar_ProSerialRecord;
            foreach (var uRow in uGridProBarCode.Rows.GetFilteredInNonGroupByRows())
            {
                if ((bool) uRow.Cells["bSelect"].Value)
                {
                    var dr = dt.NewBar_ProSerialRecordRow();
                    dr.cSerialNumber = uRow.Cells["cSerialNumber"].Value.ToString();
                    dr.cInvCode = uRow.Cells["cInvCode"].Value.ToString();
                    dr.cLotNo = uRow.Cells["cLotNo"].Value.ToString();
                    dt.Rows.Add(dr);
                }
            }

            DllWorkPrintLabel.ProPrintCodeSoft(dt, _cTempletFileName, _cPrinter);
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bfun = new WmsFunction(BaseStructure.WmsCon);
            var strTemp = bfun.GetWhereSqlStr("Bar_Product");
            if (string.IsNullOrEmpty(strTemp))
                return;
            pageListMain.Condition = " View_Bar_Product_SerialNumber where " + strTemp;
            pageListMain.WhereStr = strTemp;
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageListMain.WhereStr = "";
            pageListMain.Condition = "View_Bar_Product_SerialNumber";
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }
    }
}
