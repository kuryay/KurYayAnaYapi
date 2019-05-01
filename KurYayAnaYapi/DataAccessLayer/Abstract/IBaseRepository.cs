using KurYayAnaYapi.Models.Abstract;
using KurYayAnaYapi.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurYayAnaYapi.DataAccessLayer.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity, IEntity, new()
    {
        List<T> GetAll();
        T GetById(int id, T model);
        void AddModel(T model);
        void UpdateModel(T model);
        void DeleteModel(int id);
    }
}
