using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace JWMSY
{
    /// <summary>
    /// 产成品销售出国单
    /// </summary>
    public partial class Work_EasProSaleOrder : Form
    {
        /// <summary>
        /// 完工单号
        /// </summary>
        private string _cOrderNumber;

        /// <summary>
        /// 行号
        /// </summary>
        private int _iRowNo;
        /// <summary>
        /// 产成品销售出库单构造函数
        /// </summary>
        public Work_EasProSaleOrder()
        {
            InitializeComponent();
        }

        private void Work_EasProWorkOrder_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var eo = new EasOrderService.EasOrder();
            eo.Url = BaseStructure.OrderServiceUri;
            uGridCheck.DataSource = eo.GetSale();
        }


        /// <summary>
        /// 打印操作
        /// </summary>
        /// <param name="operation"></param>
        public void PrintDialog(string operation)
        {
            var xtreport = new XtraReport();
            // _btApp = new BarTender.Application();
            //判断当前打印模版路径是否存在
            var temPath = Application.StartupPath + @"\Stencil\ProSaleOrder.repx";

            if (!File.Exists(temPath))
            {
                MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xtreport.Name = "ProSaleOrder";
                xtreport.ShowDesigner();
                return;
            }
            xtreport.LoadLayout(temPath);

            xtreport.RequestParameters = false;
            xtreport.ShowPrintStatusDialog = false;
            xtreport.ShowPrintMarginsWarning = false;
            var dt =(DataTable) uGridChecks.DataSource;
            xtreport.DataSource = dt;
            var iSum = dt.Compute("sum(FAMOUNT)", "True");
            decimal dSum;
            if (decimal.TryParse(iSum.ToString(), out dSum))
            {
                DLL.DllWorkPrintLabel.SetParametersValue(xtreport, "cSum", WmsFunction.ExchangeUper(dSum));
            }
            DLL.DllWorkPrintLabel.SetParametersValue(xtreport, "iSum", iSum);
            
            //模板赋值
            for (var i = 0; i < uGridCheck.DisplayLayout.Bands[0].Columns.Count; i++)
            {
                var cKey = uGridCheck.DisplayLayout.Bands[0].Columns[i].Key;
                string cValue;
                if (uGridCheck.ActiveRow != null)
                {
                    cValue = uGridCheck.ActiveRow.Cells[i].Value.ToString();
                }
                else
                {
                    cValue = "";
                }
                DLL.DllWorkPrintLabel.SetParametersValue(xtreport, cKey, cValue);
            }
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

        private void biDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintDialog("design");
        }

        private void biPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintDialog("preview");
        }

        private void biPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintDialog("print");
        }

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void uGridCheck_DoubleClickCell(object sender, Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs e)
        {
            if (e.Cell.Row == null || e.Cell.Row.Index < 0)
                return;
            _cOrderNumber = e.Cell.Row.Cells["cOrderNumber"].Value.ToString();
            _iRowNo = e.Cell.Row.Index;
            var eo = new EasOrderService.EasOrder();
            eo.Url = BaseStructure.OrderServiceUri;
            var dtTemp = eo.GetSaleDetail(_cOrderNumber);
            uGridChecks.DataSource = dtTemp;
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var seq = new SearchEasQuery())
            {
                if (seq.ShowDialog() != DialogResult.Yes) return;
                var eo = new EasOrderService.EasOrder { Url = BaseStructure.OrderServiceUri };


                uGridCheck.DataSource = eo.GetSale2(seq.OrderNumber);
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }
    }
}
