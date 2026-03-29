using Microsoft.AspNetCore.Mvc;

namespace Day02.Controllers
{
    public class StudentController : Controller
    {
        // Student/Details?id=5
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
