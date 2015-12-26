namespace JWMSY
{
    partial class WorkSSReplaceBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcOrgBoxNumber = new System.Windows.Forms.TextBox();
            this.txtcNewBoxNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原箱号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新箱号";
            // 
            // txtcOrgBoxNumber
            // 
            this.txtcOrgBoxNumber.Location = new System.Drawing.Point(84, 65);
            this.txtcOrgBoxNumber.Name = "txtcOrgBoxNumber";
            this.txtcOrgBoxNumber.Size = new System.Drawing.Size(203, 21);
            this.txtcOrgBoxNumber.TabIndex = 2;
            this.txtcOrgBoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcOrgBoxNumber_KeyDown);
            // 
            // txtcNewBoxNumber
            // 
            this.txtcNewBoxNumber.Location = new System.Drawing.Point(84, 105);
            this.txtcNewBoxNumber.Name = "txtcNewBoxNumber";
            this.txtcNewBoxNumber.Size = new System.Drawing.Size(203, 21);
            this.txtcNewBoxNumber.TabIndex = 3;
            this.txtcNewBoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcNewBoxNumber_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(212, 142);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "确认";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // WorkSSReplaceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 230);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtcNewBoxNumber);
            this.Controls.Add(this.txtcOrgBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "WorkSSReplaceBox";
            this.Text = "换箱";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcOrgBoxNumber;
        private System.Windows.Forms.TextBox txtcNewBoxNumber;
        private System.Windows.Forms.Button btnSubmit;
    }
}