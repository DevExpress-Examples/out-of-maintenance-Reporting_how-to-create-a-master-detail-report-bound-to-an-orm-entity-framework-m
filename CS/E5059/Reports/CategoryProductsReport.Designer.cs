namespace E5059.Reports {
    partial class CategoryProductsReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lbDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.pbPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lbCategoryName = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbProductName = new DevExpress.XtraReports.UI.XRLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDescription,
            this.pbPicture,
            this.lbCategoryName});
            this.Detail.HeightF = 115F;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Description")});
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
            this.lbDescription.LocationFloat = new DevExpress.Utils.PointFloat(220F, 54.99999F);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDescription.SizeF = new System.Drawing.SizeF(420F, 55F);
            this.lbDescription.StylePriority.UseFont = false;
            this.lbDescription.Text = "lbDescription";
            // 
            // pbPicture
            // 
            this.pbPicture.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Picture")});
            this.pbPicture.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.SizeF = new System.Drawing.SizeF(200F, 100F);
            this.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CategoryName")});
            this.lbCategoryName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.lbCategoryName.LocationFloat = new DevExpress.Utils.PointFloat(220F, 10.00001F);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCategoryName.SizeF = new System.Drawing.SizeF(420F, 40F);
            this.lbCategoryName.StylePriority.UseFont = false;
            this.lbCategoryName.StylePriority.UseTextAlignment = false;
            this.lbCategoryName.Text = "lbCategoryName";
            this.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "Products";
            this.DetailReport.DataSource = this.bindingSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.lbProductName});
            this.Detail1.HeightF = 25F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitPrice", "{0:c}")});
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(539.9999F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lbProductName
            // 
            this.lbProductName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ProductName")});
            this.lbProductName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbProductName.LocationFloat = new DevExpress.Utils.PointFloat(50F, 0F);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbProductName.SizeF = new System.Drawing.SizeF(490F, 25F);
            this.lbProductName.StylePriority.UseFont = false;
            this.lbProductName.Text = "lbProductName";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(E5059.Models.Category);
            // 
            // CategoryProductsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.DataSource = this.bindingSource1;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRLabel lbDescription;
        private DevExpress.XtraReports.UI.XRPictureBox pbPicture;
        private DevExpress.XtraReports.UI.XRLabel lbCategoryName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lbProductName;
    }
}
