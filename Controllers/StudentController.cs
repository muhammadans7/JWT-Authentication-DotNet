using jwt.models;
using jwt.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace jwt.Controllers{

    [ApiController]
    [Route("api/[Controller]")]
    [Authorize]
    public class StudentController : ControllerBase{

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService){
            _studentService = studentService;
        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<IActionResult> Add(Student student){

            await _studentService.AddStudent(student);
            return Ok("added");
        }


    }
}