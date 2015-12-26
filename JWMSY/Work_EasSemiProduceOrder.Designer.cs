namespace JWMSY
{
    partial class Work_EasSemiProduceOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work_EasSemiProduceOrder));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCVCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dCVDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cWhCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cWhName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCvType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMaker");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CheckState");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ImgCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            this.bsiPrint = new DevExpress.XtraBars.BarSubItem();
            this.biPreview = new DevExpress.XtraBars.BarButtonItem();
            this.biDesign = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biExport = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.biSearch = new DevExpress.XtraBars.BarButtonItem();
            this.ImgCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.uGridCheck = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tsgfMain = new UpjdControlBox.ToolStripGridFunction();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Images = this.ImgCollection16;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bsiPrint,
            this.biExport,
            this.biPreview,
            this.biDesign,
            this.biPrint,
            this.biExit,
            this.biSearch,
            this.bbiRefresh});
            this.ribbon.LargeImages = this.ImgCollection32;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 70;
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
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.design, "design", typeof(global::JWMSY.Properties.Resources), 0);
            this.ImgCollection16.Images.SetKeyName(0, "design");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.preview, "preview", typeof(global::JWMSY.Properties.Resources), 1);
            this.ImgCollection16.Images.SetKeyName(1, "preview");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.print, "print", typeof(global::JWMSY.Properties.Resources), 2);
            this.ImgCollection16.Images.SetKeyName(2, "print");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.search, "search", typeof(global::JWMSY.Properties.Resources), 3);
            this.ImgCollection16.Images.SetKeyName(3, "search");
            // 
            // bsiPrint
            // 
            this.bsiPrint.Caption = "打印";
            this.bsiPrint.Id = 2;
            this.bsiPrint.LargeImageIndex = 7;
            this.bsiPrint.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biPreview),
            new DevExpress.XtraBars.LinkPersistInfo(this.biDesign),
            new DevExpress.XtraBars.LinkPersistInfo(this.biPrint)});
            this.bsiPrint.Name = "bsiPrint";
            this.bsiPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biPreview
            // 
            this.biPreview.Caption = "预览";
            this.biPreview.Id = 53;
            this.biPreview.ImageIndex = 1;
            this.biPreview.Name = "biPreview";
            this.biPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biPreview_ItemClick);
            // 
            // biDesign
            // 
            this.biDesign.Caption = "设计";
            this.biDesign.Id = 54;
            this.biDesign.ImageIndex = 0;
            this.biDesign.Name = "biDesign";
            this.biDesign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDesign_ItemClick);
            // 
            // biPrint
            // 
            this.biPrint.Caption = "打印";
            this.biPrint.Id = 55;
            this.biPrint.ImageIndex = 2;
            this.biPrint.Name = "biPrint";
            this.biPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biPrint_ItemClick);
            // 
            // biExport
            // 
            this.biExport.Caption = "输出";
            this.biExport.Id = 3;
            this.biExport.LargeImageIndex = 5;
            this.biExport.Name = "biExport";
            this.biExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.biSearch.ImageIndex = 3;
            this.biSearch.LargeImageIndex = 10;
            this.biSearch.Name = "biSearch";
            this.biSearch.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.biSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSearch_ItemClick);
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
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.cRefresh, "cRefresh", typeof(global::JWMSY.Properties.Resources), 11);
            this.ImgCollection32.Images.SetKeyName(11, "cRefresh");
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
            this.rpgExport.ItemLinks.Add(this.bsiPrint);
            this.rpgExport.ItemLinks.Add(this.biExport);
            this.rpgExport.Name = "rpgExport";
            this.rpgExport.ShowCaptionButton = false;
            this.rpgExport.Text = "处理";
            // 
            // rpgSearch
            // 
            this.rpgSearch.ItemLinks.Add(this.biSearch);
            this.rpgSearch.ItemLinks.Add(this.bbiRefresh);
            this.rpgSearch.Name = "rpgSearch";
            this.rpgSearch.Text = "查询";
            // 
            // uGridCheck
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridCheck.DisplayLayout.Appearance = appearance1;
            ultraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn17.Header.VisiblePosition = 0;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn25.Header.Caption = "单号";
            ultraGridColumn25.Header.VisiblePosition = 1;
            ultraGridColumn25.Width = 141;
            ultraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn26.Header.Caption = "日期";
            ultraGridColumn26.Header.VisiblePosition = 2;
            ultraGridColumn26.Width = 149;
            ultraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn27.Header.Caption = "仓库编码";
            ultraGridColumn27.Header.VisiblePosition = 3;
            ultraGridColumn27.Width = 136;
            ultraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn28.Header.Caption = "仓库名称";
            ultraGridColumn28.Header.VisiblePosition = 4;
            ultraGridColumn28.Width = 168;
            ultraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn29.Header.Caption = "类型";
            ultraGridColumn29.Header.VisiblePosition = 5;
            ultraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn23.Header.Caption = "制单人";
            ultraGridColumn23.Header.VisiblePosition = 6;
            ultraGridColumn23.Width = 114;
            ultraGridColumn6.Header.Caption = "状态";
            ultraGridColumn6.Header.VisiblePosition = 7;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn17,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn23,
            ultraGridColumn6});
            this.uGridCheck.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridCheck.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridCheck.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridCheck.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.uGridCheck.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.uGridCheck.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridCheck.DisplayLayout.Override.CellPadding = 3;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.TextHAlignAsString = "Center";
            appearance3.TextVAlignAsString = "Middle";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridCheck.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.uGridCheck.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uGridCheck.DisplayLayout.Override.RowAlternateAppearance = appearance4;
            appearance5.BorderColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Right";
            appearance5.TextVAlignAsString = "Middle";
            this.uGridCheck.DisplayLayout.Override.RowAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridCheck.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridCheck.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance7;
            this.uGridCheck.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridCheck.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridCheck.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridCheck.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.Color.Black;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.uGridCheck.DisplayLayout.Override.SelectedRowAppearance = appearance8;
            this.uGridCheck.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridCheck.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridCheck.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridCheck.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridCheck.Location = new System.Drawing.Point(0, 123);
            this.uGridCheck.Name = "uGridCheck";
            this.uGridCheck.Size = new System.Drawing.Size(984, 439);
            this.uGridCheck.TabIndex = 51;
            this.uGridCheck.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
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
            this.tsgfMain.TabIndex = 50;
            this.tsgfMain.UGrid = this.uGridCheck;
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "刷新";
            this.bbiRefresh.Id = 68;
            this.bbiRefresh.LargeImageIndex = 11;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // Work_EasSemiProduceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridCheck);
            this.Controls.Add(this.tsgfMain);
            this.Controls.Add(this.ribbon);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "Work_EasSemiProduceOrder";
            this.Text = "EAS生产订单";
            this.Load += new System.EventHandler(this.Work_EasSemiProduceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarSubItem bsiPrint;
        private DevExpress.XtraBars.BarButtonItem biPreview;
        private DevExpress.XtraBars.BarButtonItem biDesign;
        private DevExpress.XtraBars.BarButtonItem biPrint;
        private DevExpress.XtraBars.BarButtonItem biExport;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.Utils.ImageCollection ImgCollection16;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridCheck;
        private UpjdControlBox.ToolStripGridFunction tsgfMain;
        private DevExpress.XtraBars.BarButtonItem biSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSearch;
        private DevExpress.Utils.ImageCollection ImgCollection32;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
    }
}