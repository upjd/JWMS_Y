namespace JWMSY
{
    partial class WorkProBoxWeigh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkProBoxWeigh));
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton2 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AutoID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cBoxNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iQuantity");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCusCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCusName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMemo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cOperator");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dAddTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iPrintCount");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ImgCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            this.biSave = new DevExpress.XtraBars.BarButtonItem();
            this.biAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.ImgCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcMemo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcCusCode = new System.Windows.Forms.TextBox();
            this.dtpdDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.uteiWeight = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.utecBoxNumber = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uGridOutBox = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.spMain = new System.IO.Ports.SerialPort(this.components);
            this.lblTitleMain = new JWMSY.UpjdControl.lblTitle();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uteiWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utecBoxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridOutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Images = this.ImgCollection16;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.biSave,
            this.biAddNew,
            this.biExit});
            this.ribbon.LargeImages = this.ImgCollection32;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 69;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(984, 98);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ImgCollection16
            // 
            this.ImgCollection16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImgCollection16.ImageStream")));
            // 
            // biSave
            // 
            this.biSave.Caption = "保存";
            this.biSave.Enabled = false;
            this.biSave.Id = 46;
            this.biSave.LargeImageIndex = 2;
            this.biSave.Name = "biSave";
            this.biSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSave_ItemClick);
            // 
            // biAddNew
            // 
            this.biAddNew.Caption = "新增";
            this.biAddNew.Id = 58;
            this.biAddNew.LargeImageIndex = 1;
            this.biAddNew.Name = "biAddNew";
            this.biAddNew.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biAddNew_ItemClick);
            // 
            // biExit
            // 
            this.biExit.Caption = "退出";
            this.biExit.Id = 62;
            this.biExit.LargeImageIndex = 0;
            this.biExit.Name = "biExit";
            this.biExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biExit_ItemClick);
            // 
            // ImgCollection32
            // 
            this.ImgCollection32.ImageSize = new System.Drawing.Size(32, 32);
            this.ImgCollection32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImgCollection32.ImageStream")));
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.exit, "exit", typeof(global::JWMSY.Properties.Resources), 0);
            this.ImgCollection32.Images.SetKeyName(0, "exit");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.edit, "edit", typeof(global::JWMSY.Properties.Resources), 1);
            this.ImgCollection32.Images.SetKeyName(1, "edit");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.save, "save", typeof(global::JWMSY.Properties.Resources), 2);
            this.ImgCollection32.Images.SetKeyName(2, "save");
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystem,
            this.rpgNew});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "菜单选项";
            // 
            // rpgSystem
            // 
            this.rpgSystem.ItemLinks.Add(this.biExit);
            this.rpgSystem.Name = "rpgSystem";
            this.rpgSystem.ShowCaptionButton = false;
            this.rpgSystem.Text = "系统";
            // 
            // rpgNew
            // 
            this.rpgNew.ItemLinks.Add(this.biAddNew);
            this.rpgNew.ItemLinks.Add(this.biSave);
            this.rpgNew.Name = "rpgNew";
            this.rpgNew.ShowCaptionButton = false;
            this.rpgNew.Text = "操作";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.txtcMemo);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.txtcCusName);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.txtcCusCode);
            this.panelTop.Controls.Add(this.dtpdDate);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.uteiWeight);
            this.panelTop.Controls.Add(this.utecBoxNumber);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 133);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 121);
            this.panelTop.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 70;
            this.label8.Text = "备注：";
            // 
            // txtcMemo
            // 
            this.txtcMemo.Location = new System.Drawing.Point(708, 67);
            this.txtcMemo.Name = "txtcMemo";
            this.txtcMemo.Size = new System.Drawing.Size(194, 21);
            this.txtcMemo.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 68;
            this.label7.Text = "客户名称：";
            // 
            // txtcCusName
            // 
            this.txtcCusName.Location = new System.Drawing.Point(437, 67);
            this.txtcCusName.Name = "txtcCusName";
            this.txtcCusName.ReadOnly = true;
            this.txtcCusName.Size = new System.Drawing.Size(194, 21);
            this.txtcCusName.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 66;
            this.label2.Text = "销售单号：";
            // 
            // txtcCusCode
            // 
            this.txtcCusCode.Location = new System.Drawing.Point(151, 67);
            this.txtcCusCode.Name = "txtcCusCode";
            this.txtcCusCode.ReadOnly = true;
            this.txtcCusCode.Size = new System.Drawing.Size(194, 21);
            this.txtcCusCode.TabIndex = 65;
            // 
            // dtpdDate
            // 
            this.dtpdDate.Enabled = false;
            this.dtpdDate.Location = new System.Drawing.Point(437, 33);
            this.dtpdDate.Name = "dtpdDate";
            this.dtpdDate.Size = new System.Drawing.Size(194, 21);
            this.dtpdDate.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "称重日期：";
            // 
            // uteiWeight
            // 
            editorButton1.Text = "获取重量";
            this.uteiWeight.ButtonsRight.Add(editorButton1);
            this.uteiWeight.Location = new System.Drawing.Point(708, 33);
            this.uteiWeight.MaskInput = "nnnnnn.nn";
            this.uteiWeight.MaxValue = 10000;
            this.uteiWeight.MinValue = 0;
            this.uteiWeight.Name = "uteiWeight";
            this.uteiWeight.Nullable = true;
            this.uteiWeight.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Decimal;
            this.uteiWeight.Size = new System.Drawing.Size(194, 21);
            this.uteiWeight.TabIndex = 62;
            this.uteiWeight.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.uteiWeight_EditorButtonClick);
            // 
            // utecBoxNumber
            // 
            appearance1.Image = global::JWMSY.Properties.Resources.search_tool;
            editorButton2.Appearance = appearance1;
            this.utecBoxNumber.ButtonsRight.Add(editorButton2);
            this.utecBoxNumber.Enabled = false;
            this.utecBoxNumber.Location = new System.Drawing.Point(151, 33);
            this.utecBoxNumber.Name = "utecBoxNumber";
            this.utecBoxNumber.Size = new System.Drawing.Size(194, 21);
            this.utecBoxNumber.TabIndex = 61;
            this.utecBoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.utecBoxNumber_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "重量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 59;
            this.label1.Text = "箱    号：";
            // 
            // uGridOutBox
            // 
            appearance2.BackColor = System.Drawing.Color.White;
            this.uGridOutBox.DisplayLayout.Appearance = appearance2;
            this.uGridOutBox.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.Caption = "箱编号";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 139;
            ultraGridColumn3.Header.Caption = "数量";
            ultraGridColumn3.Header.VisiblePosition = 4;
            ultraGridColumn4.Header.Caption = "销售单号";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn5.Header.Caption = "客户名称";
            ultraGridColumn5.Header.VisiblePosition = 2;
            ultraGridColumn6.Header.Caption = "备注";
            ultraGridColumn6.Header.VisiblePosition = 7;
            ultraGridColumn7.Header.Caption = "操作人";
            ultraGridColumn7.Header.VisiblePosition = 5;
            ultraGridColumn8.Header.Caption = "添加时间";
            ultraGridColumn8.Header.VisiblePosition = 6;
            ultraGridColumn9.Header.Caption = "出库单号";
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn10.Header.Caption = "打印次数";
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10});
            this.uGridOutBox.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridOutBox.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridOutBox.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridOutBox.DisplayLayout.MaxRowScrollRegions = 1;
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.uGridOutBox.DisplayLayout.Override.CardAreaAppearance = appearance3;
            this.uGridOutBox.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridOutBox.DisplayLayout.Override.CellPadding = 3;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance4.TextHAlignAsString = "Center";
            appearance4.TextVAlignAsString = "Middle";
            appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridOutBox.DisplayLayout.Override.HeaderAppearance = appearance4;
            this.uGridOutBox.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uGridOutBox.DisplayLayout.Override.RowAlternateAppearance = appearance5;
            appearance6.BorderColor = System.Drawing.Color.Black;
            appearance6.TextHAlignAsString = "Right";
            appearance6.TextVAlignAsString = "Middle";
            this.uGridOutBox.DisplayLayout.Override.RowAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridOutBox.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridOutBox.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance8;
            this.uGridOutBox.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridOutBox.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridOutBox.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridOutBox.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.BorderColor = System.Drawing.Color.Black;
            appearance9.ForeColor = System.Drawing.Color.Black;
            this.uGridOutBox.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            this.uGridOutBox.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridOutBox.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridOutBox.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridOutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridOutBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridOutBox.Location = new System.Drawing.Point(0, 254);
            this.uGridOutBox.Name = "uGridOutBox";
            this.uGridOutBox.Size = new System.Drawing.Size(984, 308);
            this.uGridOutBox.TabIndex = 27;
            this.uGridOutBox.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // spMain
            // 
            this.spMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spMain_DataReceived);
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblTitleMain.BackgroundImage")));
            this.lblTitleMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblTitleMain.CTitle = "物流箱称重";
            this.lblTitleMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleMain.Location = new System.Drawing.Point(0, 98);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(984, 35);
            this.lblTitleMain.TabIndex = 29;
            // 
            // WorkProBoxWeigh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridOutBox);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblTitleMain);
            this.Controls.Add(this.ribbon);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "WorkProBoxWeigh";
            this.Text = "物流箱称重";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkProBoxWeigh_FormClosing);
            this.Load += new System.EventHandler(this.WorkProBoxWeigh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uteiWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utecBoxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridOutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.Utils.ImageCollection ImgCollection16;
        private DevExpress.XtraBars.BarButtonItem biSave;
        private DevExpress.XtraBars.BarButtonItem biAddNew;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.Utils.ImageCollection ImgCollection32;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNew;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcMemo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcCusCode;
        private System.Windows.Forms.DateTimePicker dtpdDate;
        private System.Windows.Forms.Label label6;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uteiWeight;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utecBoxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridOutBox;
        private System.IO.Ports.SerialPort spMain;
        private UpjdControl.lblTitle lblTitleMain;
    }
}