using Microsoft.AspNetCore.Mvc;

namespace TaskOrm.Controllers
{
    public class AboutController:Controller
    {
        public IActionResult Index() 
        {
            return Content("About Index");

        }
        public IActionResult Detail(int id)
        {
            return Content("About Detail" + id);
        }
    }
}
