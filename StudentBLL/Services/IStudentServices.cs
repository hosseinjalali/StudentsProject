using StudentBLL.ViewModel;
using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentBLL.Services
{
    public interface IStudentServices
    {
        void AddStudent(string StudentList);
        StudentViewModel GetStudent(int id);
    }
}
