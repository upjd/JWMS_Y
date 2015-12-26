namespace SPDA
{
    partial class SSReplaceBox
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
            this.mBc2 = new Symbol.Barcode2.Design.Barcode2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBoxOne = new System.Windows.Forms.Label();
            this.lblBoxTwo = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mBc2
            // 
            this.mBc2.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler(this.mBc2_OnScan);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.Text = "原箱编号:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.Text = "目标箱号:";
            // 
            // lblBoxOne
            // 
            this.lblBoxOne.Location = new System.Drawing.Point(108, 32);
            this.lblBoxOne.Name = "lblBoxOne";
            this.lblBoxOne.Size = new System.Drawing.Size(178, 20);
            // 
            // lblBoxTwo
            // 
            this.lblBoxTwo.Location = new System.Drawing.Point(107, 71);
            this.lblBoxTwo.Name = "lblBoxTwo";
            this.lblBoxTwo.Size = new System.Drawing.Size(178, 20);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnComplete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(204, 116);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(102, 25);
            this.btnComplete.TabIndex = 11;
            this.btnComplete.Text = "确定换箱";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(30, 116);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(102, 25);
            this.btnCancle.TabIndex = 12;
            this.btnCancle.Text = "取消";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // SSReplaceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 175);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblBoxTwo);
            this.Controls.Add(this.lblBoxOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SSReplaceBox";
            this.Text = "整箱调换";
            this.Load += new System.EventHandler(this.SSReplaceBox_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.SSReplaceBox_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private Symbol.Barcode2.Design.Barcode2 mBc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBoxOne;
        private System.Windows.Forms.Label lblBoxTwo;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancle;
    }
}