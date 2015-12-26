namespace SetupService
{
    partial class frmMain
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.ofCodeSoft = new System.Windows.Forms.OpenFileDialog();
            this.txtCodeSoftPath = new System.Windows.Forms.TextBox();
            this.btnCodeSoft = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(85, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "开始检测";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ofCodeSoft
            // 
            this.ofCodeSoft.FileName = "openFileDialog1";
            // 
            // txtCodeSoftPath
            // 
            this.txtCodeSoftPath.Location = new System.Drawing.Point(13, 64);
            this.txtCodeSoftPath.Name = "txtCodeSoftPath";
            this.txtCodeSoftPath.Size = new System.Drawing.Size(208, 21);
            this.txtCodeSoftPath.TabIndex = 1;
            this.txtCodeSoftPath.Text = "C:\\Program Files\\CS6";
            // 
            // btnCodeSoft
            // 
            this.btnCodeSoft.Location = new System.Drawing.Point(227, 62);
            this.btnCodeSoft.Name = "btnCodeSoft";
            this.btnCodeSoft.Size = new System.Drawing.Size(45, 23);
            this.btnCodeSoft.TabIndex = 2;
            this.btnCodeSoft.Text = "NG";
            this.btnCodeSoft.UseVisualStyleBackColor = true;
            this.btnCodeSoft.Click += new System.EventHandler(this.btnCodeSoft_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(182, 204);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "完成";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnCodeSoft);
            this.Controls.Add(this.txtCodeSoftPath);
            this.Controls.Add(this.btnCheck);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "安装环境检测";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.OpenFileDialog ofCodeSoft;
        private System.Windows.Forms.TextBox txtCodeSoftPath;
        private System.Windows.Forms.Button btnCodeSoft;
        private System.Windows.Forms.Button btnComplete;
    }
}

