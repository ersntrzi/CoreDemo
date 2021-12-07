using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Add(T item)
        {
            c.Add(item);
            c.SaveChanges();
        }

        public void Delete(T item)
        {
            c.Remove(item);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> ListAll()
        {
            return c.Set<T>().ToList();
        }

        public void Update(T item)
        {
            c.Update(item);
            c.SaveChanges();
        }


        public List<T> ListAll(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
