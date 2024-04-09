using CountryCrud.Data;
using CountryCrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class InfoService : IInfoService
    {
        private readonly CountryDbContext _db;
        public InfoService(CountryDbContext db)
        {
            _db = db;
        }
        public async Task Create(FullInfo fullInfo)
        {
            _db.Infos.Add(fullInfo);
            await _db.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _db.Infos.Find(id);
        }

        public async Task DeletePost(int id)
        {
            FullInfo obj = await _db.Infos.FindAsync(id);
            _db.Infos.Remove(obj);
            await _db.SaveChangesAsync();
        }

        public void Edit(int id)
        {
            FullInfo obj = _db.Infos.Find(id);
        }

        public async Task Edit(FullInfo fullInfo)
        {
            _db.Infos.Update(fullInfo);
            await _db.SaveChangesAsync();
        }

        public async Task<List<FullInfo>> GetAll()
        {
            List<FullInfo> objCountryList = await _db.Infos.OrderByDescending(s => s.IsCapital == true).ToListAsync();
            return objCountryList;
        }

        public async Task<FullInfo> GetById(int id)
        {
            var item = await _db.Infos.Find(id);
            return item;
        }
    }
}
