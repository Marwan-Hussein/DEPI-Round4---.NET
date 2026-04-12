using Day04.Business_Logic;
using Day04.Models;
using Day04.ViewModels;

using System.Linq;
using System.Collections.Generic;
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
            return View("Index", 
                getable.GetAll()
                .OrderBy(s => s.Department.Name)
                .ThenByDescending(s => s.Age)
                .ThenBy(s => s.Name)
                .ToList()
                );
        }

        // Student/ShowDetails?id=5
        public IActionResult ShowDetails(int id = 1)
        {
            IGetable<Student> getable = new StudentBL();
            var student = getable.GetById(id);
            return View("ShowDetails", student);  // student may be null; view handles it
        }

        [HttpGet]
        public IActionResult Add()
        {
            DepartmentBL departmentBL = new();
            IGetable<Department> getable = departmentBL;
            var departments = getable.GetAll();

            var viewModel = new StudentDepVM
            {
                Departments = departments
            };

            return View("Add", viewModel);
        }

        [HttpPost]
        public IActionResult SaveAdd(StudentDepVM viewModel)
        {
            if (viewModel.Name == null || viewModel.Age <= 0 || viewModel.DepartmentId < 1)
            {
                ViewBag.Error = "Invalid input. Please fill all fields correctly.";
                DepartmentBL departmentBL = new();
                IGetable<Department> getable = departmentBL;
                viewModel.Departments = getable.GetAll();
                return View("Add", viewModel);
            }

            // Create a Student object from the ViewModel
            var student = new Student
            {
                Name = viewModel.Name,
                Age = viewModel.Age,
                DepartmentId = viewModel.DepartmentId
            };

            studentBL.Add(student);
            return RedirectToAction(nameof(Index));
        }

    }
}
