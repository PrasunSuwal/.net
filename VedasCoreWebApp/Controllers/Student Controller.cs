using Microsoft.AspNetCore.Mvc;

namespace VedasCoreWebApp.Controllers
{
    public class Student_Controller : Controller
    {
        public IActionResult StudentDetail()
        {
            return View();
        }
    }
}
