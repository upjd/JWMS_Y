namespace JWMSY
{
    partial class WmsLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton2 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton3 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton4 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton5 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton6 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WmsLogin));
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            this.uPanelMain = new Infragistics.Win.Misc.UltraPanel();
            this.utxtAccount = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.udDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.utxtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtUser = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtServer = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraFormattedLinkLabel1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.uPanelMain.ClientArea.SuspendLayout();
            this.uPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utxtAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtServer)).BeginInit();
            this.SuspendLayout();
            // 
            // uPanelMain
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BorderColor = System.Drawing.Color.Silver;
            this.uPanelMain.Appearance = appearance1;
            this.uPanelMain.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4;
            // 
            // uPanelMain.ClientArea
            // 
            this.uPanelMain.ClientArea.Controls.Add(this.utxtAccount);
            this.uPanelMain.ClientArea.Controls.Add(this.udDate);
            this.uPanelMain.ClientArea.Controls.Add(this.utxtPassword);
            this.uPanelMain.ClientArea.Controls.Add(this.utxtUser);
            this.uPanelMain.ClientArea.Controls.Add(this.utxtServer);
            this.uPanelMain.Location = new System.Drawing.Point(75, 128);
            this.uPanelMain.Name = "uPanelMain";
            this.uPanelMain.Size = new System.Drawing.Size(350, 196);
            this.uPanelMain.TabIndex = 1;
            // 
            // utxtAccount
            // 
            appearance2.BackColor = System.Drawing.Color.White;
            this.utxtAccount.Appearance = appearance2;
            this.utxtAccount.AutoSize = false;
            this.utxtAccount.BackColor = System.Drawing.Color.White;
            appearance3.Image = global::JWMSY.Properties.Resources.LoginForm_defalt;
            editorButton1.Appearance = appearance3;
            this.utxtAccount.ButtonsLeft.Add(editorButton1);
            this.utxtAccount.Location = new System.Drawing.Point(16, 116);
            this.utxtAccount.Name = "utxtAccount";
            this.utxtAccount.Size = new System.Drawing.Size(315, 29);
            this.utxtAccount.TabIndex = 6;
            this.utxtAccount.Text = "三生中国";
            // 
            // udDate
            // 
            this.udDate.AutoSize = false;
            appearance4.Image = global::JWMSY.Properties.Resources.LoginForm_time;
            editorButton2.Appearance = appearance4;
            this.udDate.ButtonsLeft.Add(editorButton2);
            this.udDate.Location = new System.Drawing.Point(16, 150);
            this.udDate.Name = "udDate";
            this.udDate.Size = new System.Drawing.Size(315, 29);
            this.udDate.TabIndex = 5;
            // 
            // utxtPassword
            // 
            this.utxtPassword.AutoSize = false;
            appearance5.Image = global::JWMSY.Properties.Resources.LoginForm_password;
            editorButton3.Appearance = appearance5;
            this.utxtPassword.ButtonsLeft.Add(editorButton3);
            editorButton4.Text = "修改密码";
            editorButton4.Width = 70;
            this.utxtPassword.ButtonsRight.Add(editorButton4);
            this.utxtPassword.Location = new System.Drawing.Point(16, 82);
            this.utxtPassword.Name = "utxtPassword";
            this.utxtPassword.PasswordChar = '*';
            this.utxtPassword.Size = new System.Drawing.Size(315, 29);
            this.utxtPassword.TabIndex = 0;
            this.utxtPassword.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.utxtPassword_EditorButtonClick);
            this.utxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.utxtPassword_KeyDown);
            // 
            // utxtUser
            // 
            this.utxtUser.AutoSize = false;
            appearance6.Image = global::JWMSY.Properties.Resources.LoginForm_user;
            editorButton5.Appearance = appearance6;
            this.utxtUser.ButtonsLeft.Add(editorButton5);
            this.utxtUser.Location = new System.Drawing.Point(16, 48);
            this.utxtUser.Name = "utxtUser";
            this.utxtUser.Size = new System.Drawing.Size(315, 29);
            this.utxtUser.TabIndex = 1;
            // 
            // utxtServer
            // 
            appearance7.BackColor = System.Drawing.Color.White;
            this.utxtServer.Appearance = appearance7;
            this.utxtServer.AutoSize = false;
            this.utxtServer.BackColor = System.Drawing.Color.White;
            appearance8.Image = global::JWMSY.Properties.Resources.LoginForm_server;
            editorButton6.Appearance = appearance8;
            this.utxtServer.ButtonsLeft.Add(editorButton6);
            this.utxtServer.Location = new System.Drawing.Point(16, 14);
            this.utxtServer.Name = "utxtServer";
            this.utxtServer.Size = new System.Drawing.Size(315, 29);
            this.utxtServer.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Image = global::JWMSY.Properties.Resources.LoginForm_login_btn;
            this.lblLogin.Location = new System.Drawing.Point(152, 347);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(196, 45);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = " 登陆";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            this.lblLogin.MouseHover += new System.EventHandler(this.lblLogin_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Image = ((System.Drawing.Image)(resources.GetObject("lblExit.Image")));
            this.lblExit.Location = new System.Drawing.Point(450, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 13);
            this.lblExit.TabIndex = 8;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(134, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "WMS_YOFOTO";
            // 
            // ultraFormattedLinkLabel1
            // 
            appearance9.BackColor = System.Drawing.Color.Transparent;
            appearance9.FontData.BoldAsString = "False";
            appearance9.FontData.ItalicAsString = "False";
            appearance9.FontData.Name = "Tahoma";
            appearance9.FontData.SizeInPoints = 9F;
            appearance9.FontData.StrikeoutAsString = "False";
            appearance9.FontData.UnderlineAsString = "False";
            this.ultraFormattedLinkLabel1.Appearance = appearance9;
            this.ultraFormattedLinkLabel1.Location = new System.Drawing.Point(12, 439);
            this.ultraFormattedLinkLabel1.Name = "ultraFormattedLinkLabel1";
            this.ultraFormattedLinkLabel1.Size = new System.Drawing.Size(476, 19);
            this.ultraFormattedLinkLabel1.TabIndex = 10;
            this.ultraFormattedLinkLabel1.TabStop = true;
            this.ultraFormattedLinkLabel1.Value = "<p style=\"text-align:Center;\">Copyright @ 2014 powered by <a title=\"金蝶软件 - 金蝶国际软件" +
    "集团有限公司\" href=\"www.kingdee.com\">Kingdee</a> 保留所有权利.</p>";
            // 
            // WmsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JWMSY.Properties.Resources.BackgroundImageStore;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 475);
            this.Controls.Add(this.ultraFormattedLinkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.uPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "WmsLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS登录";
            this.Load += new System.EventHandler(this.WmsLogin_Load);
            this.uPanelMain.ClientArea.ResumeLayout(false);
            this.uPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utxtAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel uPanelMain;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtAccount;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udDate;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtUser;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtServer;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabel1;
    }
}