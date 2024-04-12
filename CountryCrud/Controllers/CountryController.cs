using Business;
using CountryCrud.Data;
using CountryCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace CountryCrud.Controllers
{
    public class CountryController : Controller
    {
        private IInfoService _infoService;
        public CountryController(IInfoService infoService)
        {
            _infoService = infoService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<FullInfo> objCountryList = await _infoService.GetAll();
            return View(objCountryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(FullInfo obj)
        {
            await _infoService.Create(obj);
            //if (ModelState.IsValid)
            //{
            //   await _db.Infos.AddAsync(obj);
            //   await _db.SaveChangesAsync();
            //    return RedirectToAction("Index");
            //}
            return View();
        }

        [HttpGet, ActionName("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _infoService.GetById(id);
            return View(item);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(FullInfo obj)
        {
            _infoService.Edit(obj);
            //if (ModelState.IsValid)
            //{
            //    await _db.Infos.Update(obj);
            //    await _db.SaveChangesAsync();
            //    return RedirectToAction("Index");
            //}
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _infoService.GetById(id);
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int id)
        {
            _infoService.DeletePost(id);
            //FullInfo obj = await _db.Infos.FindAsync(id);
            //await _db.Infos.RemoveAsync(obj);
            //await _db.SaveChangesAsync();
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
