using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using Infragistics.Win.UltraWinGrid;

namespace JWMSY
{
    /// <summary>
    /// 标签档案管理界面
    /// </summary>
    public partial class Base_Templet : Form
    {
        /// <summary>
        /// 选择时， 设置选中的行
        /// </summary>
        public UltraGridRow URow;

        /// <summary>
        /// 判断是进行选择界面否
        /// </summary>
        private bool _bSelect;

        private string _cFunctionFilter;

        /// <summary>
        /// 标签档案管理界面构造函数
        /// </summary>
        public Base_Templet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 标签档案管理界面构造函数
        /// </summary>
        public Base_Templet(bool bSelect,string cFunctionFilter)
        {

            InitializeComponent();
            _bSelect = bSelect;
            _cFunctionFilter = cFunctionFilter;
        }

        private void Base_RawMaterial_Load(object sender, EventArgs e)
        {
           
            GetBaseTemplet();
            SetGridValueFormat();


            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);

            if (_bSelect)
            {
                Text = _cFunctionFilter+@"打印模版档案";
                ribbon.Visible = false;
                uGridRawMaterial.DisplayLayout.Bands[0].ColumnFilters["cFunction"].FilterConditions.Add(
                    FilterComparisionOperator.Contains, _cFunctionFilter);

                uGridRawMaterial.DoubleClickCell += uGridRawMaterial_DoubleClickCell;
            }


            uGridRawMaterial.DisplayLayout.ValueLists.Add("Printer");
            //获取当前所有打印机
            for (var i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                uGridRawMaterial.DisplayLayout.ValueLists["Printer"].ValueListItems.Add(PrinterSettings.InstalledPrinters[i], PrinterSettings.InstalledPrinters[i]);
            }
            uGridRawMaterial.DisplayLayout.Bands[0].Columns["cPrinter"].ValueList =
               uGridRawMaterial.DisplayLayout.ValueLists["Printer"];

        }

        /// <summary>
        /// 设置表格内值的格式
        /// </summary>
        private void SetGridValueFormat()
        {
            uGridRawMaterial.DisplayLayout.ValueLists.Add("Function");
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("原料标签", "原料标签");
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("包材标签", "包材标签");
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("半成品标签", "半成品标签");
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("产成品标签", "产成品标签");
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("产成品周转箱标签", "产成品周转箱标签");
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("物流箱标签", "物流箱标签");
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("件数标签", "件数标签");//礼包标签
            uGridRawMaterial.DisplayLayout.ValueLists["Function"].ValueListItems.Add("礼包标签", "礼包标签");//礼包标签
            uGridRawMaterial.DisplayLayout.Bands[0].Columns["cFunction"].ValueList =
                uGridRawMaterial.DisplayLayout.ValueLists["Function"];
        }

        /// <summary>
        /// 获取原料档案
        /// </summary>
        /// <param name="bTrue"></param>
        private void GetBaseTemplet()
        {
            bTempletListTableAdapter.Connection.ConnectionString = BaseStructure.WmsCon;
            bTempletListTableAdapter.Fill(dataBaseControl.BTempletList);
        }

        

        private void biEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            biSave.Enabled = true;
            uGridRawMaterial.DisplayLayout.Override.AllowAddNew =
                AllowAddNew.TemplateOnBottom;
        }

        private void biSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataBaseControl.HasChanges())
            {
                uGridRawMaterial.UpdateData();
                bTempletListTableAdapter.Update(dataBaseControl.BTempletList);
                MessageBox.Show(@"修改成功");
            }
            else
            {
                MessageBox.Show(@"无任何修改");
            }
        }

        private void biDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (biSave.Enabled)
            {

                MessageBox.Show(@"请保存当前修改后，再进行停用操作");
                return;

            }
            if (MessageBox.Show(@"确认删除当前项吗？", @"是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (uGridRawMaterial.ActiveRow == null || uGridRawMaterial.ActiveRow.Index <= -1) return;
            uGridRawMaterial.ActiveRow.Delete(false);
            uGridRawMaterial.UpdateData();
            bTempletListTableAdapter.Update(dataBaseControl.BTempletList);
            GetBaseTemplet();
        }

       

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void uGridRawMaterial_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            if (e.Cell.Row == null || e.Cell.Row.Index <= -1) return;
            URow = e.Cell.Row;
            DialogResult = DialogResult.Yes;
        }

        private void uGridRawMaterial_ClickCellButton(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key.Equals("cTempletPath"))
            {
                if(ofdMain.ShowDialog()!=DialogResult.OK) return;
                if (string.IsNullOrEmpty(ofdMain.FileName))
                {
                    MessageBox.Show(@"未选择正确文件!", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    e.Cell.Value = ofdMain.SafeFileName;
                }
            }
        }
    }
}
