namespace JWMSY
{
    partial class Select_RawMaterial
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
            this.uGridRawMaterial = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tsgfMain = new UpjdControlBox.ToolStripGridFunction();
            ((System.ComponentModel.ISupportInitialize)(this.uGridRawMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // uGridRawMaterial
            // 
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
            this.uGridRawMaterial.Location = new System.Drawing.Point(0, 25);
            this.uGridRawMaterial.Name = "uGridRawMaterial";
            this.uGridRawMaterial.Size = new System.Drawing.Size(984, 537);
            this.uGridRawMaterial.TabIndex = 19;
            this.uGridRawMaterial.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // tsgfMain
            // 
            this.tsgfMain.Constr = null;
            this.tsgfMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsgfMain.FormId = null;
            this.tsgfMain.FormName = null;
            this.tsgfMain.Location = new System.Drawing.Point(0, 0);
            this.tsgfMain.Name = "tsgfMain";
            this.tsgfMain.Size = new System.Drawing.Size(984, 25);
            this.tsgfMain.TabIndex = 18;
            this.tsgfMain.UGrid = this.uGridRawMaterial;
            // 
            // Select_RawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.uGridRawMaterial);
            this.Controls.Add(this.tsgfMain);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "Select_RawMaterial";
            this.Text = "选择原料档案";
            this.Load += new System.EventHandler(this.Select_RawMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uGridRawMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid uGridRawMaterial;
        private UpjdControlBox.ToolStripGridFunction tsgfMain;
    }
}