using AS_lab1_gr1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS_lab1_gr1.Controllers
{
    public class TeamController : Controller
    {
        private readonly MyDbContext _dbContext;

        public TeamController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Team> teams = _dbContext.Teams;
            return View(teams);
        }


    }
}
