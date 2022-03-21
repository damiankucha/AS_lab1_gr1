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
                TempData["success"] = "League added successfully!";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            var obj = _dbContext.Leagues.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            TempData["success"] = "League deleted successfully!";
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var leagueFromDb = _dbContext.Leagues.Find(id);

            if (leagueFromDb == null)
            {
                return NotFound();
            }

            return View(leagueFromDb);
        }


        [HttpPost]
        public IActionResult Edit(League obj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Leagues.Update(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(obj);
        }
    }
}
