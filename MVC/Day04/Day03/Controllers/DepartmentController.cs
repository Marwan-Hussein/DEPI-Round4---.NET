using Day04.Business_Logic;
using Day04.Helpers;
using Day04.Models;
using Day04.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Day04.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentBL departmentBL = new DepartmentBL();
        // Department/Index
        [HttpGet]
        public IActionResult Index() // => default action
        {
            IGetable<Department> getable = new DepartmentBL();
            return View("Index", getable.GetAll());
        }

        // Department/ShowDetails?id=5
        [HttpGet]
        public IActionResult ShowDetails(int id = 1)
        {
            IGetable<Department> getable = new DepartmentBL();
            var dept = getable.GetById(id);
            return View("ShowDetails", dept);  // dept may be null; view handles it
        }


        [HttpGet]
        public IActionResult ExtraInfo() // Department/ExtraInfo
        {
            IGetable<Department> getable = new DepartmentBL();
            var depts = getable.GetAll();

            List<DepartmentWithExtraInfoVM> vMs = new List<DepartmentWithExtraInfoVM>();
            foreach (var dept in depts)
            {
                vMs.Add(new DepartmentWithExtraInfoVM()
                {
                    DepName = dept.Name,
                    TotStudents = Helper.Count<Student>(),
                    StudentsEx25 = dept.Students.Where(S => S.Age >= 25).ToList(),
                    State = dept.Students
                        .Count() >= 50 ? "Main" : "Branch"

                });
            }

            return View("ExtraInfo", vMs);
        }

        // Department/Add
        [HttpGet]
        public IActionResult Add(Department department)
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Department dept) 
        { 
            if(dept.Name == null || departmentBL.Contains(dept.Name))
                return View("Add", dept);
            departmentBL.Add(dept);
            return RedirectToAction(nameof(Index));

        }
    }
}
