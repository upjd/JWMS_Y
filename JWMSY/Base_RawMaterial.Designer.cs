namespace JWMSY
{
    partial class Base_RawMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base_RawMaterial));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("IT_RawMaterial", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AutoID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvPackStd");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvStd");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvPackStyle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cDefaultVendor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMassUnit");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iMassDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cKeepRequire");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cAddress");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cProperty");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMemo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bEnable");
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
            this.biExport = new DevExpress.XtraBars.BarButtonItem();
            this.biSave = new DevExpress.XtraBars.BarButtonItem();
            this.biAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.biEdit = new DevExpress.XtraBars.BarButtonItem();
            this.biDelete = new DevExpress.XtraBars.BarButtonItem();
            this.biShowDisable = new DevExpress.XtraBars.BarButtonItem();
            this.ImgCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tsgfMain = new UpjdControlBox.ToolStripGridFunction();
            this.uGridRawMaterial = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.iTRawMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataInventory = new JWMSY.DLL.DataInventory();
            this.iT_RawMaterialTableAdapter = new JWMSY.DLL.DataInventoryTableAdapters.IT_RawMaterialTableAdapter();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridRawMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTRawMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).BeginInit();
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
            this.biSave,
            this.biAddNew,
            this.biExit,
            this.biEdit,
            this.biDelete,
            this.biShowDisable});
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
            // 
            // bsiPrint
            // 
            this.bsiPrint.Caption = "打印";
            this.bsiPrint.Id = 2;
            this.bsiPrint.LargeImageIndex = 7;
            this.bsiPrint.Name = "bsiPrint";
            this.bsiPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            // biAddNew
            // 
            this.biAddNew.Caption = "同步EAS";
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
            this.biExit.LargeImageIndex = 4;
            this.biExit.Name = "biExit";
            this.biExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biExit_ItemClick);
            // 
            // biEdit
            // 
            this.biEdit.Caption = "修改";
            this.biEdit.Id = 67;
            this.biEdit.LargeImageIndex = 2;
            this.biEdit.Name = "biEdit";
            this.biEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biEdit_ItemClick);
            // 
            // biDelete
            // 
            this.biDelete.Caption = "停用";
            this.biDelete.Id = 68;
            this.biDelete.LargeImageIndex = 9;
            this.biDelete.Name = "biDelete";
            this.biDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDelete_ItemClick);
            // 
            // biShowDisable
            // 
            this.biShowDisable.Caption = "显示停用档案";
            this.biShowDisable.Id = 69;
            this.biShowDisable.LargeImageIndex = 3;
            this.biShowDisable.Name = "biShowDisable";
            this.biShowDisable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.biShowDisable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biShowDisable_ItemClick);
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
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystem,
            this.rpgExport,
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
            // rpgExport
            // 
            this.rpgExport.ItemLinks.Add(this.biShowDisable);
            this.rpgExport.ItemLinks.Add(this.biExport);
            this.rpgExport.Name = "rpgExport";
            this.rpgExport.ShowCaptionButton = false;
            this.rpgExport.Text = "处理";
            // 
            // rpgNew
            // 
            this.rpgNew.ItemLinks.Add(this.biAddNew);
            this.rpgNew.ItemLinks.Add(this.biEdit);
            this.rpgNew.ItemLinks.Add(this.biSave);
            this.rpgNew.ItemLinks.Add(this.biDelete);
            this.rpgNew.Name = "rpgNew";
            this.rpgNew.ShowCaptionButton = false;
            this.rpgNew.Text = "操作";
            // 
            // tsgfMain
            // 
            this.tsgfMain.Constr = null;
            this.tsgfMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsgfMain.FormId = null;
            this.tsgfMain.FormName = null;
            this.tsgfMain.Location = new System.Drawing.Point(0, 121);
            this.tsgfMain.Name = "tsgfMain";
            this.tsgfMain.Size = new System.Drawing.Size(984, 25);
            this.tsgfMain.TabIndex = 16;
            this.tsgfMain.UGrid = this.uGridRawMaterial;
            this.tsgfMain.DoubleClick += new System.EventHandler(this.uGridRawMaterial_DoubleClick);
            // 
            // uGridRawMaterial
            // 
            this.uGridRawMaterial.DataSource = this.iTRawMaterialBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridRawMaterial.DisplayLayout.Appearance = appearance1;
            this.uGridRawMaterial.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn8.Header.Caption = "原料编码";
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn9.Header.Caption = "原料名称";
            ultraGridColumn9.Header.VisiblePosition = 2;
            ultraGridColumn10.Header.Caption = "包装规格";
            ultraGridColumn10.Header.VisiblePosition = 3;
            ultraGridColumn11.Header.Caption = "原料规格";
            ultraGridColumn11.Header.VisiblePosition = 4;
            ultraGridColumn12.Header.Caption = "包装形式";
            ultraGridColumn12.Header.VisiblePosition = 5;
            ultraGridColumn13.Header.Caption = "默认供应商";
            ultraGridColumn13.Header.VisiblePosition = 6;
            ultraGridColumn14.Header.Caption = "保质期单位";
            ultraGridColumn14.Header.VisiblePosition = 7;
            ultraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            ultraGridColumn15.Header.Caption = "保质期";
            ultraGridColumn15.Header.VisiblePosition = 8;
            ultraGridColumn16.Header.Caption = "贮存条件";
            ultraGridColumn16.Header.VisiblePosition = 9;
            ultraGridColumn17.Header.Caption = "产地";
            ultraGridColumn17.Header.VisiblePosition = 10;
            ultraGridColumn18.Header.Caption = "特性";
            ultraGridColumn18.Header.VisiblePosition = 11;
            ultraGridColumn19.Header.Caption = "备注";
            ultraGridColumn19.Header.VisiblePosition = 12;
            ultraGridColumn20.Header.VisiblePosition = 13;
            ultraGridColumn20.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20});
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
            this.uGridRawMaterial.Location = new System.Drawing.Point(0, 146);
            this.uGridRawMaterial.Name = "uGridRawMaterial";
            this.uGridRawMaterial.Size = new System.Drawing.Size(984, 416);
            this.uGridRawMaterial.TabIndex = 17;
            this.uGridRawMaterial.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            this.uGridRawMaterial.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.uGridRawMaterial_DoubleClickCell);
            // 
            // iTRawMaterialBindingSource
            // 
            this.iTRawMaterialBindingSource.DataMember = "IT_RawMaterial";
            this.iTRawMaterialBindingSource.DataSource = this.dataInventory;
            // 
            // dataInventory
            // 
            this.dataInventory.DataSetName = "DataInventory";
            this.dataInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iT_RawMaterialTableAdapter
            // 
            this.iT_RawMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbMain.Location = new System.Drawing.Point(0, 98);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(984, 23);
            this.pbMain.TabIndex = 19;
            // 
            // Base_RawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridRawMaterial);
            this.Controls.Add(this.tsgfMain);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.ribbon);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "Base_RawMaterial";
            this.Text = "原料档案维护";
            this.Load += new System.EventHandler(this.Base_RawMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGridRawMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTRawMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.Utils.ImageCollection ImgCollection16;
        private DevExpress.XtraBars.BarSubItem bsiPrint;
        private DevExpress.XtraBars.BarButtonItem biExport;
        private DevExpress.XtraBars.BarButtonItem biSave;
        private DevExpress.XtraBars.BarButtonItem biAddNew;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.XtraBars.BarButtonItem biEdit;
        private DevExpress.XtraBars.BarButtonItem biDelete;
        private DevExpress.XtraBars.BarButtonItem biShowDisable;
        private DevExpress.Utils.ImageCollection ImgCollection32;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNew;
        private UpjdControlBox.ToolStripGridFunction tsgfMain;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridRawMaterial;
        private System.Windows.Forms.BindingSource iTRawMaterialBindingSource;
        private DLL.DataInventory dataInventory;
        private DLL.DataInventoryTableAdapters.IT_RawMaterialTableAdapter iT_RawMaterialTableAdapter;
        private System.Windows.Forms.ProgressBar pbMain;
    }
}