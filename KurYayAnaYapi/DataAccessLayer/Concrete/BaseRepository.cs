using KurYayAnaYapi.DataAccessLayer.Abstract;
using KurYayAnaYapi.Models.Abstract;
using KurYayAnaYapi.Models.Concrete;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurYayAnaYapi.DataAccessLayer.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, IEntity, new()
    {

        /* Bu Kullanacak Olduğumuz Tablonun İsmi */
        string repoName;

        public BaseRepository(string repoName)
        {
            this.repoName = repoName;
        }

        /* Butun Tabloyu Listeleme */
        public List<T> GetAll()
        {
            var list = new List<T>();
            using (var db = new LiteDatabase(@"myDatabase.db"))
            {
                var items = db.GetCollection<T>(repoName);
                foreach (T item in items.FindAll())
                {
                    list.Add(item);
                }
            }
            return list;
        }

        /* Belirli Tek Kayit Getirme */
        public T GetById(int id, T model)
        {
            var result = new T();
            using (var db = new LiteDatabase(@"myDatabase.db"))
            {
                var item = db.GetCollection<T>(repoName);
                result = item.Find(x => x.Id == id).FirstOrDefault();
            }
            return result;
        }

        /* Yeni Bir Kayit Eklemek */
        public void AddModel(T model)
        {
            using (var db = new LiteDatabase(@"myDatabase.db"))
            {
                var items = db.GetCollection<T>(repoName);
                items.Insert(model);
            }
        }

        /* Bir Kayit Guncellemek */
        public void UpdateModel(T model)
        {
            using (var db = new LiteDatabase(@"myDatabase.db"))
            {
                var items = db.GetCollection<T>(repoName);
                items.Update(model);
            }
        }

        /* Bir Kayit Silmek */
        public void DeleteModel(int id)
        {
            using (var db = new LiteDatabase(@"myDatabase.db"))
            {
                var item = db.GetCollection<T>(repoName);
                item.Delete(id);
            }
        }

    }
}
