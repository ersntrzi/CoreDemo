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
        public void BlogAdd(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdatBlog(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
