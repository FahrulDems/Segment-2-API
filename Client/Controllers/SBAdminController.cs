using Microsoft.AspNetCore.Mvc;
namespace Client.Controllers
{
    public class SBAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}