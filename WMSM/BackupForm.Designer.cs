namespace WMSM
{
    partial class BackupForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("name");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("crdate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("filename");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("backup");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance("选择路径");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("operation");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance("操作");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.ugdList = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.fbdFile = new System.Windows.Forms.FolderBrowserDialog();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiOnline = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ugdList)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ugdList
            // 
            ultraGridColumn2.Header.Caption = "数据库名称";
            ultraGridColumn2.Header.VisiblePosition = 0;
            ultraGridColumn2.Width = 141;
            ultraGridColumn3.Header.Caption = "创建时间";
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.Width = 153;
            ultraGridColumn4.Header.Caption = "文件路径";
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn4.Width = 384;
            ultraGridColumn9.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            appearance1.Image = "btn_web.png";
            appearance1.Tag = "选择路径";
            ultraGridColumn9.CellButtonAppearance = appearance1;
            ultraGridColumn9.Header.Caption = "备份路径";
            ultraGridColumn9.Header.VisiblePosition = 3;
            ultraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton;
            ultraGridColumn9.Width = 361;
            ultraGridColumn10.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            appearance2.FontData.Name = "幼圆";
            appearance2.Tag = "操作";
            ultraGridColumn10.CellButtonAppearance = appearance2;
            ultraGridColumn10.Header.Caption = "操作";
            ultraGridColumn10.Header.VisiblePosition = 4;
            ultraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn10.Width = 36;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn9,
            ultraGridColumn10});
            this.ugdList.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ugdList.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            this.ugdList.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            this.ugdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugdList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ugdList.ImageList = this.imageList1;
            this.ugdList.Location = new System.Drawing.Point(0, 25);
            this.ugdList.Name = "ugdList";
            this.ugdList.Size = new System.Drawing.Size(784, 437);
            this.ugdList.TabIndex = 0;
            this.ugdList.Text = "数据库列表";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btn_web.png");
            // 
            // msMain
            // 
            this.msMain.BackgroundImage = global::WMSM.Properties.Resources.toolbarBk;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOnline});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 25);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiOnline
            // 
            this.tsmiOnline.Name = "tsmiOnline";
            this.tsmiOnline.Size = new System.Drawing.Size(92, 21);
            this.tsmiOnline.Text = "在线许可激活";
            this.tsmiOnline.Click += new System.EventHandler(this.tsmiOnline_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.ugdList);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库备份及管理";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ugdList)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ugdList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog fbdFile;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiOnline;
    }
}

