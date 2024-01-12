using Schools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schools.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult DeptIndex()
        {
            return View();
        }
        public ActionResult SaveDept(DeptModel model)
        {
            try
            {
                return Json(new { Message = new DeptModel().SaveDept(model) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}