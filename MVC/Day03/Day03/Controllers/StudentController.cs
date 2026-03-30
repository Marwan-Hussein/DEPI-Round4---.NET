using Day03.Business_Logic;
using Day03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day03.Controllers
{
    public class StudentController : Controller
    {
        // Student/ShowDetails?id=5
        public IActionResult ShowDetails(int id = 1)
        {
            IGetable<Student> getable = new StudentBL();
            var student = getable.GetById(id);
            return View("ShowDetails", student);  // student may be null; view handles it
        }

        // Student/ShowAll
        public IActionResult ShowAll()
        {
            IGetable<Student> getable = new StudentBL();
            return View("ShowAll", getable.GetAll());
        }
    }
}
