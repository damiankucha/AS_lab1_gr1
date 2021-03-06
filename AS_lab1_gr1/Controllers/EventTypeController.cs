using AS_lab1_gr1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS_lab1_gr1.Controllers
{
    public class EventTypeController : Controller
    {
        private readonly MyDbContext _dbContext;

        public EventTypeController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<EventType> eventTypes = _dbContext.EventTypes;
            return View(eventTypes);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(EventType eventType)
        {
            if (ModelState.IsValid)
            {
                _dbContext.EventTypes.Add(eventType);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
