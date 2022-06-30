
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Model;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServices _crservice;
        public CourseController(ICourseServices crservice)
        {
            _crservice = crservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("GetCourses")]
        public IActionResult GetCourse()
        {
            return new ObjectResult(_crservice.GetAllCourse());
            // test code
        }
        [HttpPost]
        [Route("AddCourse")]
        public IActionResult AddCourse(Course cr)
        {
            return new ObjectResult(_crservice.AddCourse(cr));
        }
        [HttpPost]
        [Route("ModifyCourse")]
        public IActionResult ModifyProduct(Course cr)
        {
            return new ObjectResult(_crservice.ModifyCourse(cr));
        }
        [HttpGet]
        [Route("DeleteCourse/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return new ObjectResult(_crservice.DeleteCourse(id));
        }
    }
}
