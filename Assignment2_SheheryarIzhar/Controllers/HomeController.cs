using Assignment2_SheheryarIzhar.DataManager;
using Assignment2_SheheryarIzhar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2_SheheryarIzhar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult StudentList()
        {
            StudentManager studentManager = new StudentManager();
            var students = studentManager.GetAllStudent();
            return View(students);
        }
        public IActionResult AddStudent(Student student)
        {
            StudentManager studentManager = new StudentManager();
            studentManager.AddStudent(student);
            return RedirectToAction("StudentList", "Home");
        }
        public IActionResult EditStudent(Student student)
        {
            StudentManager studentManager = new StudentManager();
            studentManager.EditStudent(student);
            return RedirectToAction("StudentList", "Home");
        }
    }
}
