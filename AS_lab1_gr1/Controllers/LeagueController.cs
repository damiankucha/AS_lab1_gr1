using Microsoft.AspNetCore.Mvc;

namespace AS_lab1_gr1.Controllers
{
    public class LeagueController : Controller
    {
        private readonly MyDbContext _dbContext;

        public LeagueController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
