﻿using System.IO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace JWMSY
{
   /// <summary>
   /// 打印EAS完工汇报单界面
   /// </summary>
    public partial class Work_EasSemiWorkOrder : Form
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
        /// 打印EAS完工汇报单界面构造函数
        /// </summary>
        public Work_EasSemiWorkOrder()
        {
            InitializeComponent();
        }

        private void Work_EasSemiWorkOrder_Load(object sender, EventArgs e)
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
           uGridCheck.DataSource = eo.GetWo();
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
            var temPath = Application.StartupPath + @"\Stencil\SemiWoOrder.repx";

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

        private void uGridCheck_DoubleClickCell(object sender, Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs e)
        {
            if (e.Cell.Row == null || e.Cell.Row.Index < 0)
                return;
            _cOrderNumber = e.Cell.Row.Cells["cOrderNumber"].Value.ToString();
            _iRowNo = e.Cell.Row.Index;
            var eo = new EasOrderService.EasOrder();
            eo.Url = BaseStructure.OrderServiceUri;
            var dtTemp = eo.GetWoDetail(_cOrderNumber);

            uGridChecks.DataSource = dtTemp;
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
                uGridCheck.DataSource = eo.GetWo2(seq.OrderNumber);
            }
        }

        private void BBIRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }
    }
}
