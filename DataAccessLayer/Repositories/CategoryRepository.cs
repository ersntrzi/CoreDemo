using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();

        public void Add(Category item)
        {
            throw new NotImplementedException();
        }

       
        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

     

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAll()
        {
            throw new NotImplementedException();
        }

       
        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

    }
}
