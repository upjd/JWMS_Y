namespace JWMSY
{
    partial class Rpt_ProSFOrder
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uid");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cWaveOrderNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cOrderNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cState");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dAddtime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cOperator");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dLastUpdate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cDefine1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cDefine2");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_ProSFOrder));
            this.uGridProBarCode = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.pageChange = new UpjdControlBox.PageChange();
            this.tsgfMain = new UpjdControlBox.ToolStripGridFunction();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ImgCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            this.biExport = new DevExpress.XtraBars.BarButtonItem();
            this.biPreview = new DevExpress.XtraBars.BarButtonItem();
            this.biDesign = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.biSearch = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ImgCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.uGridProBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).BeginInit();
            this.SuspendLayout();
            // 
            // uGridProBarCode
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridProBarCode.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.Caption = "波次单号";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 172;
            ultraGridColumn4.Header.Caption = "订单号";
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn4.Width = 193;
            ultraGridColumn5.Header.Caption = "当前状态";
            ultraGridColumn5.Header.VisiblePosition = 3;
            ultraGridColumn5.Width = 173;
            ultraGridColumn7.Header.Caption = "获取时间";
            ultraGridColumn7.Header.VisiblePosition = 4;
            ultraGridColumn8.Header.Caption = "更新人";
            ultraGridColumn8.Header.VisiblePosition = 5;
            ultraGridColumn9.Header.Caption = "最后更新时间";
            ultraGridColumn9.Header.VisiblePosition = 6;
            ultraGridColumn10.Header.VisiblePosition = 7;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn12.Header.VisiblePosition = 8;
            ultraGridColumn12.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn12});
            this.uGridProBarCode.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridProBarCode.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridProBarCode.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridProBarCode.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.uGridProBarCode.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.uGridProBarCode.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridProBarCode.DisplayLayout.Override.CellPadding = 3;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.TextHAlignAsString = "Center";
            appearance3.TextVAlignAsString = "Middle";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridProBarCode.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.uGridProBarCode.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uGridProBarCode.DisplayLayout.Override.RowAlternateAppearance = appearance4;
            appearance5.BorderColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Right";
            appearance5.TextVAlignAsString = "Middle";
            this.uGridProBarCode.DisplayLayout.Override.RowAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProBarCode.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProBarCode.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance7;
            this.uGridProBarCode.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridProBarCode.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridProBarCode.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridProBarCode.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.Color.Black;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.uGridProBarCode.DisplayLayout.Override.SelectedRowAppearance = appearance8;
            this.uGridProBarCode.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridProBarCode.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridProBarCode.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridProBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridProBarCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridProBarCode.Location = new System.Drawing.Point(0, 123);
            this.uGridProBarCode.Name = "uGridProBarCode";
            this.uGridProBarCode.Size = new System.Drawing.Size(984, 412);
            this.uGridProBarCode.TabIndex = 29;
            this.uGridProBarCode.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // pageChange
            // 
            this.pageChange.Constr = null;
            this.pageChange.CountPage = 0;
            this.pageChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageChange.FlName = "uid";
            this.pageChange.Location = new System.Drawing.Point(0, 535);
            this.pageChange.Name = "pageChange";
            this.pageChange.PageIndex = 1;
            this.pageChange.PageSize = 100;
            this.pageChange.RecordCount = 0;
            this.pageChange.Size = new System.Drawing.Size(984, 27);
            this.pageChange.TabIndex = 28;
            this.pageChange.TableRecord = "SF_Order";
            this.pageChange.UGrid = this.uGridProBarCode;
            this.pageChange.WhereStr = null;
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
            this.tsgfMain.UGrid = this.uGridProBarCode;
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
            this.bbiRefresh});
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
            this.biSearch.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSearch_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "刷新";
            this.bbiRefresh.Id = 68;
            this.bbiRefresh.LargeImageIndex = 11;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
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
            this.ImgCollection32.Images.SetKeyName(11, "cRefresh.png");
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
            this.rpgSearch.ItemLinks.Add(this.biSearch);
            this.rpgSearch.ItemLinks.Add(this.bbiRefresh);
            this.rpgSearch.Name = "rpgSearch";
            this.rpgSearch.Text = "查询";
            // 
            // Rpt_ProSFOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridProBarCode);
            this.Controls.Add(this.tsgfMain);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.pageChange);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "Rpt_ProSFOrder";
            this.Text = "波次拣货完成情况表";
            this.Load += new System.EventHandler(this.Rpt_ProSFDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uGridProBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid uGridProBarCode;
        private UpjdControlBox.PageChange pageChange;
        private UpjdControlBox.ToolStripGridFunction tsgfMain;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.Utils.ImageCollection ImgCollection16;
        private DevExpress.XtraBars.BarButtonItem biExport;
        private DevExpress.XtraBars.BarButtonItem biPreview;
        private DevExpress.XtraBars.BarButtonItem biDesign;
        private DevExpress.XtraBars.BarButtonItem biPrint;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.XtraBars.BarButtonItem biSearch;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.Utils.ImageCollection ImgCollection32;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSearch;
    }
}