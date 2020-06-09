using StudentBLL.ViewModel;
using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentBLL.Services
{
    public interface IStudent
    {
        IEnumerable<StudentViewModel> AddStudent(string StudentList);
    }
}
