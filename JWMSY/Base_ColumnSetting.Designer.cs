namespace JWMSY
{
    partial class Base_ColumnSetting
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ColumnSeting", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cFormID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cFormName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cKey");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCaption");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iVisualPosition");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bHide");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iWidth");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base_ColumnSetting));
            this.tsgfMain = new UpjdControlBox.ToolStripGridFunction();
            this.uGridRawMaterial = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.rpgNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bsiPrint = new DevExpress.XtraBars.BarSubItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.biExport = new DevExpress.XtraBars.BarButtonItem();
            this.biSave = new DevExpress.XtraBars.BarButtonItem();
            this.biEdit = new DevExpress.XtraBars.BarButtonItem();
            this.biDelete = new DevExpress.XtraBars.BarButtonItem();
            this.biGiveup = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataInventory = new JWMSY.DLL.DataInventory();
            this.columnSetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.columnSetingTableAdapter = new JWMSY.DLL.DataInventoryTableAdapters.ColumnSetingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uGridRawMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnSetingBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tsgfMain.TabIndex = 16;
            this.tsgfMain.UGrid = this.uGridRawMaterial;
            // 
            // uGridRawMaterial
            // 
            this.uGridRawMaterial.DataSource = this.columnSetingBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridRawMaterial.DisplayLayout.Appearance = appearance1;
            this.uGridRawMaterial.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn3.Header.Caption = "窗体名称";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 231;
            ultraGridColumn4.Header.Caption = "列索引";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 189;
            ultraGridColumn5.Header.Caption = "列标题";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 309;
            ultraGridColumn6.Header.Caption = "显示位置";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.Header.Caption = "是否隐藏";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn8.Header.Caption = "宽度";
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            this.uGridRawMaterial.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridRawMaterial.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridRawMaterial.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridRawMaterial.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.uGridRawMaterial.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.uGridRawMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridRawMaterial.DisplayLayout.Override.CellPadding = 3;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.TextHAlignAsString = "Center";
            appearance3.TextVAlignAsString = "Middle";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridRawMaterial.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.uGridRawMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uGridRawMaterial.DisplayLayout.Override.RowAlternateAppearance = appearance4;
            appearance5.BorderColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Right";
            appearance5.TextVAlignAsString = "Middle";
            this.uGridRawMaterial.DisplayLayout.Override.RowAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridRawMaterial.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridRawMaterial.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance7;
            this.uGridRawMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridRawMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridRawMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridRawMaterial.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.Color.Black;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.uGridRawMaterial.DisplayLayout.Override.SelectedRowAppearance = appearance8;
            this.uGridRawMaterial.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridRawMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridRawMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridRawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridRawMaterial.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridRawMaterial.Location = new System.Drawing.Point(0, 123);
            this.uGridRawMaterial.Name = "uGridRawMaterial";
            this.uGridRawMaterial.Size = new System.Drawing.Size(984, 439);
            this.uGridRawMaterial.TabIndex = 17;
            this.uGridRawMaterial.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // rpgNew
            // 
            this.rpgNew.Name = "rpgNew";
            this.rpgNew.ShowCaptionButton = false;
            this.rpgNew.Text = "操作";
            // 
            // bsiPrint
            // 
            this.bsiPrint.Caption = "打印";
            this.bsiPrint.Id = 2;
            this.bsiPrint.LargeImageIndex = 7;
            this.bsiPrint.Name = "bsiPrint";
            this.bsiPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Images = this.imageCollection1;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.biExport,
            this.biSave,
            this.biEdit,
            this.biDelete,
            this.biGiveup,
            this.biExit});
            this.ribbon.LargeImages = this.imageCollection2;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 65;
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
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertImage(global::JWMSY.Properties.Resources.design, "design", typeof(global::JWMSY.Properties.Resources), 0);
            this.imageCollection1.Images.SetKeyName(0, "design");
            this.imageCollection1.InsertImage(global::JWMSY.Properties.Resources.preview, "preview", typeof(global::JWMSY.Properties.Resources), 1);
            this.imageCollection1.Images.SetKeyName(1, "preview");
            this.imageCollection1.InsertImage(global::JWMSY.Properties.Resources.print, "print", typeof(global::JWMSY.Properties.Resources), 2);
            this.imageCollection1.Images.SetKeyName(2, "print");
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
            // biSave
            // 
            this.biSave.Caption = "保存";
            this.biSave.Enabled = false;
            this.biSave.Id = 46;
            this.biSave.LargeImageIndex = 8;
            this.biSave.Name = "biSave";
            this.biSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSave_ItemClick);
            // 
            // biEdit
            // 
            this.biEdit.Caption = "修改";
            this.biEdit.Id = 59;
            this.biEdit.LargeImageIndex = 2;
            this.biEdit.Name = "biEdit";
            this.biEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biEdit_ItemClick);
            // 
            // biDelete
            // 
            this.biDelete.Caption = "删除";
            this.biDelete.Id = 60;
            this.biDelete.ImageIndex = 4;
            this.biDelete.LargeImageIndex = 0;
            this.biDelete.Name = "biDelete";
            this.biDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDelete_ItemClick);
            // 
            // biGiveup
            // 
            this.biGiveup.Caption = "放弃";
            this.biGiveup.Id = 61;
            this.biGiveup.ImageIndex = 8;
            this.biGiveup.LargeImageIndex = 6;
            this.biGiveup.Name = "biGiveup";
            this.biGiveup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biGiveup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biGiveup_ItemClick);
            // 
            // biExit
            // 
            this.biExit.Caption = "退出";
            this.biExit.Id = 62;
            this.biExit.LargeImageIndex = 4;
            this.biExit.Name = "biExit";
            this.biExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biExit_ItemClick);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.abandon, "abandon", typeof(global::JWMSY.Properties.Resources), 0);
            this.imageCollection2.Images.SetKeyName(0, "abandon");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.add, "add", typeof(global::JWMSY.Properties.Resources), 1);
            this.imageCollection2.Images.SetKeyName(1, "add");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.edit, "edit", typeof(global::JWMSY.Properties.Resources), 2);
            this.imageCollection2.Images.SetKeyName(2, "edit");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.examin, "examin", typeof(global::JWMSY.Properties.Resources), 3);
            this.imageCollection2.Images.SetKeyName(3, "examin");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.exit, "exit", typeof(global::JWMSY.Properties.Resources), 4);
            this.imageCollection2.Images.SetKeyName(4, "exit");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.ExportDialog, "ExportDialog", typeof(global::JWMSY.Properties.Resources), 5);
            this.imageCollection2.Images.SetKeyName(5, "ExportDialog");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.giveup, "giveup", typeof(global::JWMSY.Properties.Resources), 6);
            this.imageCollection2.Images.SetKeyName(6, "giveup");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.printDialog, "printDialog", typeof(global::JWMSY.Properties.Resources), 7);
            this.imageCollection2.Images.SetKeyName(7, "printDialog");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.save, "save", typeof(global::JWMSY.Properties.Resources), 8);
            this.imageCollection2.Images.SetKeyName(8, "save");
            this.imageCollection2.InsertImage(global::JWMSY.Properties.Resources.delete1, "delete1", typeof(global::JWMSY.Properties.Resources), 9);
            this.imageCollection2.Images.SetKeyName(9, "delete1");
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystem,
            this.rpgExport,
            this.ribbonPageGroup1});
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
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.biEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.biDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.biGiveup);
            this.ribbonPageGroup1.ItemLinks.Add(this.biSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "操作";
            // 
            // dataInventory
            // 
            this.dataInventory.DataSetName = "DataInventory";
            this.dataInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // columnSetingBindingSource
            // 
            this.columnSetingBindingSource.DataMember = "ColumnSeting";
            this.columnSetingBindingSource.DataSource = this.dataInventory;
            // 
            // columnSetingTableAdapter
            // 
            this.columnSetingTableAdapter.ClearBeforeFill = true;
            // 
            // Base_ColumnSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridRawMaterial);
            this.Controls.Add(this.tsgfMain);
            this.Controls.Add(this.ribbon);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "Base_ColumnSetting";
            this.Text = "表格样式维护";
            this.Load += new System.EventHandler(this.Base_RawMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uGridRawMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnSetingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UpjdControlBox.ToolStripGridFunction tsgfMain;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridRawMaterial;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNew;
        private DevExpress.XtraBars.BarSubItem bsiPrint;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem biExport;
        private DevExpress.XtraBars.BarButtonItem biSave;
        private DevExpress.XtraBars.BarButtonItem biEdit;
        private DevExpress.XtraBars.BarButtonItem biDelete;
        private DevExpress.XtraBars.BarButtonItem biGiveup;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DLL.DataInventory dataInventory;
        private System.Windows.Forms.BindingSource columnSetingBindingSource;
        private DLL.DataInventoryTableAdapters.ColumnSetingTableAdapter columnSetingTableAdapter;
    }
}