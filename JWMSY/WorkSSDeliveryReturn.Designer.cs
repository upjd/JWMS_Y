namespace JWMSY
{
    partial class WorkSSDeliveryReturn
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("SS_DeliveryReturn", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AutoID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cOrderNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cLotNo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cOrgOrderNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cCusName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iQuantity");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMemo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dAddTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cOperator");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            this.ugbxMain = new Infragistics.Win.Misc.UltraGroupBox();
            this.cbxWarehouse = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.txtcCusName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcMemo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcOrgOrderNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uteiQuantity = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtcInvName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcInvCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcLotNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbxReturnHistory = new System.Windows.Forms.ToolStripComboBox();
            this.lblcOrderNumber = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtcOrderNumber = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtcBarCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uGridSsDelivery = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.sSDeliveryReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataProductMain = new JWMSY.DLL.DataProductMain();
            this.sS_DeliveryReturnTableAdapter = new JWMSY.DLL.DataProductMainTableAdapters.SS_DeliveryReturnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ugbxMain)).BeginInit();
            this.ugbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uteiQuantity)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridSsDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSDeliveryReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ugbxMain
            // 
            this.ugbxMain.Controls.Add(this.cbxWarehouse);
            this.ugbxMain.Controls.Add(this.txtcCusName);
            this.ugbxMain.Controls.Add(this.label8);
            this.ugbxMain.Controls.Add(this.txtcMemo);
            this.ugbxMain.Controls.Add(this.label7);
            this.ugbxMain.Controls.Add(this.txtcOrgOrderNumber);
            this.ugbxMain.Controls.Add(this.label6);
            this.ugbxMain.Controls.Add(this.uteiQuantity);
            this.ugbxMain.Controls.Add(this.btnAdd);
            this.ugbxMain.Controls.Add(this.txtcInvName);
            this.ugbxMain.Controls.Add(this.label5);
            this.ugbxMain.Controls.Add(this.txtcInvCode);
            this.ugbxMain.Controls.Add(this.label4);
            this.ugbxMain.Controls.Add(this.label3);
            this.ugbxMain.Controls.Add(this.txtcLotNo);
            this.ugbxMain.Controls.Add(this.label1);
            this.ugbxMain.Controls.Add(this.toolStrip1);
            this.ugbxMain.Controls.Add(this.txtcBarCode);
            this.ugbxMain.Controls.Add(this.label2);
            this.ugbxMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ugbxMain.Location = new System.Drawing.Point(0, 0);
            this.ugbxMain.Name = "ugbxMain";
            this.ugbxMain.Size = new System.Drawing.Size(984, 215);
            this.ugbxMain.TabIndex = 18;
            // 
            // cbxWarehouse
            // 
            this.cbxWarehouse.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cbxWarehouse.Location = new System.Drawing.Point(12, 39);
            this.cbxWarehouse.Name = "cbxWarehouse";
            this.cbxWarehouse.Size = new System.Drawing.Size(135, 21);
            this.cbxWarehouse.TabIndex = 74;
            // 
            // txtcCusName
            // 
            this.txtcCusName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcCusName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtcCusName.Location = new System.Drawing.Point(172, 177);
            this.txtcCusName.Name = "txtcCusName";
            this.txtcCusName.Size = new System.Drawing.Size(181, 26);
            this.txtcCusName.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(126, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "客户";
            // 
            // txtcMemo
            // 
            this.txtcMemo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcMemo.Location = new System.Drawing.Point(435, 179);
            this.txtcMemo.Name = "txtcMemo";
            this.txtcMemo.Size = new System.Drawing.Size(456, 26);
            this.txtcMemo.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(391, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "备注";
            // 
            // txtcOrgOrderNumber
            // 
            this.txtcOrgOrderNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcOrgOrderNumber.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtcOrgOrderNumber.Location = new System.Drawing.Point(713, 139);
            this.txtcOrgOrderNumber.Name = "txtcOrgOrderNumber";
            this.txtcOrgOrderNumber.ReadOnly = true;
            this.txtcOrgOrderNumber.Size = new System.Drawing.Size(178, 26);
            this.txtcOrgOrderNumber.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(637, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "原序列号";
            // 
            // uteiQuantity
            // 
            this.uteiQuantity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uteiQuantity.ImeMode = System.Windows.Forms.ImeMode.On;
            this.uteiQuantity.Location = new System.Drawing.Point(435, 140);
            this.uteiQuantity.MaskInput = "nnnnnn";
            this.uteiQuantity.MaxValue = 10000;
            this.uteiQuantity.MinValue = 1;
            this.uteiQuantity.Name = "uteiQuantity";
            this.uteiQuantity.Nullable = true;
            this.uteiQuantity.Size = new System.Drawing.Size(177, 25);
            this.uteiQuantity.TabIndex = 64;
            this.uteiQuantity.Value = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(708, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtcInvName
            // 
            this.txtcInvName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcInvName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtcInvName.Location = new System.Drawing.Point(435, 101);
            this.txtcInvName.Name = "txtcInvName";
            this.txtcInvName.ReadOnly = true;
            this.txtcInvName.Size = new System.Drawing.Size(456, 26);
            this.txtcInvName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(359, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "产品名称";
            // 
            // txtcInvCode
            // 
            this.txtcInvCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcInvCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtcInvCode.Location = new System.Drawing.Point(172, 101);
            this.txtcInvCode.Name = "txtcInvCode";
            this.txtcInvCode.ReadOnly = true;
            this.txtcInvCode.Size = new System.Drawing.Size(181, 26);
            this.txtcInvCode.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(94, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "产品编码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(391, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "数量";
            // 
            // txtcLotNo
            // 
            this.txtcLotNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcLotNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtcLotNo.Location = new System.Drawing.Point(172, 144);
            this.txtcLotNo.Name = "txtcLotNo";
            this.txtcLotNo.Size = new System.Drawing.Size(181, 26);
            this.txtcLotNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(126, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "批号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::JWMSY.Properties.Resources.toolbarBk;
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit,
            this.toolStripSeparator1,
            this.tsbtnAdd,
            this.tsbtnSave,
            this.toolStripLabel1,
            this.tscbxReturnHistory,
            this.lblcOrderNumber,
            this.toolStripLabel2,
            this.txtcOrderNumber,
            this.tsbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = global::JWMSY.Properties.Resources.exit;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(60, 22);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = global::JWMSY.Properties.Resources.addtsk_tsk;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(60, 22);
            this.tsbtnAdd.Text = "新增";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = global::JWMSY.Properties.Resources.savegif;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(60, 22);
            this.tsbtnSave.Text = "保存";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(160, 22);
            this.toolStripLabel1.Text = "最近100个收货单记录";
            // 
            // tscbxReturnHistory
            // 
            this.tscbxReturnHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxReturnHistory.Name = "tscbxReturnHistory";
            this.tscbxReturnHistory.Size = new System.Drawing.Size(200, 25);
            this.tscbxReturnHistory.SelectedIndexChanged += new System.EventHandler(this.tscbxReturnHistory_SelectedIndexChanged);
            // 
            // lblcOrderNumber
            // 
            this.lblcOrderNumber.Name = "lblcOrderNumber";
            this.lblcOrderNumber.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel2.Text = "输入退货单号";
            // 
            // txtcOrderNumber
            // 
            this.txtcOrderNumber.Name = "txtcOrderNumber";
            this.txtcOrderNumber.Size = new System.Drawing.Size(150, 25);
            // 
            // tsbtnQuery
            // 
            this.tsbtnQuery.Image = global::JWMSY.Properties.Resources.query;
            this.tsbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuery.Name = "tsbtnQuery";
            this.tsbtnQuery.Size = new System.Drawing.Size(60, 22);
            this.tsbtnQuery.Text = "查询";
            this.tsbtnQuery.Click += new System.EventHandler(this.tsbtnQuery_Click);
            // 
            // txtcBarCode
            // 
            this.txtcBarCode.Enabled = false;
            this.txtcBarCode.Font = new System.Drawing.Font("宋体", 18F);
            this.txtcBarCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtcBarCode.Location = new System.Drawing.Point(232, 52);
            this.txtcBarCode.Name = "txtcBarCode";
            this.txtcBarCode.Size = new System.Drawing.Size(459, 35);
            this.txtcBarCode.TabIndex = 2;
            this.txtcBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcBarCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(154, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "扫描区：";
            // 
            // uGridSsDelivery
            // 
            this.uGridSsDelivery.DataSource = this.sSDeliveryReturnBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridSsDelivery.DisplayLayout.Appearance = appearance1;
            ultraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn23.Header.VisiblePosition = 0;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn40.Header.Caption = "单据号";
            ultraGridColumn40.Header.VisiblePosition = 1;
            ultraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn31.Header.Caption = "产品编码";
            ultraGridColumn31.Header.VisiblePosition = 2;
            ultraGridColumn31.Width = 81;
            ultraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn32.Header.Caption = "产品名称";
            ultraGridColumn32.Header.VisiblePosition = 5;
            ultraGridColumn32.Width = 255;
            ultraGridColumn1.Header.Caption = "批号";
            ultraGridColumn1.Header.VisiblePosition = 3;
            ultraGridColumn2.Header.Caption = "原序列号";
            ultraGridColumn2.Header.VisiblePosition = 6;
            ultraGridColumn43.Header.Caption = "客户名称";
            ultraGridColumn43.Header.VisiblePosition = 7;
            ultraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn29.Header.Caption = "数量";
            ultraGridColumn29.Header.VisiblePosition = 4;
            ultraGridColumn29.Width = 70;
            ultraGridColumn3.Header.Caption = "备注";
            ultraGridColumn3.Header.VisiblePosition = 8;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn4.Header.Caption = "添加时间";
            ultraGridColumn4.Header.VisiblePosition = 9;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn5.Header.Caption = "操作员";
            ultraGridColumn5.Header.VisiblePosition = 10;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn23,
            ultraGridColumn40,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn43,
            ultraGridColumn29,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            this.uGridSsDelivery.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridSsDelivery.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            this.uGridSsDelivery.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridSsDelivery.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridSsDelivery.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.uGridSsDelivery.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.uGridSsDelivery.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridSsDelivery.DisplayLayout.Override.CellPadding = 3;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.TextHAlignAsString = "Center";
            appearance3.TextVAlignAsString = "Middle";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridSsDelivery.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.uGridSsDelivery.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uGridSsDelivery.DisplayLayout.Override.RowAlternateAppearance = appearance4;
            appearance5.BorderColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Right";
            appearance5.TextVAlignAsString = "Middle";
            this.uGridSsDelivery.DisplayLayout.Override.RowAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridSsDelivery.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridSsDelivery.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance7;
            this.uGridSsDelivery.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridSsDelivery.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridSsDelivery.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridSsDelivery.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.Color.Black;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.uGridSsDelivery.DisplayLayout.Override.SelectedRowAppearance = appearance8;
            this.uGridSsDelivery.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridSsDelivery.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridSsDelivery.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridSsDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridSsDelivery.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridSsDelivery.Location = new System.Drawing.Point(0, 215);
            this.uGridSsDelivery.Name = "uGridSsDelivery";
            this.uGridSsDelivery.Size = new System.Drawing.Size(984, 347);
            this.uGridSsDelivery.TabIndex = 33;
            this.uGridSsDelivery.Text = "退货记录";
            this.uGridSsDelivery.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // sSDeliveryReturnBindingSource
            // 
            this.sSDeliveryReturnBindingSource.DataMember = "SS_DeliveryReturn";
            this.sSDeliveryReturnBindingSource.DataSource = this.dataProductMain;
            // 
            // dataProductMain
            // 
            this.dataProductMain.DataSetName = "DataProductMain";
            this.dataProductMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sS_DeliveryReturnTableAdapter
            // 
            this.sS_DeliveryReturnTableAdapter.ClearBeforeFill = true;
            // 
            // WorkSSDeliveryReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridSsDelivery);
            this.Controls.Add(this.ugbxMain);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "WorkSSDeliveryReturn";
            this.Text = "销售出库退货";
            this.Load += new System.EventHandler(this.WorkSSDeliveryReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ugbxMain)).EndInit();
            this.ugbxMain.ResumeLayout(false);
            this.ugbxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uteiQuantity)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridSsDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSDeliveryReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ugbxMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtcInvName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcInvCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcLotNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtcBarCode;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uteiQuantity;
        private System.Windows.Forms.TextBox txtcMemo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcOrgOrderNumber;
        private System.Windows.Forms.Label label6;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridSsDelivery;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.BindingSource sSDeliveryReturnBindingSource;
        private DLL.DataProductMain dataProductMain;
        private DLL.DataProductMainTableAdapters.SS_DeliveryReturnTableAdapter sS_DeliveryReturnTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscbxReturnHistory;
        private System.Windows.Forms.TextBox txtcCusName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripLabel lblcOrderNumber;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtcOrderNumber;
        private System.Windows.Forms.ToolStripButton tsbtnQuery;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cbxWarehouse;
    }
}