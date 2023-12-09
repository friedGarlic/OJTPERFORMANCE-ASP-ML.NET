using Microsoft.AspNetCore.Mvc;

namespace ML_ASP.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trainee()
        {
            return View();
        }
    }
}
