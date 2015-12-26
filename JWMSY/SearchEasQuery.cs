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
    /// Eas单据筛选
    /// </summary>
    public partial class SearchEasQuery : Form
    {
        /// <summary>
        /// 筛选的单据号
        /// </summary>
        public string OrderNumber;

        /// <summary>
        /// 筛选的品名
        /// </summary>
        public string InvName;


        /// <summary>
        /// 筛选的批次号
        /// </summary>
        public string LotNo;

        /// <summary>
        /// 筛选的单据号
        /// </summary>
        public string User;

        /// <summary>
        /// Eas单据筛选构造函数
        /// </summary>
        public SearchEasQuery()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcOrderNumber.Text.Trim())&&
                string.IsNullOrEmpty(txtcInvName.Text.Trim())&&
                string.IsNullOrEmpty(txtcLotNo.Text.Trim())&&
                string.IsNullOrEmpty(txtcUser.Text.Trim()))
            {
                MessageBox.Show(@"查询条件必填");
                return;
            }
            if (rbtncOrderNumber.Checked)
            {
                OrderNumber = txtcOrderNumber.Text;
            }

            if (rbcProName.Checked)
            {
                OrderNumber = txtcInvName.Text;
            }

            if (rbcLotNo.Checked)
            {
                OrderNumber = txtcLotNo.Text;
            }

            if (rbcUser.Checked)
            {
                OrderNumber = txtcUser.Text;
            }
            
            DialogResult = DialogResult.Yes;
        }

        private void txtcOrderNumber_TextChanged(object sender, EventArgs e)
        {
            rbtncOrderNumber.Checked = true;
        }

        private void txtcInvName_TextChanged(object sender, EventArgs e)
        {
            rbcProName.Checked = true;
        }

        private void rbcLotNo_CheckedChanged(object sender, EventArgs e)
        {
            //rbcLotNo.Checked = true;
        }

        private void rbcUser_CheckedChanged(object sender, EventArgs e)
        {
            //rbcUser.Checked = true;
        }

        private void txtcLotNo_TextChanged(object sender, EventArgs e)
        {
            rbcLotNo.Checked = true;
        }

        private void txtcUser_TextChanged(object sender, EventArgs e)
        {
            rbcUser.Checked = true;
        }
    }
}
