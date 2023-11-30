using Microsoft.AspNetCore.Mvc;
using ML_ASP.Data;

namespace ML_ASP.Controllers
{
    public class AccountController : Controller
    {
        private readonly ML_DBContext _dbContext;

        public AccountController(ML_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
