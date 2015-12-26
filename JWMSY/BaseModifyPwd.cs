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
    public partial class BaseModifyPwd : Form
    {
        public BaseModifyPwd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var sqlstr = "UpdatePwd";
            var con = new SqlConnection(BaseStructure.WmsCon);
            var cmd = new SqlCommand(sqlstr, con){CommandType=CommandType.StoredProcedure};
            cmd.Parameters.AddWithValue("@uName", utxtUser.Text);
            cmd.Parameters.AddWithValue("@uPassword", WmsFunction.GetMd5Hash(utxtPassword.Text));
            cmd.Parameters.AddWithValue("@uPwd", WmsFunction.GetMd5Hash(utxtPwd.Text));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"发生异常" + ex.Message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmd.ExecuteNonQuery() < 1)
            {
                MessageBox.Show(@"修改失败", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(@"修改成功", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }

        }
    }
}
