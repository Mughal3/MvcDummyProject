using MvcDummyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDummyProject.Controllers
{
    public class TeacherController : Controller
    { 
        public ActionResult Details()
        {
            TeacherModel model = new TeacherModel
            {
                Address = "Lahore",
                Age = 76,
                Id = 100,
                Name = "Mr Something Something"
            };
            return View(model);
        }

        public ActionResult List()
        {
            List<TeacherModel> teachersList = new List<TeacherModel>();
            TeacherModel teacher1 = new TeacherModel
            {
                Address = "Lahore",
                Age = 76,
                Id = 100,
                Name = "Teacher 1"
            };
            TeacherModel teacher2 = new TeacherModel
            {
                Address = "Karachi",
                Age = 76,
                Id = 109,
                Name = "Teacher 2"
            };
            TeacherModel teacher3 = new TeacherModel
            {
                Address = "Lahore",
                Age = 76,
                Id = 100,
                Name = "Teacher 3"
            };
            TeacherModel teacher4 = new TeacherModel
            {
                Address = "Karachi",
                Age = 76,
                Id = 109,
                Name = "Teacher 4"
            };

            teachersList.Add(teacher1);
            teachersList.Add(teacher2);
            teachersList.Add(teacher3);
            teachersList.Add(teacher4);

            return View(teachersList);
        }
    }
}