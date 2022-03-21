using AS_lab1_gr1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS_lab1_gr1.Controllers
{
    public class AuthorController : Controller
    {
        private readonly MyDbContext _dbContext;

        public AuthorController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Author> authors = _dbContext.Authors;
            return View(authors);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Author author)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Authors.Add(author);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(author);
        }

        public IActionResult Delete(int? id)
        {
            var obj = _dbContext.Authors.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var authorFromDb = _dbContext.Authors.Find(id);

            if (authorFromDb == null)
            {
                return NotFound();
            }

            return View(authorFromDb);
        }


        [HttpPost]
        public IActionResult Edit(Author obj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Authors.Update(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(obj);
        }
    }
}
