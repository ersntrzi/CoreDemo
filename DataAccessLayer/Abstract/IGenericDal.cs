﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> ListAll();
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetById(int id);
    }
}
