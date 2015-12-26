namespace JWMSY
{
    partial class PdaGetIntQuantity
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtiNum = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblcInvCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcInvName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uteiWeight = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.spMain = new System.IO.Ports.SerialPort(this.components);
            this.lblRquantity = new System.Windows.Forms.Label();
            this.lblRemainQuantity = new System.Windows.Forms.Label();
            this.lblTheoryWeight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcBoxFormat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBoxNum = new System.Windows.Forms.Label();
            this.lblcLotNo = new System.Windows.Forms.TextBox();
            this.lblLotMgr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uteiWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(91, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "批号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "数量";
            // 
            // txtiNum
            // 
            this.txtiNum.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtiNum.Location = new System.Drawing.Point(199, 245);
            this.txtiNum.Name = "txtiNum";
            this.txtiNum.Size = new System.Drawing.Size(341, 47);
            this.txtiNum.TabIndex = 0;
            this.txtiNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiNum_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(546, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 45);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblcInvCode
            // 
            this.lblcInvCode.AutoSize = true;
            this.lblcInvCode.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcInvCode.Location = new System.Drawing.Point(199, 47);
            this.lblcInvCode.Name = "lblcInvCode";
            this.lblcInvCode.Size = new System.Drawing.Size(0, 35);
            this.lblcInvCode.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(91, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "编码";
            // 
            // lblcInvName
            // 
            this.lblcInvName.AutoSize = true;
            this.lblcInvName.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcInvName.Location = new System.Drawing.Point(199, 98);
            this.lblcInvName.Name = "lblcInvName";
            this.lblcInvName.Size = new System.Drawing.Size(0, 35);
            this.lblcInvName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(91, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(91, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "重量";
            // 
            // uteiWeight
            // 
            editorButton1.Text = "手动录入";
            editorButton1.Width = 160;
            this.uteiWeight.ButtonsRight.Add(editorButton1);
            this.uteiWeight.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uteiWeight.Location = new System.Drawing.Point(199, 296);
            this.uteiWeight.MaskInput = "nnnnnn.nn";
            this.uteiWeight.MaxValue = 10000;
            this.uteiWeight.MinValue = 0;
            this.uteiWeight.Name = "uteiWeight";
            this.uteiWeight.Nullable = true;
            this.uteiWeight.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Decimal;
            this.uteiWeight.Size = new System.Drawing.Size(341, 43);
            this.uteiWeight.TabIndex = 63;
            // 
            // spMain
            // 
            this.spMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spMain_DataReceived);
            // 
            // lblRquantity
            // 
            this.lblRquantity.AutoSize = true;
            this.lblRquantity.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRquantity.Location = new System.Drawing.Point(199, 200);
            this.lblRquantity.Name = "lblRquantity";
            this.lblRquantity.Size = new System.Drawing.Size(0, 35);
            this.lblRquantity.TabIndex = 64;
            // 
            // lblRemainQuantity
            // 
            this.lblRemainQuantity.AutoSize = true;
            this.lblRemainQuantity.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemainQuantity.Location = new System.Drawing.Point(56, 200);
            this.lblRemainQuantity.Name = "lblRemainQuantity";
            this.lblRemainQuantity.Size = new System.Drawing.Size(123, 35);
            this.lblRemainQuantity.TabIndex = 65;
            this.lblRemainQuantity.Text = "未拣量";
            // 
            // lblTheoryWeight
            // 
            this.lblTheoryWeight.AutoSize = true;
            this.lblTheoryWeight.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTheoryWeight.Location = new System.Drawing.Point(560, 200);
            this.lblTheoryWeight.Name = "lblTheoryWeight";
            this.lblTheoryWeight.Size = new System.Drawing.Size(0, 35);
            this.lblTheoryWeight.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(381, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 35);
            this.label7.TabIndex = 67;
            this.label7.Text = "理论重量";
            // 
            // lblcBoxFormat
            // 
            this.lblcBoxFormat.AutoSize = true;
            this.lblcBoxFormat.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcBoxFormat.Location = new System.Drawing.Point(560, 149);
            this.lblcBoxFormat.Name = "lblcBoxFormat";
            this.lblcBoxFormat.Size = new System.Drawing.Size(0, 35);
            this.lblcBoxFormat.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(453, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 35);
            this.label8.TabIndex = 69;
            this.label8.Text = "箱规";
            // 
            // lblBoxNum
            // 
            this.lblBoxNum.AutoSize = true;
            this.lblBoxNum.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBoxNum.Location = new System.Drawing.Point(560, 251);
            this.lblBoxNum.Name = "lblBoxNum";
            this.lblBoxNum.Size = new System.Drawing.Size(0, 35);
            this.lblBoxNum.TabIndex = 70;
            // 
            // lblcLotNo
            // 
            this.lblcLotNo.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblcLotNo.Location = new System.Drawing.Point(184, 143);
            this.lblcLotNo.Name = "lblcLotNo";
            this.lblcLotNo.Size = new System.Drawing.Size(263, 47);
            this.lblcLotNo.TabIndex = 71;
            this.lblcLotNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblcLotNo_KeyDown);
            // 
            // lblLotMgr
            // 
            this.lblLotMgr.AutoSize = true;
            this.lblLotMgr.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblLotMgr.ForeColor = System.Drawing.Color.Red;
            this.lblLotMgr.Location = new System.Drawing.Point(569, 9);
            this.lblLotMgr.Name = "lblLotMgr";
            this.lblLotMgr.Size = new System.Drawing.Size(0, 35);
            this.lblLotMgr.TabIndex = 72;
            // 
            // PdaGetIntQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 389);
            this.Controls.Add(this.lblLotMgr);
            this.Controls.Add(this.lblcLotNo);
            this.Controls.Add(this.lblBoxNum);
            this.Controls.Add(this.lblcBoxFormat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTheoryWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRquantity);
            this.Controls.Add(this.lblRemainQuantity);
            this.Controls.Add(this.uteiWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcInvName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcInvCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtiNum);
            this.Controls.Add(this.btnSubmit);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PdaGetIntQuantity";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "请输入数量";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PdaGetIntQuantity_FormClosing);
            this.Load += new System.EventHandler(this.PdaGetQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uteiWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtiNum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblcInvCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcInvName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uteiWeight;
        private System.IO.Ports.SerialPort spMain;
        private System.Windows.Forms.Label lblRquantity;
        private System.Windows.Forms.Label lblRemainQuantity;
        private System.Windows.Forms.Label lblTheoryWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcBoxFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBoxNum;
        private System.Windows.Forms.TextBox lblcLotNo;
        private System.Windows.Forms.Label lblLotMgr;
    }
}