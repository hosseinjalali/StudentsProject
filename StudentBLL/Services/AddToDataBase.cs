using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Services
{
   public class AddToDataBase : IAddToDatabase
    {
        private readonly StudentDbContext studentDb;

        public AddToDataBase(StudentDbContext studentDb)
        {
            this.studentDb = studentDb;
        }
         public void AddStudentToDB(StudentModel student)
        {
            studentDb.Add(student);
            studentDb.SaveChanges();
        }
    }
}
