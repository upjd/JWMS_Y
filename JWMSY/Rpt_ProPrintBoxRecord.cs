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

namespace JWMSY
{
    /// <summary>
    /// 产成品周转箱标签记录表
    /// </summary>
    public partial class Rpt_ProPrintBoxRecord : Form
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
        /// 产成品周转箱标签记录表
        /// </summary>
        public Rpt_ProPrintBoxRecord()
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

            DllWorkPrintLabel.GetTemplet("产成品周转箱标签", ref _cCaption, ref _cPrinter, ref _cTempletFileName);
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
            uGridProBoxBarCode.UpdateData();
            var dt = new DataUseTableFormat().Bar_ProBox;
            foreach (var uRow in uGridProBoxBarCode.Rows.GetFilteredInNonGroupByRows())
            {
                if ((bool)uRow.Cells["bSelect"].Value)
                {
                    var dr = dt.NewBar_ProBoxRow();
                    dr.cSerialNumber = uRow.Cells["cSerialNumber"].Value.ToString();
                    dr.cLotNo = uRow.Cells["cLotNo"].Value.ToString();
                    dr.iQuantity = uRow.Cells["iQuantity"].Value.ToString();
                    dr.dDate = uRow.Cells["dDate"].Value.ToString();
                    dr.cInvCode = uRow.Cells["cInvCode"].Value.ToString();
                    dr.cInvName = uRow.Cells["cInvName"].Value.ToString();
                    dr.cInvPackStd = uRow.Cells["cInvPackStd"].Value.ToString();
                    dr.cInvStd = uRow.Cells["cInvStd"].Value.ToString();
                    dr.cInvPackStyle = uRow.Cells["cInvPackStyle"].Value.ToString();
                    dr.cDefaultVendor = uRow.Cells["cDefaultVendor"].Value.ToString();
                    dr.cMassUnit = uRow.Cells["cMassUnit"].Value.ToString();
                    dr.iMassDate = uRow.Cells["iMassDate"].Value.ToString();
                    dr.cKeepRequire = uRow.Cells["cKeepRequire"].Value.ToString();
                    dr.cProperty = uRow.Cells["cProperty"].Value.ToString();
                    dr.cMemo = uRow.Cells["cMemo"].Value.ToString();
                    
                    
                    dt.Rows.Add(dr);
                }
            }

            DllWorkPrintLabel.ProBoxPrintCodeSoft(dt,1, _cTempletFileName, _cPrinter);
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bfun = new WmsFunction(BaseStructure.WmsCon);
            var strTemp = bfun.GetWhereSqlStr("Bar_Product_Box");
            if (string.IsNullOrEmpty(strTemp))
                return;
            pageListMain.Condition = " View_Bar_Product_Box_SerialNumber where " + strTemp;
            pageListMain.WhereStr = strTemp;
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageListMain.WhereStr = "";
            pageListMain.Condition = "View_Bar_Product_Box_SerialNumber";
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }
    }
}
