using Microsoft.AspNetCore.Mvc;
using myaz303.Models;
using MYAZ303_MVC.Data;
using MYAZ303_MVC.Models;

namespace MYAZ303_MVC.Controllers
{
    public class FilmController : Controller
    {

        private readonly ApplicationDbContext _db;

        public FilmController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Film> objFilmList = _db.Filmler;
            return View(objFilmList);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Film obj)
        {
            if (ModelState.IsValid)
            {
                _db.Filmler.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var FilmFromDb = _db.Filmler.Find(id);


            if (FilmFromDb == null)
            {
                return NotFound();
            }

            return View(FilmFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Film obj)
        {

            if (ModelState.IsValid)
            {
                
                _db.Filmler.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var FilmFromDb = _db.Filmler.Find(id);
            if (FilmFromDb == null)
            {
                return NotFound();
            }
            return View(FilmFromDb);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Filmler.Find(id);
            if (obj == null) {
                return NotFound();
            }
            _db.Filmler.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
