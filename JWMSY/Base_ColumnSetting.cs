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

namespace JWMSY
{
    /// <summary>
    /// 表格样式维护
    /// </summary>
    public partial class Base_ColumnSetting : Form
    {
        /// <summary>
        /// 表格样式维护界面构造函数
        /// </summary>
        public Base_ColumnSetting()
        {
            InitializeComponent();
        }

        private void Base_RawMaterial_Load(object sender, EventArgs e)
        {
            GetDepart();
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

        private void biEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetControlEnable();
        }


        /// <summary>
        /// 禁用所有输入框和保存按钮
        /// </summary>
        private void SetControlDisable()
        {
            biSave.Enabled = false;//在不可编辑下保存按钮不可用
            biGiveup.Enabled = false;//在不可编辑下取消按钮不可用
            biEdit.Enabled = true;//在不可编辑下修改按钮可用
            biDelete.Enabled = true;

        }


        /// <summary>
        /// 启用所有新增和更新控件时使用的输入和保存按钮
        /// </summary>
        private void SetControlEnable()
        {
            biSave.Enabled = true;//在可编辑下保存按钮可用
            biGiveup.Enabled = true;//在可编辑下取消按钮可用

            biEdit.Enabled = false;//在可编辑下修改按钮不可用
            biDelete.Enabled = false;
        }

        private void GetDepart()
        {
            columnSetingTableAdapter.Connection.ConnectionString = BaseStructure.WmsCon;
            columnSetingTableAdapter.Fill(dataInventory.ColumnSeting);
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dataInventory.HasChanges())
            {
                MessageBox.Show(@"无任何修改");
                return;

            }
            uGridRawMaterial.UpdateData();
            columnSetingTableAdapter.Update(dataInventory.ColumnSeting);
            MessageBox.Show(@"保存成功");
            SetControlDisable();
        }

        private void biDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(@"确认删除吗？", @"是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (uGridRawMaterial.ActiveRow != null && uGridRawMaterial.ActiveRow.Index > -1)
            {
                uGridRawMaterial.ActiveRow.Delete(false);
            }
        }

        private void biGiveup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(@"确认放弃此次修改？", @"是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            GetDepart();
            SetControlDisable();
        }

       
    }
}
