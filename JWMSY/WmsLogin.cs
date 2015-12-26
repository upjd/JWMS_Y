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
    public partial class WmsLogin : Form
    {
        public WmsLogin()
        {
            InitializeComponent();
        }

        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
            lblLogin.Image = Properties.Resources.LoginForm_login_btn_hover;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.Image = Properties.Resources.LoginForm_login_btn;
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
                var ws = new WmsService.BaseConService {Url = "http://" + utxtServer.Text + "/BaseConService.asmx"};

                BaseStructure.WmsServer = utxtServer.Text;
                BaseStructure.WmsCon = ws.GetWmsConstring();
                BaseStructure.WmsServiceUri = ws.Url;
                BaseStructure.OrderServiceUri = string.Format(@"http://{0}/EasOrder.asmx", utxtServer.Text);
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
            if (utxtAccount.Value == null || BaseStructure.WmsCon == null)
            {
                MessageBox.Show(@"账套、服务器选择有误！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!BaseClass.OkLogin(utxtUser.Text, utxtPassword.Text))
            {
                return;
            }
            BaseClass.LonlineID = Guid.NewGuid().ToString();
            var bc = new BaseClass();
            if (!bc.CheckOnlineNumber()) return;
            Hide();
            var wmsMain = new WmsRibbonMain();
            wmsMain.Show();
            
            BaseStructure.LoginDate = udDate.DateTime.Date;
            BaseStructure.WmsServer = utxtServer.Text;
            Properties.Settings.Default.cUser = utxtUser.Text;
            Properties.Settings.Default.cServer = utxtServer.Text;
            Properties.Settings.Default.Save();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"确定退出吗？", @"是否确定？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes)
                return;
            Application.Exit();
        }

        private void WmsLogin_Load(object sender, EventArgs e)
        {
            

            utxtServer.Text = Properties.Settings.Default.cServer;
            utxtUser.Text = Properties.Settings.Default.cUser;
        }

        private void utxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            OkLogin();
        }

        private void utxtPassword_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                var ws = new WmsService.BaseConService { Url = "http://" + utxtServer.Text + "/BaseConService.asmx" };

                BaseStructure.WmsServer = utxtServer.Text;
                BaseStructure.WmsCon = ws.GetWmsConstring();
                BaseStructure.WmsServiceUri = ws.Url;
                BaseStructure.OrderServiceUri = string.Format(@"http://{0}/EasOrder.asmx", utxtServer.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"服务器填写错误，或者服务器端未配置正确！
" + ex.Message, @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bmp = new BaseModifyPwd();
            bmp.ShowDialog();
        }
    }
}
