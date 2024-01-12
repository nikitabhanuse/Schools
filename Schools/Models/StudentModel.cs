using Schools.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schools.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Class { get; set; }
        public string DeptId { get; set; }

        public string SaveStudent(StudentModel model)
        {
            string Message = "Submit";
            SchoolsEntities db = new SchoolsEntities();
                var data = new tblStudent()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Mobile = model.Mobile,
                    Class = model.Class,
                    DeptId = model.DeptId
                };
                db.tblStudents.Add(data);
                db.SaveChanges();
                return Message;           
        }
        public List<StudentModel> GetStudentlst()
        {
            SchoolsEntities db = new SchoolsEntities();
            List<StudentModel> lstStudent = new List<StudentModel>();
            var Sdata = db.tblStudents.ToList();
            if(Sdata != null)
            {
                foreach(var s in Sdata)
                {
                    lstStudent.Add(new StudentModel()
                    {
                     Id=s.Id,
                     Name = s.Name,
                     Mobile = s.Mobile,
                     Class = s.Class,
                     DeptId = s.DeptId
                    });
                }
            }
            return lstStudent;
        }

        public string  deleteStudent(int Id)
        {
            SchoolsEntities db = new SchoolsEntities();
            var msg = "Deleted";
            var deleteStudent = db.tblStudents.Where(p => p.Id == Id).FirstOrDefault();
            if(deleteStudent != null) 
            { 
               db.tblStudents.Remove(deleteStudent);
            }
            db.SaveChanges();
            msg = "Deleted";
            return msg;
        }
    }
}