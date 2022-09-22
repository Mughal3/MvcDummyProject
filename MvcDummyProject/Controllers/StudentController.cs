using MvcDummyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDummyProject.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllStudents()
        {
            return View();
        }
        public ActionResult ShowAll()
        {
            //SetStudentViaViewData();
            //SetStudentViaViewBag();
            StudentModel information = new StudentModel
            {
                StudentName = "Mr Jahangir is Sleeping",
                Address = "Sleeping Town ",
                Age = 120,
                FatherName = "XYZ"
            };
            return View(information);
        }
        public void SetStudentViaViewData()
        {
            List<StudentModel> FaiziStudents = new List<StudentModel>();
            StudentModel FirstStudent = new StudentModel();
            FirstStudent.Address = "Lahore";
            FirstStudent.Age = 16;
            FirstStudent.FatherName = "Mazhar";
            FirstStudent.StudentName = "Faizan";
            StudentModel SecondStudent = new StudentModel
            {
                Address = "Lahore",
                Age = 16,
                FatherName = "Mazhar",
                StudentName = "Muzamil"
            };
            FaiziStudents.Add(FirstStudent);
            FaiziStudents.Add(SecondStudent);
            ViewData["faiz"] = FaiziStudents;
        }
        public void SetStudentViaViewBag()
        {

            ViewBag.Title = "Page to Display all Students Info via ViewBag";
            ViewData["Title"] = "Page to Display all Students Info via ViewData";
            ViewBag.ActressName = "Anglena Jollie";
            ViewBag.HusbandName = "Bhad Phit";
            ViewBag.Age = 76;
            ViewBag.IsMarried = true;
            ViewBag.SalaryPerAnnum = 1000000;
        }
        public StudentModel SetStudentViaModel()
        {
            StudentModel information = new StudentModel{
               StudentName = "Mr Jahangir is Sleeping",
               Address = "Sleeping Town ",
               Age = 120,
               FatherName = "XYZ"
            };
            return information;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveStudent(StudentModel model)
        {
            return null;
        }

    }
}