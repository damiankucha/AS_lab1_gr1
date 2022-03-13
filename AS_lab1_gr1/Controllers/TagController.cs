using AS_lab1_gr1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS_lab1_gr1.Controllers
{
    public class TagController : Controller
    {
        private readonly MyDbContext _dbContext;

        public TagController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Tag> tags = _dbContext.Tags;
            return View(tags);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Tag tag)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Tags.Add(tag);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
