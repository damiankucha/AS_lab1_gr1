using AS_lab1_gr1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS_lab1_gr1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDbContext _dbContext;

        public CategoryController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _dbContext.Categories;
            return View(categories);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
