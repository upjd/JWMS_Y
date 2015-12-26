namespace JWMSY
{
    partial class AboutVersion
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
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVersion
            // 
            this.txtVersion.BackColor = System.Drawing.Color.White;
            this.txtVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVersion.Location = new System.Drawing.Point(0, 0);
            this.txtVersion.Multiline = true;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(554, 302);
            this.txtVersion.TabIndex = 0;
            this.txtVersion.TabStop = false;
            this.txtVersion.Text = "2014-12-10\r\n1:主体功能完成并测试\r\n\r\n2015-03-01\r\n1:修改部分问题\r\n";
            // 
            // AboutVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 302);
            this.Controls.Add(this.txtVersion);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "AboutVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "版本说明";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVersion;
    }
}