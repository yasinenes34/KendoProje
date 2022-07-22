using Kendo.BAL.Concrate;
using Kendo.DAL.EntityFramework;
using Kendo.DAL.Model;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kendo.WebUI.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudent());
        // GET: Student
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult EditingInline_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(sm.GetListBl().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Create([DataSourceRequest] DataSourceRequest request, Student student)
        {
            if (student != null && ModelState.IsValid)
            {
                sm.StudentAddBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Update([DataSourceRequest] DataSourceRequest request, Student student)
        {
            if (student != null && ModelState.IsValid)
            {
                sm.StudentUpdateBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Destroy([DataSourceRequest] DataSourceRequest request, Student student)
        {
            if (student != null)
            {
                sm.StudentRemoveBl(student);
            }

            return Json(new[] { student }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }
    }
}