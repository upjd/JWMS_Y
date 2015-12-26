namespace WMSM
{
    partial class BaseUser
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BUser", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uCode");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseUser));
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uPassword");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uRole");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dAddTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bEnable");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bOperator");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bSelect", 0);
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BRole", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dAddTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bEnable");
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            this.tsUser = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRoleManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.uGridUser = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.bUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDs = new WMSM.BaseDs();
            this.uSplitterRight = new Infragistics.Win.Misc.UltraSplitter();
            this.panelDT_USER = new System.Windows.Forms.Panel();
            this.uGridRole = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.bRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsRole = new System.Windows.Forms.ToolStrip();
            this.tsbRdelete = new System.Windows.Forms.ToolStripButton();
            this.tsbRsave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bUserTableAdapter = new WMSM.BaseDsTableAdapters.BUserTableAdapter();
            this.bRoleTableAdapter = new WMSM.BaseDsTableAdapters.BRoleTableAdapter();
            this.tsUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDs)).BeginInit();
            this.panelDT_USER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRoleBindingSource)).BeginInit();
            this.tsRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsUser
            // 
            this.tsUser.BackgroundImage = global::WMSM.Properties.Resources.toolbarBk;
            this.tsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator3,
            this.tsbDelete,
            this.tsbSave,
            this.tsbRefresh,
            this.toolStripSeparator7,
            this.tsbRoleManager,
            this.toolStripSeparator1,
            this.tsbtnPrint});
            this.tsUser.Location = new System.Drawing.Point(0, 0);
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(984, 25);
            this.tsUser.TabIndex = 4;
            this.tsUser.Text = "toolStrip2";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::WMSM.Properties.Resources.exit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(52, 22);
            this.tsbExit.Text = "退出";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::WMSM.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::WMSM.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::WMSM.Properties.Resources.refresh1;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(52, 22);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRoleManager
            // 
            this.tsbRoleManager.Image = global::WMSM.Properties.Resources.role;
            this.tsbRoleManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoleManager.Name = "tsbRoleManager";
            this.tsbRoleManager.Size = new System.Drawing.Size(76, 22);
            this.tsbRoleManager.Text = "角色管理";
            this.tsbRoleManager.Click += new System.EventHandler(this.tsbRoleManager_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.Image = global::WMSM.Properties.Resources.print;
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(76, 22);
            this.tsbtnPrint.Text = "打印条码";
            this.tsbtnPrint.Click += new System.EventHandler(this.tsbtnPrint_Click);
            // 
            // uGridUser
            // 
            this.uGridUser.DataSource = this.bUserBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridUser.DisplayLayout.Appearance = appearance1;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            ultraGridColumn10.CellButtonAppearance = appearance2;
            ultraGridColumn10.Header.Caption = "用户编码";
            ultraGridColumn10.Header.VisiblePosition = 2;
            ultraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton;
            ultraGridColumn10.Width = 108;
            ultraGridColumn14.Header.Caption = "用户名称";
            ultraGridColumn14.Header.VisiblePosition = 3;
            ultraGridColumn14.Width = 215;
            ultraGridColumn15.DefaultCellValue = "a994daa0c4a76b6a4ef640d41777ec0a";
            ultraGridColumn15.Header.Caption = "密码MD5加密";
            ultraGridColumn15.Header.VisiblePosition = 4;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.Header.Caption = "角色";
            ultraGridColumn16.Header.VisiblePosition = 5;
            ultraGridColumn16.Width = 125;
            ultraGridColumn20.Header.VisiblePosition = 6;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn21.Header.VisiblePosition = 7;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn22.Header.VisiblePosition = 8;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn1.DataType = typeof(bool);
            ultraGridColumn1.DefaultCellValue = false;
            ultraGridColumn1.Header.Caption = "选择";
            ultraGridColumn1.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ultraGridColumn1.Width = 60;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn1});
            this.uGridUser.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridUser.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridUser.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridUser.DisplayLayout.MaxRowScrollRegions = 1;
            this.uGridUser.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.FixedAddRowOnBottom;
            this.uGridUser.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.uGridUser.DisplayLayout.Override.CardAreaAppearance = appearance3;
            this.uGridUser.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridUser.DisplayLayout.Override.CellPadding = 3;
            this.uGridUser.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains;
            this.uGridUser.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance4.TextHAlignAsString = "Center";
            appearance4.TextVAlignAsString = "Middle";
            appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridUser.DisplayLayout.Override.HeaderAppearance = appearance4;
            this.uGridUser.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance5.BorderColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Right";
            appearance5.TextVAlignAsString = "Middle";
            this.uGridUser.DisplayLayout.Override.RowAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridUser.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridUser.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance7;
            this.uGridUser.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridUser.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridUser.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridUser.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.Color.Black;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.uGridUser.DisplayLayout.Override.SelectedRowAppearance = appearance8;
            this.uGridUser.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridUser.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridUser.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridUser.Location = new System.Drawing.Point(0, 25);
            this.uGridUser.Name = "uGridUser";
            this.uGridUser.Size = new System.Drawing.Size(736, 536);
            this.uGridUser.TabIndex = 5;
            this.uGridUser.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            this.uGridUser.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.uGridUser_ClickCellButton);
            // 
            // bUserBindingSource
            // 
            this.bUserBindingSource.DataMember = "BUser";
            this.bUserBindingSource.DataSource = this.baseDs;
            // 
            // baseDs
            // 
            this.baseDs.DataSetName = "BaseDs";
            this.baseDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSplitterRight
            // 
            this.uSplitterRight.BackColor = System.Drawing.Color.White;
            this.uSplitterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.uSplitterRight.Location = new System.Drawing.Point(730, 25);
            this.uSplitterRight.Name = "uSplitterRight";
            this.uSplitterRight.RestoreExtent = 223;
            this.uSplitterRight.Size = new System.Drawing.Size(6, 536);
            this.uSplitterRight.TabIndex = 6;
            // 
            // panelDT_USER
            // 
            this.panelDT_USER.Controls.Add(this.uGridRole);
            this.panelDT_USER.Controls.Add(this.tsRole);
            this.panelDT_USER.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDT_USER.Location = new System.Drawing.Point(736, 25);
            this.panelDT_USER.Name = "panelDT_USER";
            this.panelDT_USER.Size = new System.Drawing.Size(248, 536);
            this.panelDT_USER.TabIndex = 7;
            // 
            // uGridRole
            // 
            this.uGridRole.DataSource = this.bRoleBindingSource;
            appearance9.BackColor = System.Drawing.Color.White;
            this.uGridRole.DisplayLayout.Appearance = appearance9;
            ultraGridColumn23.Header.VisiblePosition = 0;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn24.Header.Caption = "角色号";
            ultraGridColumn24.Header.VisiblePosition = 1;
            ultraGridColumn24.Width = 71;
            ultraGridColumn25.Header.Caption = "角色名";
            ultraGridColumn25.Header.VisiblePosition = 2;
            ultraGridColumn25.Width = 132;
            ultraGridColumn26.Header.VisiblePosition = 3;
            ultraGridColumn27.Header.VisiblePosition = 4;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27});
            this.uGridRole.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.uGridRole.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridRole.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridRole.DisplayLayout.MaxRowScrollRegions = 1;
            this.uGridRole.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            appearance10.BackColor = System.Drawing.Color.Transparent;
            this.uGridRole.DisplayLayout.Override.CardAreaAppearance = appearance10;
            this.uGridRole.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridRole.DisplayLayout.Override.CellPadding = 3;
            appearance11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance11.TextHAlignAsString = "Center";
            appearance11.TextVAlignAsString = "Middle";
            appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridRole.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.uGridRole.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance12.BorderColor = System.Drawing.Color.Black;
            appearance12.TextHAlignAsString = "Right";
            appearance12.TextVAlignAsString = "Middle";
            this.uGridRole.DisplayLayout.Override.RowAppearance = appearance12;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridRole.DisplayLayout.Override.RowSelectorAppearance = appearance13;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridRole.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance14;
            this.uGridRole.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridRole.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridRole.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridRole.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance15.BorderColor = System.Drawing.Color.Black;
            appearance15.ForeColor = System.Drawing.Color.Black;
            this.uGridRole.DisplayLayout.Override.SelectedRowAppearance = appearance15;
            this.uGridRole.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridRole.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridRole.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridRole.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridRole.Location = new System.Drawing.Point(0, 25);
            this.uGridRole.Name = "uGridRole";
            this.uGridRole.Size = new System.Drawing.Size(248, 511);
            this.uGridRole.TabIndex = 5;
            this.uGridRole.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // bRoleBindingSource
            // 
            this.bRoleBindingSource.DataMember = "BRole";
            this.bRoleBindingSource.DataSource = this.baseDs;
            // 
            // tsRole
            // 
            this.tsRole.BackgroundImage = global::WMSM.Properties.Resources.toolbarBk;
            this.tsRole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRdelete,
            this.tsbRsave,
            this.toolStripButton4,
            this.toolStripSeparator2});
            this.tsRole.Location = new System.Drawing.Point(0, 0);
            this.tsRole.Name = "tsRole";
            this.tsRole.Size = new System.Drawing.Size(248, 25);
            this.tsRole.TabIndex = 4;
            this.tsRole.Text = "toolStrip2";
            // 
            // tsbRdelete
            // 
            this.tsbRdelete.Image = global::WMSM.Properties.Resources.delete;
            this.tsbRdelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRdelete.Name = "tsbRdelete";
            this.tsbRdelete.Size = new System.Drawing.Size(52, 22);
            this.tsbRdelete.Text = "删除";
            this.tsbRdelete.Click += new System.EventHandler(this.tsbRdelete_Click);
            // 
            // tsbRsave
            // 
            this.tsbRsave.Image = global::WMSM.Properties.Resources.save;
            this.tsbRsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRsave.Name = "tsbRsave";
            this.tsbRsave.Size = new System.Drawing.Size(52, 22);
            this.tsbRsave.Text = "保存";
            this.tsbRsave.Click += new System.EventHandler(this.tsbRsave_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::WMSM.Properties.Resources.refresh1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton4.Text = "刷新";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bUserTableAdapter
            // 
            this.bUserTableAdapter.ClearBeforeFill = true;
            // 
            // bRoleTableAdapter
            // 
            this.bRoleTableAdapter.ClearBeforeFill = true;
            // 
            // BaseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.uSplitterRight);
            this.Controls.Add(this.uGridUser);
            this.Controls.Add(this.panelDT_USER);
            this.Controls.Add(this.tsUser);
            this.Icon = global::WMSM.Properties.Resources.Mine;
            this.Name = "BaseUser";
            this.Text = "用户管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseUser_FormClosing);
            this.Load += new System.EventHandler(this.BaseUser_Load);
            this.tsUser.ResumeLayout(false);
            this.tsUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDs)).EndInit();
            this.panelDT_USER.ResumeLayout(false);
            this.panelDT_USER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRoleBindingSource)).EndInit();
            this.tsRole.ResumeLayout(false);
            this.tsRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsUser;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbRoleManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridUser;
        private Infragistics.Win.Misc.UltraSplitter uSplitterRight;
        private System.Windows.Forms.Panel panelDT_USER;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridRole;
        private System.Windows.Forms.ToolStrip tsRole;
        private System.Windows.Forms.ToolStripButton tsbRdelete;
        private System.Windows.Forms.ToolStripButton tsbRsave;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private BaseDs baseDs;
        private System.Windows.Forms.BindingSource bUserBindingSource;
        private BaseDsTableAdapters.BUserTableAdapter bUserTableAdapter;
        private System.Windows.Forms.BindingSource bRoleBindingSource;
        private BaseDsTableAdapters.BRoleTableAdapter bRoleTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbtnPrint;
    }
}