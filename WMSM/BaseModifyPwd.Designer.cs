namespace WMSM
{
    partial class BaseModifyPwd
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
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton2 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton3 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.utxtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtUser = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtPwd = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPwd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(123, 204);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 34);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "提交修改";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // utxtPassword
            // 
            this.utxtPassword.AutoSize = false;
            appearance1.Image = global::WMSM.Properties.Resources.LoginForm_password;
            editorButton1.Appearance = appearance1;
            this.utxtPassword.ButtonsLeft.Add(editorButton1);
            this.utxtPassword.Location = new System.Drawing.Point(79, 99);
            this.utxtPassword.Name = "utxtPassword";
            this.utxtPassword.PasswordChar = '*';
            this.utxtPassword.Size = new System.Drawing.Size(256, 29);
            this.utxtPassword.TabIndex = 5;
            // 
            // utxtUser
            // 
            this.utxtUser.AutoSize = false;
            appearance2.Image = global::WMSM.Properties.Resources.LoginForm_user;
            editorButton2.Appearance = appearance2;
            this.utxtUser.ButtonsLeft.Add(editorButton2);
            this.utxtUser.Location = new System.Drawing.Point(79, 55);
            this.utxtUser.Name = "utxtUser";
            this.utxtUser.Size = new System.Drawing.Size(256, 29);
            this.utxtUser.TabIndex = 4;
            // 
            // utxtPwd
            // 
            this.utxtPwd.AutoSize = false;
            appearance3.Image = global::WMSM.Properties.Resources.LoginForm_password;
            editorButton3.Appearance = appearance3;
            this.utxtPwd.ButtonsLeft.Add(editorButton3);
            this.utxtPwd.Location = new System.Drawing.Point(79, 148);
            this.utxtPwd.Name = "utxtPwd";
            this.utxtPwd.PasswordChar = '*';
            this.utxtPwd.Size = new System.Drawing.Size(256, 29);
            this.utxtPwd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "原密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "新密码";
            // 
            // BaseModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.utxtPwd);
            this.Controls.Add(this.utxtPassword);
            this.Controls.Add(this.utxtUser);
            this.Controls.Add(this.btnSubmit);
            this.Icon = global::WMSM.Properties.Resources.Mine;
            this.Name = "BaseModifyPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtUser;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}