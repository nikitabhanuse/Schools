using Microsoft.Ajax.Utilities;
using Schools.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schools.Models
{
    public class DeptModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string SaveDept(DeptModel model)
        {
            string Message = "Submit";
            SchoolsEntities db = new SchoolsEntities();
            var dData = new tblDept()
            {
                DeptId = model.DeptId,
                DeptName = model.DeptName,
            };
            db.tblDepts.Add(dData);
            db.SaveChanges();
            return Message;


    }   }
}