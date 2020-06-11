using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentBLL.Services;
using StudentBLL.ViewModel;

namespace StudentsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentSearchController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentSearchController(StudentService studentService)
        {
            this._studentService = studentService;
        }

        public IActionResult GetStudents(string request)
        {
            var students= _studentService.GetStudent(request);
            return Ok(students);
            
        }
    }
}