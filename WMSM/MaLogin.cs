using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UDLB;

namespace WMSM
{
    public partial class MaLogin : Form
    {
        public static string WmsCon ;


        public static string WmsServiceUri;

        public static DateTime LoginDate;


        public static string WmsServer;

        public MaLogin()
        {
            InitializeComponent();
        }

        private void MaLogin_Load(object sender, EventArgs e)
        {
            utxtServer.Text = Properties.Settings.Default.cServer;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            OkLogin();
        }
        /// <summary>
        /// 验证登录
        /// </summary>
        private void OkLogin()
        {
            try
            {
                var ws = new WmsService.BaseConService { Url = "http://" + utxtServer.Text + "/BaseConService.asmx" };
                WmsCon = ws.GetWmsConstring();
                WmsServiceUri = ws.Url;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"服务器填写错误，或者服务器端未配置正确！
" + ex.Message, @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            lblLogin.Image = Properties.Resources.LoginForm_login_btn_click;

            if (string.IsNullOrEmpty(utxtUser.Text.Trim()) || string.IsNullOrEmpty(utxtPassword.Text))
            {
                MessageBox.Show(@"用户名和密码必填！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //记住账套信息
            if (utxtAccount.Value == null || WmsCon == null)
            {
                MessageBox.Show(@"服务器选择有误！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var strpwd = WmsFunction.GetMd5Hash(utxtPassword.Text);
            var cmd = new SqlCommand("select * from BUser where uCode='admin' and uPassword=@uPassword");
            cmd.Parameters.AddWithValue("@uPassword", strpwd);
            var wf = new WmsFunction(WmsCon);
            if (!wf.BoolExistTable(cmd))
            {
                MessageBox.Show(@"admin密码不正确！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hide();
            var mm = new MaMain();
            mm.ShowDialog();

            LoginDate = udDate.DateTime.Date;
            WmsServer = utxtServer.Text;
            Properties.Settings.Default.cServer = utxtServer.Text;
            Properties.Settings.Default.Save();
        }
    }
}
