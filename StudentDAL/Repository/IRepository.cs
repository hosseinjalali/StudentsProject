using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDAL.Repository
{
   public interface IRepository<TEntity> where TEntity:class
    {
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Save();
    }
}
