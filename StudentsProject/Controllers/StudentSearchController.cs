using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentBLL.ViewModel;

namespace StudentsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentSearchController : ControllerBase
    {
        public ActionResult<StudentViewModel> GetStudent(int id)
        {
           
            return NoContent();
        }
    }
}