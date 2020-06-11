using AutoMapper;
using StudentBLL.ViewModel;
using StudentDAL.Model;
using StudentDAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Services
{
    public class StudentService : IStudentService
    {
        
        private readonly IMapper _mapper;
        private readonly IRepository<StudentModel> _studentRepository;
        private readonly StudentDbContext _dbContext;

        public StudentService(IMapper mapper,IRepository<StudentModel> studentRepository,StudentDbContext dbContext)
        {
          
            this._mapper = mapper;
            this._studentRepository = studentRepository;
            this._dbContext = dbContext;
        }
        public List<StudentViewModel> GetStudent(string studentsRequest)
        {
            var students = _studentRepository.GetAll(s=>s.Name== studentsRequest ^ s.Family==studentsRequest);
            var allStudents = _mapper.Map<List<StudentViewModel>>(students);
            
            return allStudents;
        }
        public void AddStudent(string StudentList)
        {
            string[] students = StudentList.Split("\n");
            foreach(string s in students)
            {
                string[] details = s.Split(",");
                var newStudent = new StudentViewModel();
                newStudent.Id = int.Parse(details[0]);
                newStudent.Name = details[1];
                newStudent.Family = details[2];
                var student= _mapper.Map<StudentModel>(newStudent);
                _studentRepository.Add(student);
                _dbContext.SaveChanges();
                
                

            }
            
        }
       
    }
}
