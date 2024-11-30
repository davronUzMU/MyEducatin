using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyEducatin.AllDTO.CategoryDTO;
using MyEducatin.AllDTO.SubjectDTO;
using MyEducatin.Services;

namespace MyEducatin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectService _subjectService;
        public SubjectController(SubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        [HttpGet]
        public IActionResult GetSubjectAll()
        {
            try
            {
                var result = _subjectService.GetSubjectAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{Id}")]
        public IActionResult GetSubjectById(int Id)
        {
            try
            {
                var result = _subjectService.GetSubjectById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddSubject(SubjectRequestDTO subjectRequestDTO)
        {
            try
            {
                var result = _subjectService.AddSubject(subjectRequestDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{Id}")]
        public IActionResult EditSubject(int Id, SubjectRequestDTO subjectRequestDTO)
        {
            try
            {
                var result = _subjectService.EditSubject(Id, subjectRequestDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteSubject(int Id)
        {
            try
            {
                var result = _subjectService.DeleteSubjectById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
