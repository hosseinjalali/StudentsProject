using AutoMapper;
using StudentBLL.ViewModel;
using StudentDAL.Model;
using StudentDAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Services
{
    public class StudentServices : IStudentServices
    {
        
        private readonly IMapper mapper;
        private readonly IRepository<StudentModel> studentrepository;

        public StudentServices(IMapper mapper,IRepository<StudentModel> studentRepository)
        {
          
            this.mapper = mapper;
            this.studentrepository = studentRepository;
        }
        public StudentViewModel GetStudent(int id)
        {
            var student=studentrepository.GetById(id);
            var searchstudent = mapper.Map<StudentViewModel>(student);
            
            return searchstudent;
        }
        public void AddStudent(string StudentList)
        {
            string[] students = StudentList.Split("\n");
            foreach(string s in students)
            {
                string[] details = s.Split(",");
                var Newstudent = new StudentViewModel();
                Newstudent.Id = int.Parse(details[0]);
                Newstudent.Name = details[1];
                Newstudent.Family = details[2];
                var newstudent= mapper.Map<StudentModel>(Newstudent);
                studentrepository.Add(newstudent);
                studentrepository.Save();
                

            }
            
        }
       
    }
}
