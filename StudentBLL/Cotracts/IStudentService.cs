using StudentBLL.ViewModel;
using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentBLL.Services
{
    public interface IStudentService
    {
        void AddStudent(string StudentList);
        List<StudentViewModel> GetStudent(string student);
    }
}
