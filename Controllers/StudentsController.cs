using GenericRepositoryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public readonly IStudentsService _service;
        public StudentsController(IStudentsService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(bool isTracking, params string[] includes)
        {
            var datas = await _service.GetAllStudents(isTracking, includes);
            return Ok(datas);
        }
        //[HttpGet("ByID")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    Student? student = await _context.Students.FindAsync(id);
        //    return Ok(student);
        //}
    }
}
