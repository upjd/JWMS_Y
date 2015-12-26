namespace JWMSY
{
    partial class SearchEasQuery
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
            this.txtcOrderNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtcLotNo = new System.Windows.Forms.TextBox();
            this.txtcUser = new System.Windows.Forms.TextBox();
            this.txtcInvName = new System.Windows.Forms.TextBox();
            this.rbtncOrderNumber = new System.Windows.Forms.RadioButton();
            this.rbcProName = new System.Windows.Forms.RadioButton();
            this.rbcLotNo = new System.Windows.Forms.RadioButton();
            this.rbcUser = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtcOrderNumber
            // 
            this.txtcOrderNumber.Location = new System.Drawing.Point(111, 44);
            this.txtcOrderNumber.Name = "txtcOrderNumber";
            this.txtcOrderNumber.Size = new System.Drawing.Size(255, 21);
            this.txtcOrderNumber.TabIndex = 1;
            this.txtcOrderNumber.TextChanged += new System.EventHandler(this.txtcOrderNumber_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(291, 186);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtcLotNo
            // 
            this.txtcLotNo.Location = new System.Drawing.Point(111, 102);
            this.txtcLotNo.Name = "txtcLotNo";
            this.txtcLotNo.Size = new System.Drawing.Size(255, 21);
            this.txtcLotNo.TabIndex = 4;
            this.txtcLotNo.TextChanged += new System.EventHandler(this.txtcLotNo_TextChanged);
            // 
            // txtcUser
            // 
            this.txtcUser.Location = new System.Drawing.Point(111, 131);
            this.txtcUser.Name = "txtcUser";
            this.txtcUser.Size = new System.Drawing.Size(255, 21);
            this.txtcUser.TabIndex = 6;
            this.txtcUser.TextChanged += new System.EventHandler(this.txtcUser_TextChanged);
            // 
            // txtcInvName
            // 
            this.txtcInvName.Location = new System.Drawing.Point(111, 73);
            this.txtcInvName.Name = "txtcInvName";
            this.txtcInvName.Size = new System.Drawing.Size(255, 21);
            this.txtcInvName.TabIndex = 8;
            this.txtcInvName.TextChanged += new System.EventHandler(this.txtcInvName_TextChanged);
            // 
            // rbtncOrderNumber
            // 
            this.rbtncOrderNumber.AutoSize = true;
            this.rbtncOrderNumber.Location = new System.Drawing.Point(48, 46);
            this.rbtncOrderNumber.Name = "rbtncOrderNumber";
            this.rbtncOrderNumber.Size = new System.Drawing.Size(59, 16);
            this.rbtncOrderNumber.TabIndex = 9;
            this.rbtncOrderNumber.TabStop = true;
            this.rbtncOrderNumber.Text = "单据号";
            this.rbtncOrderNumber.UseVisualStyleBackColor = true;
            // 
            // rbcProName
            // 
            this.rbcProName.AutoSize = true;
            this.rbcProName.Location = new System.Drawing.Point(48, 75);
            this.rbcProName.Name = "rbcProName";
            this.rbcProName.Size = new System.Drawing.Size(47, 16);
            this.rbcProName.TabIndex = 10;
            this.rbcProName.TabStop = true;
            this.rbcProName.Text = "品名";
            this.rbcProName.UseVisualStyleBackColor = true;
            // 
            // rbcLotNo
            // 
            this.rbcLotNo.AutoSize = true;
            this.rbcLotNo.Location = new System.Drawing.Point(48, 104);
            this.rbcLotNo.Name = "rbcLotNo";
            this.rbcLotNo.Size = new System.Drawing.Size(47, 16);
            this.rbcLotNo.TabIndex = 11;
            this.rbcLotNo.TabStop = true;
            this.rbcLotNo.Text = "批号";
            this.rbcLotNo.UseVisualStyleBackColor = true;
            this.rbcLotNo.CheckedChanged += new System.EventHandler(this.rbcLotNo_CheckedChanged);
            // 
            // rbcUser
            // 
            this.rbcUser.AutoSize = true;
            this.rbcUser.Location = new System.Drawing.Point(48, 133);
            this.rbcUser.Name = "rbcUser";
            this.rbcUser.Size = new System.Drawing.Size(59, 16);
            this.rbcUser.TabIndex = 12;
            this.rbcUser.TabStop = true;
            this.rbcUser.Text = "制单人";
            this.rbcUser.UseVisualStyleBackColor = true;
            this.rbcUser.CheckedChanged += new System.EventHandler(this.rbcUser_CheckedChanged);
            // 
            // SearchEasQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 252);
            this.Controls.Add(this.rbcUser);
            this.Controls.Add(this.rbcLotNo);
            this.Controls.Add(this.rbcProName);
            this.Controls.Add(this.rbtncOrderNumber);
            this.Controls.Add(this.txtcInvName);
            this.Controls.Add(this.txtcUser);
            this.Controls.Add(this.txtcLotNo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtcOrderNumber);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchEasQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EAS单据号查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcOrderNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtcLotNo;
        private System.Windows.Forms.TextBox txtcUser;
        private System.Windows.Forms.TextBox txtcInvName;
        private System.Windows.Forms.RadioButton rbtncOrderNumber;
        private System.Windows.Forms.RadioButton rbcProName;
        private System.Windows.Forms.RadioButton rbcLotNo;
        private System.Windows.Forms.RadioButton rbcUser;
    }
}