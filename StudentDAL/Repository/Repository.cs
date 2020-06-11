using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StudentDAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly StudentDbContext _studentDbContext;

        public Repository(StudentDbContext studentDbContext)
        {
            this._studentDbContext = studentDbContext;
        }
        public TEntity GetById(int id)
        {
           var student= _studentDbContext.Set<TEntity>().Find(id);
            return student;
        }

        public void Add(TEntity entity)
        {
            _studentDbContext.Set<TEntity>().Add(entity);    
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
           return _studentDbContext.Set<TEntity>().Where(predicate).ToList();
        }
    }
}
