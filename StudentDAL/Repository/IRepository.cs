using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StudentDAL.Repository
{
   public interface IRepository<TEntity> where TEntity:class
    {
        TEntity GetById(int id);
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
