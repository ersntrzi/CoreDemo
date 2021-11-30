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
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog item)
        {
            throw new NotImplementedException();
        }

     
        public void Delete(Blog item)
        {
            throw new NotImplementedException();
        }

        

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAll()
        {
            throw new NotImplementedException();
        }
        public void Update(Blog item)
        {
            throw new NotImplementedException();
        }
    }
}
