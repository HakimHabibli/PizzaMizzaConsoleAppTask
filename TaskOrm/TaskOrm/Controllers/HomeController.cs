using Microsoft.AspNetCore.Mvc;

namespace TaskOrm.Controllers
{
    public class Homecontroller:Controller
    {
        public IActionResult Index()
        {
            return Content("Home Index");
        }
        public IActionResult Detail()
        {
            return Content("Home Detail");
        }
    }
}
