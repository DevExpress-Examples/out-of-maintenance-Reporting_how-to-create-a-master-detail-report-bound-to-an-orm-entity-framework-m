using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.UI;
using E5059.Models;
using E5059.Reports;

namespace E5059.Controllers {
    public class HomeController : Controller {
        static NWindEntities _dataContext = new NWindEntities();

        public NWindEntities DataContext {
            get {
                return _dataContext;
            }
        }

        public ActionResult Index() {
            return View();
        }

        public ActionResult DocumentViewerPartial() {
            XtraReport report = new CategoryProductsReport();
            report.DataSource = from category in DataContext.Categories
                                select category;
            return PartialView("_DocumentViewerPartial", report);
        }

        public ActionResult DocumentViewerExport() {
            XtraReport report = new CategoryProductsReport();
            report.DataSource = from category in DataContext.Categories
                                select category;
            return DocumentViewerExtension.ExportTo(report);
        }
    }
}