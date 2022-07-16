using Christ3D.Application.Interfaces;
using Christ3D.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Christ3D.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentAppService studentAppService;
        public StudentController(IStudentAppService studentAppService)
        { 
            this.studentAppService = studentAppService;
        }
        [HttpGet]
        public IEnumerable<StudentViewModel> GetAll()
        {
            return studentAppService.GetAll();
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody]StudentViewModel studentViewModel)
        {
            studentAppService.Register(studentViewModel);
            return Ok(studentViewModel);
        }



    }
}
