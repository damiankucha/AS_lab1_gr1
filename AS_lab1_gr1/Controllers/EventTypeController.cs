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
            var eventTypes = _dbContext.EventTypes.ToList();
            return View(eventTypes);
        }

        //public IActionResult Add()
        //{
        //    return View();
        //}

        //public IActionResult Add(EventType eventType)
        //{

        //    return View(eventType);
        //}
    }
}
