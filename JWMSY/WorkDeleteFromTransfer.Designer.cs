namespace JWMSY
{
    partial class WorkDeleteFromTransfer
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcOrderNumber = new System.Windows.Forms.TextBox();
            this.btnRmStore = new System.Windows.Forms.Button();
            this.btnRmDelivery = new System.Windows.Forms.Button();
            this.btnSemiStore = new System.Windows.Forms.Button();
            this.btnSemiDelivery = new System.Windows.Forms.Button();
            this.btnProStore = new System.Windows.Forms.Button();
            this.btnProDelivery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(53, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "单据号";
            // 
            // txtcOrderNumber
            // 
            this.txtcOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcOrderNumber.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcOrderNumber.Location = new System.Drawing.Point(173, 36);
            this.txtcOrderNumber.Name = "txtcOrderNumber";
            this.txtcOrderNumber.Size = new System.Drawing.Size(378, 46);
            this.txtcOrderNumber.TabIndex = 4;
            // 
            // btnRmStore
            // 
            this.btnRmStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRmStore.Location = new System.Drawing.Point(59, 100);
            this.btnRmStore.Name = "btnRmStore";
            this.btnRmStore.Size = new System.Drawing.Size(124, 46);
            this.btnRmStore.TabIndex = 5;
            this.btnRmStore.Text = "原料调拨入库单";
            this.btnRmStore.UseVisualStyleBackColor = true;
            this.btnRmStore.Click += new System.EventHandler(this.btnRmStore_Click);
            // 
            // btnRmDelivery
            // 
            this.btnRmDelivery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRmDelivery.Location = new System.Drawing.Point(427, 100);
            this.btnRmDelivery.Name = "btnRmDelivery";
            this.btnRmDelivery.Size = new System.Drawing.Size(124, 46);
            this.btnRmDelivery.TabIndex = 6;
            this.btnRmDelivery.Text = "原料调拨出库单";
            this.btnRmDelivery.UseVisualStyleBackColor = true;
            this.btnRmDelivery.Click += new System.EventHandler(this.btnRmDelivery_Click);
            // 
            // btnSemiStore
            // 
            this.btnSemiStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSemiStore.Location = new System.Drawing.Point(59, 165);
            this.btnSemiStore.Name = "btnSemiStore";
            this.btnSemiStore.Size = new System.Drawing.Size(124, 46);
            this.btnSemiStore.TabIndex = 7;
            this.btnSemiStore.Text = "半成品调拨入库单";
            this.btnSemiStore.UseVisualStyleBackColor = true;
            this.btnSemiStore.Click += new System.EventHandler(this.btnSemiStore_Click);
            // 
            // btnSemiDelivery
            // 
            this.btnSemiDelivery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSemiDelivery.Location = new System.Drawing.Point(427, 165);
            this.btnSemiDelivery.Name = "btnSemiDelivery";
            this.btnSemiDelivery.Size = new System.Drawing.Size(124, 46);
            this.btnSemiDelivery.TabIndex = 8;
            this.btnSemiDelivery.Text = "半成品调拨出库单";
            this.btnSemiDelivery.UseVisualStyleBackColor = true;
            this.btnSemiDelivery.Click += new System.EventHandler(this.btnSemiDelivery_Click);
            // 
            // btnProStore
            // 
            this.btnProStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProStore.Location = new System.Drawing.Point(60, 231);
            this.btnProStore.Name = "btnProStore";
            this.btnProStore.Size = new System.Drawing.Size(124, 46);
            this.btnProStore.TabIndex = 9;
            this.btnProStore.Text = "产成品调拨入库单";
            this.btnProStore.UseVisualStyleBackColor = true;
            this.btnProStore.Click += new System.EventHandler(this.btnProStore_Click);
            // 
            // btnProDelivery
            // 
            this.btnProDelivery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProDelivery.Location = new System.Drawing.Point(427, 231);
            this.btnProDelivery.Name = "btnProDelivery";
            this.btnProDelivery.Size = new System.Drawing.Size(124, 46);
            this.btnProDelivery.TabIndex = 10;
            this.btnProDelivery.Text = "产成品调拨出库单";
            this.btnProDelivery.UseVisualStyleBackColor = true;
            this.btnProDelivery.Click += new System.EventHandler(this.btnProDelivery_Click);
            // 
            // WorkDeleteFromTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 289);
            this.Controls.Add(this.btnProDelivery);
            this.Controls.Add(this.btnProStore);
            this.Controls.Add(this.btnSemiDelivery);
            this.Controls.Add(this.btnSemiStore);
            this.Controls.Add(this.btnRmDelivery);
            this.Controls.Add(this.btnRmStore);
            this.Controls.Add(this.txtcOrderNumber);
            this.Controls.Add(this.label2);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "WorkDeleteFromTransfer";
            this.Text = "调拨反审核删除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcOrderNumber;
        private System.Windows.Forms.Button btnRmStore;
        private System.Windows.Forms.Button btnRmDelivery;
        private System.Windows.Forms.Button btnSemiStore;
        private System.Windows.Forms.Button btnSemiDelivery;
        private System.Windows.Forms.Button btnProStore;
        private System.Windows.Forms.Button btnProDelivery;
    }
}