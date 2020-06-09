using AutoMapper;
using StudentBLL.ViewModel;
using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Services
{
    public class Student : IStudent
    {
        private readonly StudentViewModel studentViewModel;
        private readonly IMapper mapper;
        private readonly AddToDataBase addToDataBase;

        public Student(StudentViewModel studentViewModel,IMapper mapper,AddToDataBase addToDataBase)
        {
            this.studentViewModel = studentViewModel;
            this.mapper = mapper;
            this.addToDataBase = addToDataBase;
        }
        public void AddStudent(string StudentList)
        {
            string[] students = StudentList.Split("\n");
            foreach(string s in students)
            {
                string[] details = s.Split(",");
                studentViewModel.Id = int.Parse(details[0]);
                studentViewModel.Name = details[1];
                studentViewModel.Family = details[2];
                var newstudent= mapper.Map<StudentModel>(studentViewModel);
                addToDataBase.AddStudentToDB(newstudent);

            }
            
        }
       
    }
}
