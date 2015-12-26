using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using Infragistics.Win.UltraWinGrid;

namespace JWMSY
{
    /// <summary>
    /// 包材档案管理界面
    /// </summary>
    public partial class Base_PackMaterial : Form
    {


        /// <summary>
        /// 选择时， 设置选中的行
        /// </summary>
        public UltraGridRow URow;

        /// <summary>
        /// 判断是否是进行选择原料还是管理
        /// </summary>
        private readonly bool _bSelect;
        /// <summary>
        /// 包材档案管理界面构造函数
        /// </summary>
        public Base_PackMaterial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 包材档案管理界面构造函数
        /// </summary>
        public Base_PackMaterial(bool bSelect)
        {
            _bSelect = bSelect;
            InitializeComponent();
        }

        private void Base_RawMaterial_Load(object sender, EventArgs e)
        {

            GetRawMaterial(true);
            SetGridValueFormat();


            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
            uGridRawMaterial.DoubleClickCell -= uGridRawMaterial_DoubleClickCell;
            if (_bSelect)
            {
                Text = @"选择半成品档案";
                ribbon.Visible = false;
                uGridRawMaterial.DoubleClickCell += uGridRawMaterial_DoubleClickCell;
            }     
        }

        /// <summary>
        /// 设置表格内值的格式
        /// </summary>
        private void SetGridValueFormat()
        {
            uGridRawMaterial.DisplayLayout.ValueLists.Add("MassUnit");
            uGridRawMaterial.DisplayLayout.ValueLists["MassUnit"].ValueListItems.Add("天", "天");
            uGridRawMaterial.DisplayLayout.ValueLists["MassUnit"].ValueListItems.Add("月", "月");
            uGridRawMaterial.DisplayLayout.Bands[0].Columns["cMassUnit"].ValueList =
                uGridRawMaterial.DisplayLayout.ValueLists["MassUnit"];
        }

        /// <summary>
        /// 获取原料档案
        /// </summary>
        /// <param name="bTrue"></param>
        private void GetRawMaterial(bool bTrue)
        {
            iT_PackMaterialTableAdapter.Connection.ConnectionString = BaseStructure.WmsCon;
            iT_PackMaterialTableAdapter.Fill(dataInventory.IT_PackMaterial, bTrue);
        }

        private void biShowDisable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (biShowDisable.Caption.Equals("显示停用档案"))
            {
                GetRawMaterial(false);
                biDelete.Caption = @"启用";
                biShowDisable.Caption = @"显示在用档案";
            }
            else
            {
                GetRawMaterial(true);
                biDelete.Caption = @"停用";
                biShowDisable.Caption = @"显示停用档案";
            }
            
        }

        private void biEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            biSave.Enabled = true;
        }

        private void biSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataInventory.HasChanges())
            {
                uGridRawMaterial.UpdateData();
                iT_PackMaterialTableAdapter.Update(dataInventory.IT_PackMaterial);
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
            if (MessageBox.Show(@"确认停用当前项吗？", @"是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (uGridRawMaterial.ActiveRow == null || uGridRawMaterial.ActiveRow.Index <= -1) return;
            var bTrue = biDelete.Caption.Equals("停用");
            uGridRawMaterial.ActiveRow.Cells["bEnable"].Value = !bTrue;
            uGridRawMaterial.UpdateData();
            iT_PackMaterialTableAdapter.Update(dataInventory.IT_PackMaterial);
            GetRawMaterial(bTrue);
        }

        private void biAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bTrue = biDelete.Caption.Equals("停用");
            GetRawMaterial(bTrue);
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
    }
}
