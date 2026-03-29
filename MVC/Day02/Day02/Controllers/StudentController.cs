using Day02.Bussiness_Logic;
using Day02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day02.Controllers
{
    public class StudentController : Controller
    {
        // Student/Details?id=5
        public IActionResult Details(int id)
        {
            IGetable<Student> getable = new StudentBL();
            return View("Details", getable.GetById(id));
        }

        // Student/ShowAll
        public IActionResult ShowAll()
        {
            IGetable<Student> getable = new StudentBL();
            return View("ShowAll", getable.GetAll());
        }
    }
}
