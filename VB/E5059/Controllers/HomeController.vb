Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraReports.UI
Imports NWindModel
Imports E5059.Reports

Namespace E5059.Controllers
	Public Class HomeController
		Inherits Controller
        Private Shared _dataContext As New NWindEntities()

		Public ReadOnly Property DataContext() As NWindEntities
			Get
				Return _dataContext
			End Get
		End Property

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function DocumentViewerPartial() As ActionResult
			Dim report As XtraReport = New CategoryProductsReport()
			report.DataSource = _
				From category In DataContext.Categories _
				Select category
			Return PartialView("_DocumentViewerPartial", report)
		End Function

		Public Function DocumentViewerExport() As ActionResult
			Dim report As XtraReport = New CategoryProductsReport()
			report.DataSource = _
				From category In DataContext.Categories _
				Select category
			Return DocumentViewerExtension.ExportTo(report)
		End Function
	End Class
End Namespace