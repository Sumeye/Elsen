﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO
{
    interface IRepository<T> where T:class
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemId);
        List<T> SelectAll();
        T SelectById(int itemId); 
    }
}
