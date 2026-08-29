using Microsoft.AspNetCore.Mvc;

namespace CHINTAI.Controllers
{
    public class CitizenController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}