using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDAL.Model
{
    class DbContextFactory : IDesignTimeDbContextFactory<StudentDbContext>
    {
        public StudentDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder=new DbContextOptionsBuilder<StudentDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentDataBase-1;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new StudentDbContext(optionsBuilder.Options);
        }
    }
}
