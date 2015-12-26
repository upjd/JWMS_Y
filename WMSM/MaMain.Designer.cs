namespace WMSM
{
    partial class MaMain
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup15 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem13 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.uSplitterLeft = new Infragistics.Win.Misc.UltraSplitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.MdiManager = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uExplorerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // uSplitterLeft
            // 
            this.uSplitterLeft.Location = new System.Drawing.Point(222, 0);
            this.uSplitterLeft.Name = "uSplitterLeft";
            this.uSplitterLeft.RestoreExtent = 222;
            this.uSplitterLeft.Size = new System.Drawing.Size(10, 562);
            this.uSplitterLeft.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uExplorerBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 562);
            this.panel1.TabIndex = 10;
            // 
            // uExplorerBar
            // 
            this.uExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarItem13.Key = "WMSM.BackupForm";
            appearance1.Image = global::WMSM.Properties.Resources.item;
            ultraExplorerBarItem13.Settings.AppearancesSmall.Appearance = appearance1;
            ultraExplorerBarItem13.Text = "数据库备份及管理";
            ultraExplorerBarItem1.Key = "WMSM.BaseUser";
            appearance2.Image = global::WMSM.Properties.Resources.item;
            ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance = appearance2;
            ultraExplorerBarItem1.Text = "用户管理";
            ultraExplorerBarItem2.Key = "WMSM.BaseRoleFunction";
            appearance3.Image = global::WMSM.Properties.Resources.item;
            ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance = appearance3;
            ultraExplorerBarItem2.Text = "角色权限管理";
            ultraExplorerBarGroup15.Items.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem[] {
            ultraExplorerBarItem13,
            ultraExplorerBarItem1,
            ultraExplorerBarItem2});
            ultraExplorerBarGroup15.Key = "系统管理";
            ultraExplorerBarGroup15.Text = "系统管理";
            this.uExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup15});
            this.uExplorerBar.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText;
            this.uExplorerBar.Location = new System.Drawing.Point(0, 0);
            this.uExplorerBar.Name = "uExplorerBar";
            this.uExplorerBar.ShowDefaultContextMenu = false;
            this.uExplorerBar.Size = new System.Drawing.Size(222, 562);
            this.uExplorerBar.TabIndex = 2;
            this.uExplorerBar.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.Office2007;
            this.uExplorerBar.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.uExplorerBar_ItemClick);
            // 
            // MdiManager
            // 
            this.MdiManager.AllowHorizontalTabGroups = false;
            this.MdiManager.AllowVerticalTabGroups = false;
            this.MdiManager.MdiParent = this;
            this.MdiManager.ViewStyle = Infragistics.Win.UltraWinTabbedMdi.ViewStyle.Office2007;
            // 
            // MaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uSplitterLeft);
            this.Controls.Add(this.panel1);
            this.Icon = global::WMSM.Properties.Resources.Mine;
            this.IsMdiContainer = true;
            this.Name = "MaMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaMain_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uExplorerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraSplitter uSplitterLeft;
        private System.Windows.Forms.Panel panel1;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar uExplorerBar;
        private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager MdiManager;
    }
}