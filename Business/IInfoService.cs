using CountryCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IInfoService
    {
        Task <List<FullInfo>> GetAll();
        Task Create(FullInfo fullInfo);
        void Edit(int id);
        Task Edit(FullInfo fullInfo);
        void Delete(int id);
        Task DeletePost(int id);
        Task<FullInfo>GetById(int id);
    }
}
