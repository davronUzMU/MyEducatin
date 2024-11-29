using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyEducatin.AllDTO.CategoryDTO;
using MyEducatin.Models;
using MyEducatin.Services;

namespace MyEducatin.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService categoryService) {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetCategoryAll()
        {
            try
            {
                var result = _categoryService.GetCategoryAll();
                return Ok(result);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{Id}")]
        public IActionResult GetCategoryById(int Id) {
            try
            {
                var result = _categoryService.GetCategoryById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryRequestDTO category) {
            try
            {
                var result = _categoryService.AddCategory(category);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{Id}")]
        public IActionResult EditCategory(int Id, CategoryRequestDTO category)
        {
            try
            {
                var result = _categoryService.EditCategory(Id,category);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteCategory(int Id) {
            try
            {
                var result = _categoryService.DeleteCategoryById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
