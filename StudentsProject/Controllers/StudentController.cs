using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentBLL.Services;
using StudentBLL.ViewModel;
using StudentDAL.Model;

namespace StudentsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Student student;

        public StudentController(Student student)
        {
            this.student = student;
        }
        [HttpPost]
        public IActionResult Post([FromBody] string NewStudents)
        {
            student.AddStudent(NewStudents.ToString());
            return Ok();
        }

    }
}