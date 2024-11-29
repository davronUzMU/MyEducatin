using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyEducatin.AllDTO.CategoryDTO;
using MyEducatin.AllDTO.TestDTO;
using MyEducatin.Services;

namespace MyEducatin.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestService testService;
        public TestController(TestService testService) { 
            this.testService = testService;
        }
        [HttpGet]
        public IActionResult GetCategoryAll()
        {
            try
            {
                var result =testService.GetTestAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{Id}")]
        public IActionResult GetCategoryById(int Id)
        {
            try
            {
                var result =testService.GetTestById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddCategory(TestRequestDTO testRequestDTO)
        {
            try
            {
                var result =testService.AddTest(testRequestDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{Id}")]
        public IActionResult EditCategory(int Id, TestRequestDTO testRequestDTO)
        {
            try
            {
                var result =testService.EditTest(Id, testRequestDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteCategory(int Id)
        {
            try
            {
                var result =testService.DeleteTestById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
