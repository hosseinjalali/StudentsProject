using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly StudentDbContext studentDbContext;

        public Repository(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }
        public TEntity GetById(int id)
        {
           var student= studentDbContext.Set<TEntity>().Find(id);
            return student;
        }

        public void Add(TEntity entity)
        {
            studentDbContext.Set<TEntity>().Add(entity);    
        }
        public void Save()
        {
            studentDbContext.SaveChanges();
        }
    }
}
