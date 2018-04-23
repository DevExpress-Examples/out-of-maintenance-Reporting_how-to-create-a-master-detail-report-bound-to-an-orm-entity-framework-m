@Html.DevExpress().DocumentViewer(Sub(settings)
                                      settings.Name = "DocumentViewer"
                                      settings.CallbackRouteValues = New With {
                                          .Controller = "Home",
                                          .Action = "DocumentViewerPartial"
                                      }
                                      settings.ExportRouteValues = New With {
                                          .Controller = "Home",
                                          .Action = "DocumentViewerExport"
                                      }
                                      settings.Report = CType(Model, XtraReport)
                                  End Sub).GetHtml()
