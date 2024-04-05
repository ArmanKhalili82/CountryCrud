using CountryCrud.Data;
using CountryCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace CountryCrud.Controllers
{
    public class CountryController : Controller
    {
        private readonly CountryDbContext _db;
        public CountryController(CountryDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<FullInfo> objCountryList = _db.Infos.OrderByDescending(s => s.IsCapital == true).ToList();
            return View(objCountryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FullInfo obj)
        {
            if (ModelState.IsValid)
            {
                _db.Infos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            FullInfo obj = _db.Infos.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(FullInfo obj)
        {
            if (ModelState.IsValid)
            {
                _db.Infos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            FullInfo obj = _db.Infos.Find(id);
            return View(obj);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            FullInfo obj = _db.Infos.Find(id);
            _db.Infos.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpDelete]
        //public IActionResult Delete(int id)
        //{
        //    FullInfo obj = _db.Infos.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _db.Infos.Remove(obj);
        //    _db.SaveChanges();
        //    return Ok();
        //}
    }
}
