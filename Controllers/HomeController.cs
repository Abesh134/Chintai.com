using Microsoft.AspNetCore.Mvc;


namespace CHINTAI.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
