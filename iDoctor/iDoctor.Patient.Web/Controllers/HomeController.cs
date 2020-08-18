using Microsoft.AspNetCore.Mvc;

namespace iDoctor.Patient.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
