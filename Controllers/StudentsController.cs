using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public readonly IStudentsService _service;
        public readonly IGroupService _groupservice;
        public StudentsController(IStudentsService service, IGroupService groupService)
        {
            _service = service;
            _groupservice = groupService;
        }

        [HttpGet("Students")]
        public async Task<IActionResult> GetAll()
        {
            List<Student> students = await _service.GetAllStudentsAsync();
            return Ok(students);
        }

        [HttpGet("Groups")]
        public async Task<IActionResult> GetAllGroups()
        {
            List<Group> groups = await _groupservice.GetAllGroupAsync();
            return Ok(groups);
        }
        //[HttpGet("ByID")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    Student? student = await _context.Students.FindAsync(id);
        //    return Ok(student);
        //}
    }
}
