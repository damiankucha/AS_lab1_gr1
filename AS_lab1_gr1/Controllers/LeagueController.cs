using AS_lab1_gr1.Models;
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
            IEnumerable<League> leagues = _dbContext.Leagues;
            return View(leagues);
        }

        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(League league)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Leagues.Add(league);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
