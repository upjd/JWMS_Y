namespace JWMSY
{
    partial class Rpt_WmsAndEasComparePoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_WmsAndEasComparePoDetail));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("wcInvCode");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("wcInvName");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("wiQuantity");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvCode");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvName");
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iSumQuantity");
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cUnit");
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ImgCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            this.biExport = new DevExpress.XtraBars.BarButtonItem();
            this.biPreview = new DevExpress.XtraBars.BarButtonItem();
            this.biDesign = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.biSearch = new DevExpress.XtraBars.BarButtonItem();
            this.beidDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bsilblDate = new DevExpress.XtraBars.BarStaticItem();
            this.ImgCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tsgfMain = new UpjdControlBox.ToolStripGridFunction();
            this.uGridProBoxBarCode = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridProBoxBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Images = this.ImgCollection16;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.biExport,
            this.biPreview,
            this.biDesign,
            this.biPrint,
            this.biExit,
            this.biSearch,
            this.beidDate,
            this.bsilblDate});
            this.ribbon.LargeImages = this.ImgCollection32;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 70;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
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
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.design, "design", typeof(global::JWMSY.Properties.Resources), 0);
            this.ImgCollection16.Images.SetKeyName(0, "design");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.preview, "preview", typeof(global::JWMSY.Properties.Resources), 1);
            this.ImgCollection16.Images.SetKeyName(1, "preview");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.print, "print", typeof(global::JWMSY.Properties.Resources), 2);
            this.ImgCollection16.Images.SetKeyName(2, "print");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.search, "search", typeof(global::JWMSY.Properties.Resources), 3);
            this.ImgCollection16.Images.SetKeyName(3, "search");
            // 
            // biExport
            // 
            this.biExport.Caption = "输出";
            this.biExport.Id = 3;
            this.biExport.LargeImageIndex = 5;
            this.biExport.Name = "biExport";
            this.biExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biExport_ItemClick);
            // 
            // biPreview
            // 
            this.biPreview.Caption = "预览";
            this.biPreview.Id = 53;
            this.biPreview.ImageIndex = 1;
            this.biPreview.Name = "biPreview";
            // 
            // biDesign
            // 
            this.biDesign.Caption = "设计";
            this.biDesign.Id = 54;
            this.biDesign.ImageIndex = 0;
            this.biDesign.Name = "biDesign";
            // 
            // biPrint
            // 
            this.biPrint.Caption = "打印";
            this.biPrint.Id = 55;
            this.biPrint.ImageIndex = 2;
            this.biPrint.Name = "biPrint";
            // 
            // biExit
            // 
            this.biExit.Caption = "退出";
            this.biExit.Id = 62;
            this.biExit.LargeImageIndex = 4;
            this.biExit.Name = "biExit";
            this.biExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biExit_ItemClick);
            // 
            // biSearch
            // 
            this.biSearch.Caption = "查询";
            this.biSearch.Id = 67;
            this.biSearch.LargeImageIndex = 10;
            this.biSearch.Name = "biSearch";
            this.biSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSearch_ItemClick);
            // 
            // beidDate
            // 
            this.beidDate.Caption = "日期";
            this.beidDate.Edit = this.repositoryItemDateEdit1;
            this.beidDate.Id = 68;
            this.beidDate.Name = "beidDate";
            this.beidDate.Width = 160;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // bsilblDate
            // 
            this.bsilblDate.Caption = "请输入日期后查询";
            this.bsilblDate.Id = 69;
            this.bsilblDate.Name = "bsilblDate";
            this.bsilblDate.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ImgCollection32
            // 
            this.ImgCollection32.ImageSize = new System.Drawing.Size(32, 32);
            this.ImgCollection32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImgCollection32.ImageStream")));
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.abandon, "abandon", typeof(global::JWMSY.Properties.Resources), 0);
            this.ImgCollection32.Images.SetKeyName(0, "abandon");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.add, "add", typeof(global::JWMSY.Properties.Resources), 1);
            this.ImgCollection32.Images.SetKeyName(1, "add");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.edit, "edit", typeof(global::JWMSY.Properties.Resources), 2);
            this.ImgCollection32.Images.SetKeyName(2, "edit");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.examin, "examin", typeof(global::JWMSY.Properties.Resources), 3);
            this.ImgCollection32.Images.SetKeyName(3, "examin");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.exit, "exit", typeof(global::JWMSY.Properties.Resources), 4);
            this.ImgCollection32.Images.SetKeyName(4, "exit");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.ExportDialog, "ExportDialog", typeof(global::JWMSY.Properties.Resources), 5);
            this.ImgCollection32.Images.SetKeyName(5, "ExportDialog");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.giveup, "giveup", typeof(global::JWMSY.Properties.Resources), 6);
            this.ImgCollection32.Images.SetKeyName(6, "giveup");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.printDialog, "printDialog", typeof(global::JWMSY.Properties.Resources), 7);
            this.ImgCollection32.Images.SetKeyName(7, "printDialog");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.save, "save", typeof(global::JWMSY.Properties.Resources), 8);
            this.ImgCollection32.Images.SetKeyName(8, "save");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.delete1, "delete1", typeof(global::JWMSY.Properties.Resources), 9);
            this.ImgCollection32.Images.SetKeyName(9, "delete1");
            this.ImgCollection32.Images.SetKeyName(10, "Query.png");
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystem,
            this.rpgExport,
            this.rpgSearch});
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
            // rpgExport
            // 
            this.rpgExport.ItemLinks.Add(this.biExport);
            this.rpgExport.Name = "rpgExport";
            this.rpgExport.ShowCaptionButton = false;
            this.rpgExport.Text = "处理";
            // 
            // rpgSearch
            // 
            this.rpgSearch.ItemLinks.Add(this.bsilblDate);
            this.rpgSearch.ItemLinks.Add(this.beidDate);
            this.rpgSearch.ItemLinks.Add(this.biSearch);
            this.rpgSearch.Name = "rpgSearch";
            this.rpgSearch.Text = "查询";
            // 
            // tsgfMain
            // 
            this.tsgfMain.Constr = null;
            this.tsgfMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsgfMain.FormId = null;
            this.tsgfMain.FormName = null;
            this.tsgfMain.Location = new System.Drawing.Point(0, 98);
            this.tsgfMain.Name = "tsgfMain";
            this.tsgfMain.Size = new System.Drawing.Size(984, 25);
            this.tsgfMain.TabIndex = 27;
            this.tsgfMain.UGrid = this.uGridProBoxBarCode;
            // 
            // uGridProBoxBarCode
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridProBoxBarCode.DisplayLayout.Appearance = appearance1;
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ultraGridColumn2.CellAppearance = appearance2;
            ultraGridColumn2.Header.Caption = "产品编码";
            ultraGridColumn2.Header.VisiblePosition = 0;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ultraGridColumn6.CellAppearance = appearance3;
            ultraGridColumn6.Header.Caption = "产品名称";
            ultraGridColumn6.Header.VisiblePosition = 1;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ultraGridColumn7.CellAppearance = appearance4;
            ultraGridColumn7.Header.Caption = "WMS数量";
            ultraGridColumn7.Header.VisiblePosition = 2;
            ultraGridColumn7.Width = 145;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ultraGridColumn14.CellAppearance = appearance5;
            ultraGridColumn14.Header.Caption = "产品编码";
            ultraGridColumn14.Header.VisiblePosition = 4;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ultraGridColumn13.CellAppearance = appearance6;
            ultraGridColumn13.Header.Caption = "产品名称";
            ultraGridColumn13.Header.VisiblePosition = 3;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ultraGridColumn18.CellAppearance = appearance7;
            ultraGridColumn18.Header.Caption = "EAS数量";
            ultraGridColumn18.Header.VisiblePosition = 5;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ultraGridColumn24.CellAppearance = appearance8;
            ultraGridColumn24.Header.Caption = "单位";
            ultraGridColumn24.Header.VisiblePosition = 6;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn2,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn14,
            ultraGridColumn13,
            ultraGridColumn18,
            ultraGridColumn24});
            this.uGridProBoxBarCode.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridProBoxBarCode.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridProBoxBarCode.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridProBoxBarCode.DisplayLayout.MaxRowScrollRegions = 1;
            appearance9.BackColor = System.Drawing.Color.Transparent;
            this.uGridProBoxBarCode.DisplayLayout.Override.CardAreaAppearance = appearance9;
            this.uGridProBoxBarCode.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridProBoxBarCode.DisplayLayout.Override.CellPadding = 3;
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance10.TextHAlignAsString = "Center";
            appearance10.TextVAlignAsString = "Middle";
            appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridProBoxBarCode.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.uGridProBoxBarCode.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            appearance11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uGridProBoxBarCode.DisplayLayout.Override.RowAlternateAppearance = appearance11;
            appearance12.BorderColor = System.Drawing.Color.Black;
            appearance12.TextHAlignAsString = "Right";
            appearance12.TextVAlignAsString = "Middle";
            this.uGridProBoxBarCode.DisplayLayout.Override.RowAppearance = appearance12;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorAppearance = appearance13;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance14;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance15.BorderColor = System.Drawing.Color.Black;
            appearance15.ForeColor = System.Drawing.Color.Black;
            this.uGridProBoxBarCode.DisplayLayout.Override.SelectedRowAppearance = appearance15;
            this.uGridProBoxBarCode.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridProBoxBarCode.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridProBoxBarCode.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridProBoxBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridProBoxBarCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridProBoxBarCode.Location = new System.Drawing.Point(0, 123);
            this.uGridProBoxBarCode.Name = "uGridProBoxBarCode";
            this.uGridProBoxBarCode.Size = new System.Drawing.Size(984, 439);
            this.uGridProBoxBarCode.TabIndex = 37;
            this.uGridProBoxBarCode.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // Rpt_WmsAndEasComparePoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridProBoxBarCode);
            this.Controls.Add(this.tsgfMain);
            this.Controls.Add(this.ribbon);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "Rpt_WmsAndEasComparePoDetail";
            this.Text = "WMS与EAS采购收货对照表";
            this.Load += new System.EventHandler(this.Rpt_ProPrintRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridProBoxBarCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.Utils.ImageCollection ImgCollection16;
        private DevExpress.XtraBars.BarButtonItem biPreview;
        private DevExpress.XtraBars.BarButtonItem biDesign;
        private DevExpress.XtraBars.BarButtonItem biPrint;
        private DevExpress.XtraBars.BarButtonItem biExport;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.XtraBars.BarButtonItem biSearch;
        private DevExpress.Utils.ImageCollection ImgCollection32;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSearch;
        private UpjdControlBox.ToolStripGridFunction tsgfMain;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridProBoxBarCode;
        private DevExpress.XtraBars.BarEditItem beidDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarStaticItem bsilblDate;
    }
}