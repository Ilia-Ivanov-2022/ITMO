using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.WebPages.Html;
using ITMO.ASP.NET.MvcStudents.Models;
using Microsoft.Ajax.Utilities;

namespace ITMO.ASP.NET.MvcStudents.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext db = new StudentContext();   
        public ActionResult Index()
        {
            AllStudents();
            return View();
        }
        private void AllStudents()
        {
            var students = db.Students.ToList();
            ViewBag.Students = students;
        }
        [HttpGet]
        public ActionResult CreateStudent()
        {
            AllStudents();
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;
            return View();
        }
        [HttpPost]
        public string CreateStudent(Student newStudent)
        {
            if (ModelState.IsValid){
                db.Students.Add(newStudent);
                db.SaveChanges();
                return "Новый студет " + newStudent.FirstName + " " + newStudent.LastName + " добавлен.";
            }
            return "Введите правильные данные";
        }
        // Five best Students.
        public ActionResult StudentsStatistics()
        {
            var allStudents = db.Students.ToList();
            var bestStudents = from st in allStudents
                                 orderby (st.AdoMark + st.AspMark + st.JavaMark) descending
                                 select st;
            ViewBag.BestStudents = bestStudents.Take(5);

            var worstStudents = from st in allStudents
                                orderby (st.AdoMark + st.AspMark + st.JavaMark) ascending
                                select st;
            ViewBag.WorstStudents = worstStudents.Take(5);

            return View();
        }

        public ActionResult TotalScore()
        {
            AllStudents();
            return View();
        }
    }
}