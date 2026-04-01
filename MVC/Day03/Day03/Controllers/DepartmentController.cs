using Day03.Business_Logic;
using Day03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day03.Controllers
{
    public class DepartmentController : Controller
    {
        // Department/Index
        public IActionResult Index() // => default action
        {
            IGetable<Department> getable = new DepartmentBL();
            return View("Index", getable.GetAll());
        }

        // Department/ShowDetails?id=5
        public IActionResult ShowDetails(int id = 1)
        {
            IGetable<Department> getable = new DepartmentBL();
            var dept = getable.GetById(id);
            return View("ShowDetails", dept);  // dept may be null; view handles it
        }


        // Department/Add
        public IActionResult Add(Department department)
        {
        }
    }
}
