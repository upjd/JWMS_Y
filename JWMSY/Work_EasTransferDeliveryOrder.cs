﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.IO;

namespace JWMSY
{
    /// <summary>
    /// EAS原料调拨单
    /// </summary>
    public partial class Work_EasTransferDeliveryOrder : Form
    {
        /// <summary>
        /// 调拨单号
        /// </summary>
        private string _cOrderNumber;

        /// <summary>
        /// 当前选择行号
        /// </summary>
        private int _iRowNo;
        /// <summary>
        /// Eas原料调拨单构造函数
        /// </summary>
        public Work_EasTransferDeliveryOrder()
        {
            InitializeComponent();
        }

        private void Work_EasRmTransferOrder_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        private void RefreshData()
        {
            var eo = new EasOrderService.EasOrder();
            eo.Url = BaseStructure.OrderServiceUri;
            uGridCheck.DataSource = eo.GetTransferDelivery();
        }

        private void uGridCheck_DoubleClickCell(object sender, Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs e)
        {
            if (e.Cell.Row == null || e.Cell.Row.Index < 0)
                return;
            _cOrderNumber = e.Cell.Row.Cells["cOrderNumber"].Value.ToString();
            _iRowNo = e.Cell.Row.Index;
            var eo = new EasOrderService.EasOrder();
            eo.Url = BaseStructure.OrderServiceUri;
            uGridChecks.DataSource = eo.GetTransferDeliveryDetail(_cOrderNumber);
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
            var temPath = Application.StartupPath + @"\Stencil\RmTransferDeliveryOrder.repx";

            if (!File.Exists(temPath))
            {
                MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xtreport.ShowDesigner();
                return;
            }
            xtreport.LoadLayout(temPath);

            xtreport.RequestParameters = false;
            xtreport.ShowPrintStatusDialog = false;
            xtreport.ShowPrintMarginsWarning = false;
            xtreport.DataSource = uGridChecks.DataSource;
            //模板赋值
            string cKey, cValue;
            for (var i = 0; i < uGridCheck.DisplayLayout.Bands[0].Columns.Count; i++)
            {
                cKey = uGridCheck.DisplayLayout.Bands[0].Columns[i].Key;
                cValue = uGridCheck.Rows[_iRowNo].Cells[i].Value.ToString();
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

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var seq = new SearchEasQuery())
            {
                if (seq.ShowDialog() != DialogResult.Yes) return;
                var eo = new EasOrderService.EasOrder { Url = BaseStructure.OrderServiceUri };
                uGridCheck.DataSource = eo.GetTransferDelivery2(seq.OrderNumber);
            }
        }

        private void BBirefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }
    }
}
