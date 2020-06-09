using StudentBLL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Services
{
    public class Student : IStudent
    {
        private readonly StudentViewModel studentViewModel;

        public Student(StudentViewModel studentViewModel)
        {
            this.studentViewModel = studentViewModel;
        }
        public IEnumerable<StudentViewModel> AddStudent(string StudentList)
        {
            string[] students = StudentList.Split("\n");
            foreach(string s in students)
            {
                string[] details = s.Split(",");
                studentViewModel.Id = int.Parse(details[0]);
                studentViewModel.Name = details[1];
                studentViewModel.Family = details[2];
            }
            throw new NotImplementedException();
        }
    }
}
