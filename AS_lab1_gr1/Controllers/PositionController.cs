using AS_lab1_gr1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS_lab1_gr1.Controllers
{
    public class PositionController : Controller
    {
        private readonly MyDbContext _dbContext;

        public PositionController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Position> positions = _dbContext.Positions;
            return View(positions);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Position position)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Positions.Add(position);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }


        public IActionResult Delete(int? id)
        {
            var obj = _dbContext.Positions.Find(id);
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

            var positionFromDb = _dbContext.Positions.Find(id);

            if (positionFromDb == null)
            {
                return NotFound();
            }

            return View(positionFromDb);
        }


        [HttpPost]
        public IActionResult Edit(Position obj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Positions.Update(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
