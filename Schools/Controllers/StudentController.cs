using Schools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schools.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentIndex()
        {
            return View();
        }
        public ActionResult SaveStudent(StudentModel model) 
        {
            try
            {
                return Json(new { Message = new StudentModel().SaveStudent(model) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new {model = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetStudentlst()
        {
            try
            {
                return Json(new { Message = new StudentModel().GetStudentlst() }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new {ex.Message},JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult deleteStudent(int Id)
        {
            try
            {
                return Json(new { model = new StudentModel().deleteStudent(Id) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new {ex.Message}, JsonRequestBehavior.AllowGet);    
            }
        }
    }
}