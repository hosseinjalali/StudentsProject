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
        private readonly StudentServices studentservices;

        public StudentController(StudentServices studentServices)
        {
            this.studentservices = studentServices;
        }
        [HttpPost]
        public IActionResult Post([FromBody] string newStudentsVM)
        {
            studentservices.AddStudent(newStudentsVM.ToString());
            return Ok();
        }

    }
}