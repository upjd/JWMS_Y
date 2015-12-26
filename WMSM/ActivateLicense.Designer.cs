namespace WMSM
{
    partial class ActivateLicense
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
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtActionInfo = new System.Windows.Forms.TextBox();
            this.btnChannel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActivate
            // 
            this.btnActivate.Enabled = false;
            this.btnActivate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnActivate.Location = new System.Drawing.Point(186, 236);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(122, 37);
            this.btnActivate.TabIndex = 0;
            this.btnActivate.Text = "激活";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(53, 90);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(378, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // txtActionInfo
            // 
            this.txtActionInfo.Location = new System.Drawing.Point(53, 132);
            this.txtActionInfo.Multiline = true;
            this.txtActionInfo.Name = "txtActionInfo";
            this.txtActionInfo.ReadOnly = true;
            this.txtActionInfo.Size = new System.Drawing.Size(378, 98);
            this.txtActionInfo.TabIndex = 1;
            // 
            // btnChannel
            // 
            this.btnChannel.Location = new System.Drawing.Point(437, 88);
            this.btnChannel.Name = "btnChannel";
            this.btnChannel.Size = new System.Drawing.Size(108, 23);
            this.btnChannel.TabIndex = 0;
            this.btnChannel.Text = "导入许可文件";
            this.btnChannel.UseVisualStyleBackColor = true;
            this.btnChannel.Click += new System.EventHandler(this.btnChannel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 75);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(141, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "激活在线人数许可";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "xml文件|*.xml";
            // 
            // ActivateLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtActionInfo);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnChannel);
            this.Controls.Add(this.btnActivate);
            this.Name = "ActivateLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "激活许可界面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtActionInfo;
        private System.Windows.Forms.Button btnChannel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}