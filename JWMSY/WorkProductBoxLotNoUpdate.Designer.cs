namespace JWMSY
{
    partial class WorkProductBoxLotNoUpdate
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Bar_Product_Box_SerialNumber", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cSerialNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cLotNo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iQuantity");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dPackDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dMassDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvPackStd");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvStd");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cInvPackStyle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cDefaultVendor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMassUnit");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("iMassDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cKeepRequire");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cProperty");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cMemo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cGuid");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uGridProBoxBarCode = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tsgfMain = new UpjdControlBox.ToolStripGridFunction();
            this.pageChange = new UpjdControlBox.PageChange();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtStart = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtEnd = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtLotNo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridProBoxBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::JWMSY.Properties.Resources.toolbarBk;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstxtStart,
            this.toolStripLabel2,
            this.tstxtEnd,
            this.tsbtnQuery,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.tstxtLotNo,
            this.tsbtnUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uGridProBoxBarCode
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridProBoxBarCode.DisplayLayout.Appearance = appearance1;
            ultraGridColumn8.Header.Caption = "序列号";
            ultraGridColumn8.Header.VisiblePosition = 0;
            ultraGridColumn9.Header.Caption = "批号";
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridColumn10.Header.Caption = "数量";
            ultraGridColumn10.Header.VisiblePosition = 2;
            ultraGridColumn11.Header.Caption = "包装日期";
            ultraGridColumn11.Header.VisiblePosition = 3;
            ultraGridColumn12.Header.Caption = "失效日期";
            ultraGridColumn12.Header.VisiblePosition = 4;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn3.Header.Caption = "生产日期";
            ultraGridColumn3.Header.VisiblePosition = 5;
            ultraGridColumn13.Header.Caption = "产品名称";
            ultraGridColumn13.Header.VisiblePosition = 7;
            ultraGridColumn14.Header.Caption = "产品编码";
            ultraGridColumn14.Header.VisiblePosition = 9;
            ultraGridColumn15.Header.Caption = "包装规格";
            ultraGridColumn15.Header.VisiblePosition = 10;
            ultraGridColumn16.Header.Caption = "产品规格";
            ultraGridColumn16.Header.VisiblePosition = 11;
            ultraGridColumn17.Header.Caption = "包装形式";
            ultraGridColumn17.Header.VisiblePosition = 12;
            ultraGridColumn19.Header.Caption = "供应商";
            ultraGridColumn19.Header.VisiblePosition = 13;
            ultraGridColumn20.Header.Caption = "单位";
            ultraGridColumn20.Header.VisiblePosition = 14;
            ultraGridColumn21.Header.Caption = "保质期";
            ultraGridColumn21.Header.VisiblePosition = 15;
            ultraGridColumn22.Header.Caption = "贮存条件";
            ultraGridColumn22.Header.VisiblePosition = 16;
            ultraGridColumn23.Header.Caption = "特性";
            ultraGridColumn23.Header.VisiblePosition = 17;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn4.Header.Caption = "备注";
            ultraGridColumn4.Header.VisiblePosition = 6;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            ultraGridColumn5.Header.VisiblePosition = 8;
            ultraGridColumn5.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn3,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn4,
            ultraGridColumn5});
            this.uGridProBoxBarCode.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridProBoxBarCode.DisplayLayout.GroupByBox.Prompt = "如需按照某个列进行分类汇总请把列名拖动到此处";
            this.uGridProBoxBarCode.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridProBoxBarCode.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.uGridProBoxBarCode.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.uGridProBoxBarCode.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGridProBoxBarCode.DisplayLayout.Override.CellPadding = 3;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.TextHAlignAsString = "Center";
            appearance3.TextVAlignAsString = "Middle";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridProBoxBarCode.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.uGridProBoxBarCode.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uGridProBoxBarCode.DisplayLayout.Override.RowAlternateAppearance = appearance4;
            appearance5.BorderColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Right";
            appearance5.TextVAlignAsString = "Middle";
            this.uGridProBoxBarCode.DisplayLayout.Override.RowAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorHeaderAppearance = appearance7;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.uGridProBoxBarCode.DisplayLayout.Override.RowSelectorWidth = 40;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.Color.Black;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.uGridProBoxBarCode.DisplayLayout.Override.SelectedRowAppearance = appearance8;
            this.uGridProBoxBarCode.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.uGridProBoxBarCode.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridProBoxBarCode.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uGridProBoxBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uGridProBoxBarCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uGridProBoxBarCode.Location = new System.Drawing.Point(0, 50);
            this.uGridProBoxBarCode.Name = "uGridProBoxBarCode";
            this.uGridProBoxBarCode.Size = new System.Drawing.Size(930, 415);
            this.uGridProBoxBarCode.TabIndex = 29;
            this.uGridProBoxBarCode.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChangeOrLostFocus;
            // 
            // tsgfMain
            // 
            this.tsgfMain.Constr = null;
            this.tsgfMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsgfMain.FormId = null;
            this.tsgfMain.FormName = null;
            this.tsgfMain.Location = new System.Drawing.Point(0, 25);
            this.tsgfMain.Name = "tsgfMain";
            this.tsgfMain.Size = new System.Drawing.Size(930, 25);
            this.tsgfMain.TabIndex = 27;
            this.tsgfMain.UGrid = this.uGridProBoxBarCode;
            // 
            // pageChange
            // 
            this.pageChange.Constr = null;
            this.pageChange.CountPage = 0;
            this.pageChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageChange.FlName = "cSerialNumber";
            this.pageChange.Location = new System.Drawing.Point(0, 465);
            this.pageChange.Name = "pageChange";
            this.pageChange.PageIndex = 1;
            this.pageChange.PageSize = 100;
            this.pageChange.RecordCount = 0;
            this.pageChange.Size = new System.Drawing.Size(930, 27);
            this.pageChange.TabIndex = 28;
            this.pageChange.TableRecord = "View_Bar_Product_Box_SerialNumber";
            this.pageChange.UGrid = this.uGridProBoxBarCode;
            this.pageChange.WhereStr = null;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "开始序列号";
            // 
            // tstxtStart
            // 
            this.tstxtStart.Name = "tstxtStart";
            this.tstxtStart.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel2.Text = "结束序列号";
            // 
            // tstxtEnd
            // 
            this.tstxtEnd.Name = "tstxtEnd";
            this.tstxtEnd.Size = new System.Drawing.Size(150, 25);
            // 
            // tsbtnQuery
            // 
            this.tsbtnQuery.Image = global::JWMSY.Properties.Resources.query;
            this.tsbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuery.Name = "tsbtnQuery";
            this.tsbtnQuery.Size = new System.Drawing.Size(52, 22);
            this.tsbtnQuery.Text = "查询";
            this.tsbtnQuery.Click += new System.EventHandler(this.tsbtnQuery_Click);
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.Image = global::JWMSY.Properties.Resources.savegif;
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(76, 22);
            this.tsbtnUpdate.Text = "执行更新";
            this.tsbtnUpdate.Click += new System.EventHandler(this.tsbtnUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstxtLotNo
            // 
            this.tstxtLotNo.Name = "tstxtLotNo";
            this.tstxtLotNo.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel3.Text = "指定批号";
            // 
            // WorkProductBoxLotNoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 492);
            this.Controls.Add(this.uGridProBoxBarCode);
            this.Controls.Add(this.tsgfMain);
            this.Controls.Add(this.pageChange);
            this.Controls.Add(this.toolStrip1);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "WorkProductBoxLotNoUpdate";
            this.Text = "按范围更新委外-周转箱批号";
            this.Load += new System.EventHandler(this.WorkProductBoxLotNoUpdate_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridProBoxBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstxtEnd;
        private System.Windows.Forms.ToolStripButton tsbtnQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridProBoxBarCode;
        private UpjdControlBox.ToolStripGridFunction tsgfMain;
        private UpjdControlBox.PageChange pageChange;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tstxtLotNo;
    }
}