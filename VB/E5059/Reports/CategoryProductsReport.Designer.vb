Imports Microsoft.VisualBasic
Imports System
Namespace E5059.Reports
	Partial Public Class CategoryProductsReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.lbDescription = New DevExpress.XtraReports.UI.XRLabel()
            Me.pbPicture = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbProductName = New DevExpress.XtraReports.UI.XRLabel()
            Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource()
            CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbDescription, Me.pbPicture, Me.lbCategoryName})
            Me.Detail.HeightF = 115.0!
            Me.Detail.KeepTogetherWithDetailReports = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'lbDescription
            '
            Me.lbDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
            Me.lbDescription.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Italic)
            Me.lbDescription.LocationFloat = New DevExpress.Utils.PointFloat(220.0!, 54.99999!)
            Me.lbDescription.Name = "lbDescription"
            Me.lbDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.lbDescription.SizeF = New System.Drawing.SizeF(420.0!, 55.0!)
            Me.lbDescription.StylePriority.UseFont = False
            Me.lbDescription.Text = "lbDescription"
            '
            'pbPicture
            '
            Me.pbPicture.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Picture")})
            Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.pbPicture.Name = "pbPicture"
            Me.pbPicture.SizeF = New System.Drawing.SizeF(200.0!, 100.0!)
            Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            '
            'lbCategoryName
            '
            Me.lbCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryName")})
            Me.lbCategoryName.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
            Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(220.0!, 10.00001!)
            Me.lbCategoryName.Name = "lbCategoryName"
            Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.lbCategoryName.SizeF = New System.Drawing.SizeF(420.0!, 40.0!)
            Me.lbCategoryName.StylePriority.UseFont = False
            Me.lbCategoryName.StylePriority.UseTextAlignment = False
            Me.lbCategoryName.Text = "lbCategoryName"
            Me.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'TopMargin
            '
            Me.TopMargin.HeightF = 100.0!
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.HeightF = 100.0!
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'DetailReport
            '
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
            Me.DetailReport.DataMember = "Products"
            Me.DetailReport.DataSource = Me.ObjectDataSource1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            '
            'Detail1
            '
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.lbProductName})
            Me.Detail1.HeightF = 25.0!
            Me.Detail1.Name = "Detail1"
            '
            'xrLabel1
            '
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(539.9999!, 0.0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            '
            'lbProductName
            '
            Me.lbProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
            Me.lbProductName.Font = New System.Drawing.Font("Times New Roman", 12.0!)
            Me.lbProductName.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 0.0!)
            Me.lbProductName.Name = "lbProductName"
            Me.lbProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.lbProductName.SizeF = New System.Drawing.SizeF(490.0!, 25.0!)
            Me.lbProductName.StylePriority.UseFont = False
            Me.lbProductName.Text = "lbProductName"
            '
            'ObjectDataSource1
            '
            Me.ObjectDataSource1.DataSource = GetType(NWindModel.Category)
            Me.ObjectDataSource1.Name = "ObjectDataSource1"
            '
            'CategoryProductsReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
            Me.ComponentStorage.Add(Me.ObjectDataSource1)
            Me.DataSource = Me.ObjectDataSource1
            Me.Version = "14.2"
            CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private lbDescription As DevExpress.XtraReports.UI.XRLabel
		Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox
		Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private lbProductName As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
	End Class
End Namespace
