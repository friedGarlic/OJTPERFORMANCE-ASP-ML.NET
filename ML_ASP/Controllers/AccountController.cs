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
            var obj = _dbContext.Accounts.ToList();
            return View();
        }
    }
}
