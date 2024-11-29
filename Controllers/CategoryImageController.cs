using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyEducatin.Models;
using MyEducatin.Services;

namespace MyEducatin.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryImageController : ControllerBase
    {
        private readonly CategoryImageService _categoryImageService;
        public CategoryImageController(CategoryImageService categoryImageService) {
            _categoryImageService = categoryImageService;
        }
        [HttpGet]
        public IActionResult GetCategoryImage()
        {
            try
            {
                var result = _categoryImageService.GetCategoryImage();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{Id}")]
        public IActionResult GetCategoryImageById(int Id)
        {
            try
            {
                var result = _categoryImageService.GetCategoryImageById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddCategoryImage(IFormFile formFile) {
            try
            {
                var result = _categoryImageService.AddCategoryImage(formFile);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteCategoryImage(int Id) {
            try
            {
                var result = _categoryImageService.DeleteCategoryImage(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
