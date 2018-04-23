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
			Me.components = New System.ComponentModel.Container()
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
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbDescription, Me.pbPicture, Me.lbCategoryName})
			Me.Detail.HeightF = 115F
			Me.Detail.KeepTogetherWithDetailReports = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbDescription
			' 
			Me.lbDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
			Me.lbDescription.Font = New System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic)
			Me.lbDescription.LocationFloat = New DevExpress.Utils.PointFloat(220F, 54.99999F)
			Me.lbDescription.Name = "lbDescription"
			Me.lbDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDescription.SizeF = New System.Drawing.SizeF(420F, 55F)
			Me.lbDescription.StylePriority.UseFont = False
			Me.lbDescription.Text = "lbDescription"
			' 
			' pbPicture
			' 
			Me.pbPicture.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Picture")})
			Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.pbPicture.Name = "pbPicture"
			Me.pbPicture.SizeF = New System.Drawing.SizeF(200F, 100F)
			Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' lbCategoryName
			' 
			Me.lbCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryName")})
			Me.lbCategoryName.Font = New System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold)
			Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(220F, 10.00001F)
			Me.lbCategoryName.Name = "lbCategoryName"
			Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbCategoryName.SizeF = New System.Drawing.SizeF(420F, 40F)
			Me.lbCategoryName.StylePriority.UseFont = False
			Me.lbCategoryName.StylePriority.UseTextAlignment = False
			Me.lbCategoryName.Text = "lbCategoryName"
			Me.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataMember = "Products"
			Me.DetailReport.DataSource = Me.bindingSource1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.lbProductName})
			Me.Detail1.HeightF = 25F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(539.9999F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "xrLabel1"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' lbProductName
			' 
			Me.lbProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.lbProductName.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.lbProductName.LocationFloat = New DevExpress.Utils.PointFloat(50F, 0F)
			Me.lbProductName.Name = "lbProductName"
			Me.lbProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbProductName.SizeF = New System.Drawing.SizeF(490F, 25F)
			Me.lbProductName.StylePriority.UseFont = False
			Me.lbProductName.Text = "lbProductName"
			' 
			' bindingSource1
			' 
            Me.bindingSource1.DataSource = GetType(NWindModel.Category)
			' 
			' CategoryProductsReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
			Me.DataSource = Me.bindingSource1
			Me.Version = "13.2"
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private lbDescription As DevExpress.XtraReports.UI.XRLabel
		Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox
		Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private lbProductName As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
