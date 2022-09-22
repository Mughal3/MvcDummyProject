using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDummyProject.Models
{
    public class StudentModel
    {
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public string Address { get; set;  }
    }
    public class SubjectModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class StudentFinalModel
    {
        public StudentModel StudentDetails { get; set; }
        public List<SubjectModel> StudentSubjects { get; set; }
    }
}