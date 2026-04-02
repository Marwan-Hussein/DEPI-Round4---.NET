using Day04.Business_Logic;
using Day04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day04.Controllers
{
    public class StudentController : Controller
    {
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

    }
}
