using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Services
{
    public interface IAddToDatabase
    {
         void AddStudentToDB(StudentModel student);
    }
}
