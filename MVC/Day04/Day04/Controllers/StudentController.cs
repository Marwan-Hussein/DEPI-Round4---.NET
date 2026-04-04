using Day04.Business_Logic;
using Day04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day04.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new();
        // Student/Index
        public IActionResult Index() // => default action
        {
            IGetable<Student> getable = new StudentBL();
            return View("Index", getable.GetAll());
        }

        // Student/ShowDetails?id=5
        public IActionResult ShowDetails(int id = 1)
        {
            IGetable<Student> getable = new StudentBL();
            var student = getable.GetById(id);
            return View("ShowDetails", student);  // student may be null; view handles it
        }

        [HttpGet]
        public IActionResult Add() => View("Add");

        [HttpPost]
        public IActionResult SaveAdd(Student std)
        {
            if(std.Name == null || std.Age <= 0 || std.DepartmentId < 1)
            {
                ViewBag.Error = "Invalid input. Please fill all fields correctly.";
                return View("Add");
            }

            studentBL.Add(std);
            return RedirectToAction(nameof(Index));
        }

    }
}
