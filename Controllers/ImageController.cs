using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyEducatin.Services;

namespace MyEducatin.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly ImageService imageService;
        public ImageController(ImageService imageService) { 
            this.imageService = imageService;
        }
        [HttpGet]
        public IActionResult GetImage()
        {
            try
            {
                var result = imageService.GetImage();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{Id}")]
        public IActionResult GetImageById(int Id)
        {
            try
            {
                var result = imageService.GetImageById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddImage(IFormFile formFile)
        {
            try
            {
                var result = imageService.AddImage(formFile);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteImage(int Id)
        {
            try
            {
                var result = imageService.DeleteImage(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
