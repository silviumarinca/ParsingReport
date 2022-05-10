using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParsingReport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ReportViewer viewer = new ReportViewer();
            viewer.LocalReport.ReportPath = Server.MapPath("~/App_Data/Test.rdl");
            viewer.ProcessingMode = ProcessingMode.Local; 
            viewer.Width   = 700;
            viewer.Height = 600;
            ViewBag.ReportViewer = viewer;
            return View();
        }

      
    }
}