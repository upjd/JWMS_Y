namespace JWMSY
{
    partial class WorkTempBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTempBox));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ImgCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            this.bsiPrint = new DevExpress.XtraBars.BarSubItem();
            this.biPreview = new DevExpress.XtraBars.BarButtonItem();
            this.biDesign = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.bsiTemplet = new DevExpress.XtraBars.BarStaticItem();
            this.biTemplet = new DevExpress.XtraBars.BarButtonItem();
            this.bsiPrinter = new DevExpress.XtraBars.BarStaticItem();
            this.biPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ImgCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTemplet = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPrinter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.uneiNum = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcAddress = new System.Windows.Forms.TextBox();
            this.txtcName = new System.Windows.Forms.TextBox();
            this.txtcMemo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneiNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Images = this.ImgCollection16;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bsiPrint,
            this.biPreview,
            this.biDesign,
            this.biPrint,
            this.biExit,
            this.bsiTemplet,
            this.biTemplet,
            this.bsiPrinter,
            this.biPrinter,
            this.bbiPrint,
            this.bbiNew});
            this.ribbon.LargeImages = this.ImgCollection32;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 74;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(484, 98);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ImgCollection16
            // 
            this.ImgCollection16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImgCollection16.ImageStream")));
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.design, "design", typeof(global::JWMSY.Properties.Resources), 0);
            this.ImgCollection16.Images.SetKeyName(0, "design");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.preview, "preview", typeof(global::JWMSY.Properties.Resources), 1);
            this.ImgCollection16.Images.SetKeyName(1, "preview");
            this.ImgCollection16.InsertImage(global::JWMSY.Properties.Resources.print, "print", typeof(global::JWMSY.Properties.Resources), 2);
            this.ImgCollection16.Images.SetKeyName(2, "print");
            // 
            // bsiPrint
            // 
            this.bsiPrint.Caption = "打印";
            this.bsiPrint.Id = 2;
            this.bsiPrint.LargeImageIndex = 7;
            this.bsiPrint.Name = "bsiPrint";
            this.bsiPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // biPreview
            // 
            this.biPreview.Caption = "预览";
            this.biPreview.Id = 53;
            this.biPreview.ImageIndex = 1;
            this.biPreview.Name = "biPreview";
            // 
            // biDesign
            // 
            this.biDesign.Caption = "设计";
            this.biDesign.Id = 54;
            this.biDesign.ImageIndex = 0;
            this.biDesign.Name = "biDesign";
            // 
            // biPrint
            // 
            this.biPrint.Caption = "打印";
            this.biPrint.Id = 55;
            this.biPrint.ImageIndex = 2;
            this.biPrint.Name = "biPrint";
            // 
            // biExit
            // 
            this.biExit.Caption = "退出";
            this.biExit.Id = 62;
            this.biExit.LargeImageIndex = 4;
            this.biExit.Name = "biExit";
            this.biExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biExit_ItemClick);
            // 
            // bsiTemplet
            // 
            this.bsiTemplet.Caption = "当前模版如下";
            this.bsiTemplet.Id = 67;
            this.bsiTemplet.Name = "bsiTemplet";
            this.bsiTemplet.TextAlignment = System.Drawing.StringAlignment.Near;
            this.bsiTemplet.Width = 100;
            // 
            // biTemplet
            // 
            this.biTemplet.Id = 68;
            this.biTemplet.Name = "biTemplet";
            this.biTemplet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biTemplet_ItemClick);
            // 
            // bsiPrinter
            // 
            this.bsiPrinter.Caption = "当前打印机如下";
            this.bsiPrinter.Id = 69;
            this.bsiPrinter.Name = "bsiPrinter";
            this.bsiPrinter.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // biPrinter
            // 
            this.biPrinter.Id = 70;
            this.biPrinter.Name = "biPrinter";
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "打印";
            this.bbiPrint.Id = 72;
            this.bbiPrint.LargeImageIndex = 7;
            this.bbiPrint.Name = "bbiPrint";
            this.bbiPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrint_ItemClick);
            // 
            // ImgCollection32
            // 
            this.ImgCollection32.ImageSize = new System.Drawing.Size(32, 32);
            this.ImgCollection32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImgCollection32.ImageStream")));
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.abandon, "abandon", typeof(global::JWMSY.Properties.Resources), 0);
            this.ImgCollection32.Images.SetKeyName(0, "abandon");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.add, "add", typeof(global::JWMSY.Properties.Resources), 1);
            this.ImgCollection32.Images.SetKeyName(1, "add");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.edit, "edit", typeof(global::JWMSY.Properties.Resources), 2);
            this.ImgCollection32.Images.SetKeyName(2, "edit");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.examin, "examin", typeof(global::JWMSY.Properties.Resources), 3);
            this.ImgCollection32.Images.SetKeyName(3, "examin");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.exit, "exit", typeof(global::JWMSY.Properties.Resources), 4);
            this.ImgCollection32.Images.SetKeyName(4, "exit");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.ExportDialog, "ExportDialog", typeof(global::JWMSY.Properties.Resources), 5);
            this.ImgCollection32.Images.SetKeyName(5, "ExportDialog");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.giveup, "giveup", typeof(global::JWMSY.Properties.Resources), 6);
            this.ImgCollection32.Images.SetKeyName(6, "giveup");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.printDialog, "printDialog", typeof(global::JWMSY.Properties.Resources), 7);
            this.ImgCollection32.Images.SetKeyName(7, "printDialog");
            this.ImgCollection32.InsertImage(global::JWMSY.Properties.Resources.save, "save", typeof(global::JWMSY.Properties.Resources), 8);
            this.ImgCollection32.Images.SetKeyName(8, "save");
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystem,
            this.rpgExport,
            this.rpgTemplet,
            this.rpgPrinter});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "菜单选项";
            // 
            // rpgSystem
            // 
            this.rpgSystem.ItemLinks.Add(this.biExit);
            this.rpgSystem.Name = "rpgSystem";
            this.rpgSystem.ShowCaptionButton = false;
            this.rpgSystem.Text = "系统";
            // 
            // rpgExport
            // 
            this.rpgExport.ItemLinks.Add(this.bbiPrint);
            this.rpgExport.ItemLinks.Add(this.bbiNew);
            this.rpgExport.Name = "rpgExport";
            this.rpgExport.ShowCaptionButton = false;
            this.rpgExport.Text = "处理";
            // 
            // rpgTemplet
            // 
            this.rpgTemplet.ItemLinks.Add(this.bsiTemplet);
            this.rpgTemplet.ItemLinks.Add(this.biTemplet);
            this.rpgTemplet.Name = "rpgTemplet";
            this.rpgTemplet.Text = "打印模版";
            // 
            // rpgPrinter
            // 
            this.rpgPrinter.ItemLinks.Add(this.bsiPrinter);
            this.rpgPrinter.ItemLinks.Add(this.biPrinter);
            this.rpgPrinter.Name = "rpgPrinter";
            this.rpgPrinter.Text = "打印机属性";
            // 
            // uneiNum
            // 
            this.uneiNum.Location = new System.Drawing.Point(172, 223);
            this.uneiNum.MaskInput = "nnnnn";
            this.uneiNum.MaxValue = 10000;
            this.uneiNum.MinValue = 0;
            this.uneiNum.Name = "uneiNum";
            this.uneiNum.Nullable = true;
            this.uneiNum.Size = new System.Drawing.Size(197, 21);
            this.uneiNum.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "总件数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "地址：";
            // 
            // txtcAddress
            // 
            this.txtcAddress.Location = new System.Drawing.Point(172, 121);
            this.txtcAddress.Name = "txtcAddress";
            this.txtcAddress.Size = new System.Drawing.Size(197, 21);
            this.txtcAddress.TabIndex = 124;
            // 
            // txtcName
            // 
            this.txtcName.Location = new System.Drawing.Point(172, 155);
            this.txtcName.Name = "txtcName";
            this.txtcName.Size = new System.Drawing.Size(197, 21);
            this.txtcName.TabIndex = 125;
            // 
            // txtcMemo
            // 
            this.txtcMemo.Location = new System.Drawing.Point(172, 189);
            this.txtcMemo.Name = "txtcMemo";
            this.txtcMemo.Size = new System.Drawing.Size(197, 21);
            this.txtcMemo.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 127;
            this.label2.Text = "收货人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 128;
            this.label4.Text = "备注：";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "新建";
            this.bbiNew.Id = 73;
            this.bbiNew.LargeImageIndex = 1;
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // WorkTempBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcMemo);
            this.Controls.Add(this.txtcName);
            this.Controls.Add(this.txtcAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uneiNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ribbon);
            this.Icon = global::JWMSY.Properties.Resources.scanicon;
            this.Name = "WorkTempBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三生物流-件数自定义打印";
            this.Load += new System.EventHandler(this.WorkTempBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCollection32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneiNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.Utils.ImageCollection ImgCollection16;
        private DevExpress.XtraBars.BarSubItem bsiPrint;
        private DevExpress.XtraBars.BarButtonItem biPreview;
        private DevExpress.XtraBars.BarButtonItem biDesign;
        private DevExpress.XtraBars.BarButtonItem biPrint;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.XtraBars.BarStaticItem bsiTemplet;
        private DevExpress.XtraBars.BarButtonItem biTemplet;
        private DevExpress.XtraBars.BarStaticItem bsiPrinter;
        private DevExpress.XtraBars.BarButtonItem biPrinter;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.Utils.ImageCollection ImgCollection32;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTemplet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPrinter;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneiNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcAddress;
        private System.Windows.Forms.TextBox txtcName;
        private System.Windows.Forms.TextBox txtcMemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
    }
}