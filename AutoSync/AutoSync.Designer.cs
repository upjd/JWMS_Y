namespace AutoSync
{
    partial class AutoSync
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uid");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cGuid");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cOrderNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cEasNewOrder");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cState");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bEnable");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dAddtime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dUpdate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMemo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoSync));
            this.uGroupBox = new Infragistics.Win.Misc.UltraExpandableGroupBox();
            this.uGroupBoxPanelTop = new Infragistics.Win.Misc.UltraExpandableGroupBoxPanel();
            this.lblCostTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimeSpan = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTimeSpan = new System.Windows.Forms.NumericUpDown();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tsOpeStore = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtServer = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.uGridScan = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.timerExec = new System.Windows.Forms.Timer(this.components);
            this.timerSpan = new System.Windows.Forms.Timer(this.components);
            this.nfiMain = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uGroupBox)).BeginInit();
            this.uGroupBox.SuspendLayout();
            this.uGroupBoxPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSpan)).BeginInit();
            this.tsOpeStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridScan)).BeginInit();
            this.SuspendLayout();
            // 
            // uGroupBox
            // 
            this.uGroupBox.Controls.Add(this.uGroupBoxPanelTop);
            this.uGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.uGroupBox.ExpandedSize = new System.Drawing.Size(984, 114);
            this.uGroupBox.Location = new System.Drawing.Point(0, 25);
            this.uGroupBox.Name = "uGroupBox";
            this.uGroupBox.Size = new System.Drawing.Size(984, 114);
            this.uGroupBox.TabIndex = 16;
            this.uGroupBox.Text = "配置运行时属性";
            this.uGroupBox.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // uGroupBoxPanelTop
            // 
            this.uGroupBoxPanelTop.Controls.Add(this.lblCostTime);
            this.uGroupBoxPanelTop.Controls.Add(this.label5);
            this.uGroupBoxPanelTop.Controls.Add(this.lblLastTime);
            this.uGroupBoxPanelTop.Controls.Add(this.label4);
            this.uGroupBoxPanelTop.Controls.Add(this.lblTimeSpan);
            this.uGroupBoxPanelTop.Controls.Add(this.dtpStartTime);
            this.uGroupBoxPanelTop.Controls.Add(this.label3);
            this.uGroupBoxPanelTop.Controls.Add(this.label2);
            this.uGroupBoxPanelTop.Controls.Add(this.nudTimeSpan);
            this.uGroupBoxPanelTop.Controls.Add(this.btnSaveTime);
            this.uGroupBoxPanelTop.Controls.Add(this.label1);
            this.uGroupBoxPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGroupBoxPanelTop.Location = new System.Drawing.Point(3, 20);
            this.uGroupBoxPanelTop.Name = "uGroupBoxPanelTop";
            this.uGroupBoxPanelTop.Size = new System.Drawing.Size(978, 91);
            this.uGroupBoxPanelTop.TabIndex = 0;
            // 
            // lblCostTime
            // 
            this.lblCostTime.AutoSize = true;
            this.lblCostTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCostTime.Location = new System.Drawing.Point(837, 54);
            this.lblCostTime.Name = "lblCostTime";
            this.lblCostTime.Size = new System.Drawing.Size(0, 12);
            this.lblCostTime.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(796, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "用时:";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLastTime.Location = new System.Drawing.Point(659, 54);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(0, 12);
            this.lblLastTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(523, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "上一次执行导入时间是:";
            // 
            // lblTimeSpan
            // 
            this.lblTimeSpan.AutoSize = true;
            this.lblTimeSpan.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeSpan.Location = new System.Drawing.Point(339, 54);
            this.lblTimeSpan.Name = "lblTimeSpan";
            this.lblTimeSpan.Size = new System.Drawing.Size(0, 12);
            this.lblTimeSpan.TabIndex = 7;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartTime.Enabled = false;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(109, 50);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(157, 21);
            this.dtpStartTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(286, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "已运行:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "开始时间为:";
            // 
            // nudTimeSpan
            // 
            this.nudTimeSpan.Location = new System.Drawing.Point(181, 4);
            this.nudTimeSpan.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTimeSpan.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTimeSpan.Name = "nudTimeSpan";
            this.nudTimeSpan.Size = new System.Drawing.Size(52, 21);
            this.nudTimeSpan.TabIndex = 3;
            this.nudTimeSpan.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.Location = new System.Drawing.Point(235, 3);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(52, 23);
            this.btnSaveTime.TabIndex = 2;
            this.btnSaveTime.Text = "保存";
            this.btnSaveTime.UseVisualStyleBackColor = true;
            this.btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1:定时执行间隔(单位:分)";
            // 
            // tsOpeStore
            // 
            this.tsOpeStore.BackgroundImage = global::AutoSync.Properties.Resources.toolbarBk;
            this.tsOpeStore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.tstxtServer,
            this.tsbtnSave,
            this.toolStripSeparator1});
            this.tsOpeStore.Location = new System.Drawing.Point(0, 0);
            this.tsOpeStore.Name = "tsOpeStore";
            this.tsOpeStore.Size = new System.Drawing.Size(984, 25);
            this.tsOpeStore.TabIndex = 15;
            // 
            // tsbExit
            // 
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(36, 22);
            this.tsbExit.Text = "退出";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel1.Text = "服务器IP端口：";
            // 
            // tstxtServer
            // 
            this.tstxtServer.Name = "tstxtServer";
            this.tstxtServer.Size = new System.Drawing.Size(210, 25);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(60, 22);
            this.tsbtnSave.Text = "保存配置";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbMain.Location = new System.Drawing.Point(0, 139);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(984, 23);
            this.pbMain.TabIndex = 17;
            // 
            // uGridScan
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridScan.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn2.Header.Caption = "类型";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn3.Header.Caption = "GUID标识";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn4.Header.Caption = "源单据号";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn18.Header.Caption = "新EAS单据";
            ultraGridColumn18.Header.VisiblePosition = 4;
            ultraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn19.Header.Caption = "状态";
            ultraGridColumn19.Header.VisiblePosition = 5;
            ultraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn20.Header.Caption = "是否有效";
            ultraGridColumn20.Header.VisiblePosition = 6;
            ultraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn21.Format = "yyyy-MM-dd HH:mm:ss";
            ultraGridColumn21.Header.Caption = "扫描时间";
            ultraGridColumn21.Header.VisiblePosition = 7;
            ultraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn22.Header.Caption = "上传时间";
            ultraGridColumn22.Header.VisiblePosition = 8;
            ultraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn23.Header.Caption = "备注";
            ultraGridColumn23.Header.VisiblePosition = 9;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23});
            this.uGridScan.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridScan.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            this.uGridScan.DisplayLayout.ColumnChooserEnabled = Infragistics.Win.DefaultableBoolean.False;
            this.uGridScan.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridScan.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridScan.DisplayLayout.MaxRowScrollRegions = 1;
            this.uGridScan.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.uGridScan.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.uGridScan.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.uGridScan.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.uGridScan.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridScan.DisplayLayout.Override.CellPadding = 3;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.TextHAlignAsString = "Center";
            appearance3.TextVAlignAsString = "Middle";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridScan.DisplayLayout.Override.HeaderAppearance = appearance3;
            appearance4.BorderColor = System.Drawing.Color.Black;
            appearance4.TextHAlignAsString = "Right";
            appearance4.TextVAlignAsString = "Middle";
            this.uGridScan.DisplayLayout.Override.RowAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridScan.DisplayLayout.Override.RowSelectorAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridScan.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance6;
            this.uGridScan.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridScan.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridScan.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridScan.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance7.BorderColor = System.Drawing.Color.Black;
            appearance7.ForeColor = System.Drawing.Color.Black;
            this.uGridScan.DisplayLayout.Override.SelectedRowAppearance = appearance7;
            this.uGridScan.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridScan.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridScan.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridScan.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridScan.Location = new System.Drawing.Point(0, 162);
            this.uGridScan.Name = "uGridScan";
            this.uGridScan.Size = new System.Drawing.Size(984, 400);
            this.uGridScan.TabIndex = 18;
            this.uGridScan.Text = "未导入EAS单据";
            this.uGridScan.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // timerExec
            // 
            this.timerExec.Enabled = true;
            this.timerExec.Interval = 6000;
            this.timerExec.Tick += new System.EventHandler(this.timerExec_Tick);
            // 
            // timerSpan
            // 
            this.timerSpan.Enabled = true;
            this.timerSpan.Interval = 1000;
            this.timerSpan.Tick += new System.EventHandler(this.timerSpan_Tick);
            // 
            // nfiMain
            // 
            this.nfiMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiMain.Icon")));
            this.nfiMain.Text = "nfiMain";
            this.nfiMain.Visible = true;
            this.nfiMain.DoubleClick += new System.EventHandler(this.nfiMain_DoubleClick);
            // 
            // AutoSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridScan);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.uGroupBox);
            this.Controls.Add(this.tsOpeStore);
            this.Icon = global::AutoSync.Properties.Resources.Mine;
            this.MaximizeBox = false;
            this.Name = "AutoSync";
            this.Text = "自动同步";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoSync_FormClosing);
            this.Load += new System.EventHandler(this.AutoSync_Load);
            this.SizeChanged += new System.EventHandler(this.AutoSync_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.uGroupBox)).EndInit();
            this.uGroupBox.ResumeLayout(false);
            this.uGroupBoxPanelTop.ResumeLayout(false);
            this.uGroupBoxPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSpan)).EndInit();
            this.tsOpeStore.ResumeLayout(false);
            this.tsOpeStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraExpandableGroupBox uGroupBox;
        private Infragistics.Win.Misc.UltraExpandableGroupBoxPanel uGroupBoxPanelTop;
        private System.Windows.Forms.Label lblCostTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimeSpan;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTimeSpan;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsOpeStore;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ProgressBar pbMain;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridScan;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtServer;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timerExec;
        private System.Windows.Forms.Timer timerSpan;
        private System.Windows.Forms.NotifyIcon nfiMain;
    }
}

