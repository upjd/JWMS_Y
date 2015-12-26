using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JWMSY
{
    /// <summary>
    /// 换箱界面
    /// </summary>
    public partial class WorkSSReplaceBox : Form
    {

        private string _cOrderNumber;

        /// <summary>
        /// 换箱构造函数
        /// </summary>
        public WorkSSReplaceBox(string cOrgBoxNumber, string cOrderNumber)
        {
            InitializeComponent();
            txtcOrgBoxNumber.Text = cOrgBoxNumber;
            _cOrderNumber = cOrderNumber;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var PlusCmd = new SqlCommand("update SS_Detail set cBoxNumber=@cBoxNumber where cOrderNumber=@cOrderNumber and cBoxNumber=@cOldBoxNumber ");
            PlusCmd.Parameters.AddWithValue("@cOrderNumber", _cOrderNumber);
            PlusCmd.Parameters.AddWithValue("@cBoxNumber", txtcNewBoxNumber.Text);
            PlusCmd.Parameters.AddWithValue("@cOldBoxNumber", txtcOrgBoxNumber.Text);


            wf.ExecSqlCmd(PlusCmd);
            DialogResult = DialogResult.OK;
        }

        private void txtcOrgBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            var cBarCode = txtcOrgBoxNumber.Text;
            if (!cBarCode.Contains("BX"))
            {
                MessageBox.Show(@"请扫描原箱号", "Error");
                txtcOrgBoxNumber.Text = "";
                txtcOrgBoxNumber.Focus();
                return;
            }
            var indexBox = cBarCode.IndexOf("boxnumber=");
            var lengthBox = cBarCode.Length;
            if (indexBox < 1)
            {
                MessageBox.Show(@"请扫描原箱号", "Error");
                txtcOrgBoxNumber.Text = "";
                txtcOrgBoxNumber.Focus();
                return;
            }
            txtcOrgBoxNumber.Text = cBarCode.Substring(indexBox + 10, lengthBox - indexBox - 10);
            
        }

        private void txtcNewBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            var cBarCode = txtcNewBoxNumber.Text;
            if (!cBarCode.Contains("BX"))
            {
                MessageBox.Show(@"请扫描原箱号", "Error");
                txtcOrgBoxNumber.Text = "";
                txtcOrgBoxNumber.Focus();
                return;
            }
            var indexBox = cBarCode.IndexOf("boxnumber=");
            var lengthBox = cBarCode.Length;
            if (indexBox < 1)
            {
                MessageBox.Show(@"请扫描原箱号", "Error");
                txtcOrgBoxNumber.Text = "";
                txtcOrgBoxNumber.Focus();
                return;
            }
            txtcNewBoxNumber.Text = cBarCode.Substring(indexBox + 10, lengthBox - indexBox - 10);
            
        }
    }
}
