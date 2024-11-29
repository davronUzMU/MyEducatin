using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyEducatin.AllDTO.CategoryDTO;
using MyEducatin.AllDTO.CourseDTO;
using MyEducatin.Services;

namespace MyEducatin.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseService courseService;
        public CourseController(CourseService courseService)
        {
            this.courseService = courseService;
        }
        [HttpGet]
        public IActionResult GetCourseAll()
        {
            try
            {
                var result = courseService.GetCourseAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{Id}")]
        public IActionResult GetCourseById(int Id)
        {
            try
            {
                var result=courseService.GetCourseById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddCourse(CourseRequestDTO courseRequestDTO)
        {
            try
            {
                var result = courseService.AddCourse(courseRequestDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{Id}")]
        public IActionResult EditCourse(int Id,CourseRequestDTO courseRequestDTO)
        {
            try
            {
                var result = courseService.EditCourse(Id, courseRequestDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteCourse(int Id)
        {
            try
            {
                var result = courseService.DeleteCourseById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
