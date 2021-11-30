using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Add(Comment item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment item)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}
