using Day05.Business_Logic;
using Day05.Models;
using Day05.ViewModels;

using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Day05.Controllers
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

        #region Add life cycle
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
        #endregion

        #region Edit life cycle
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = GetStudentDepVM(id);
            if(viewModel == null)
                return NotFound();
            return View("Edit", viewModel);
        }

        [HttpPost]
        public IActionResult SaveEdit(StudentDepVM viewModel)
        {
            if (viewModel.Name == null || viewModel.Age <= 15 || viewModel.DepartmentId < 1)
            {
                ViewBag.Error = "Invalid input. Please fill all fields correctly.";
                DepartmentBL departmentBL = new();
                IGetable<Department> getable = departmentBL;
                viewModel.Departments = getable.GetAll();
                return View("Edit", viewModel);
            }
            var newStudent = new Student
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Age = viewModel.Age,
                DepartmentId = viewModel.DepartmentId
            };
            studentBL.Edit(newStudent);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete student
        public IActionResult Delete(int id)
        {
            var viewModel = GetStudentDepVM(id);
            if(viewModel == null)
                return NotFound();
            return View("Delete", viewModel);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            IGetable<Student> getable = studentBL;
            var student = getable.GetById(id);
            if (student == null)
                return NotFound();
            studentBL.Delete(student);
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region helpers
        public StudentDepVM GetStudentDepVM(int id)
        {
            IGetable<Student> getable = studentBL;
            var student = getable.GetById(id);
            if (student == null)
                return null;
            DepartmentBL departmentBL = new();
            IGetable<Department> deptGetable = departmentBL;
            var departments = deptGetable.GetAll();
            return new StudentDepVM
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                Department = student.Department,
                Departments = departments
            };
        }
        #endregion
    }
}
