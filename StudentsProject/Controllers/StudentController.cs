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
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            this._studentService = studentService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] StudentsBulkInsertVM request)
        {
            _studentService.AddStudent(request.Students);
            return Ok();
        }

    }
}