using CV.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CV.Api.Controllers
{
    [ApiController]
    [Route("api/cv")]
    public class CvApiController : ControllerBase
    {
        private readonly ICvService _cvService;

        public CvApiController(ICvService cvService)
        {
            _cvService = cvService;
        }

        [HttpGet("home")]
        public IActionResult GetHome()
        {
            try
            {
                return Ok(_cvService.GetHomeInfo());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpGet("about")]
        public IActionResult GetAbout()
        {
            try
            {
                return Ok(_cvService.GetAboutInfo());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpGet("experience")]
        public IActionResult GetExperience()
        {
            try
            {
                return Ok(_cvService.GetExperience());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpGet("projects")]
        public IActionResult GetProjects()
        {
            try
            {
                return Ok(_cvService.GetProjects());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpGet("skills")]
        public IActionResult GetSkills()
        {
            try
            {
                return Ok(_cvService.GetSkills());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpGet("education")]
        public IActionResult GetEducation()
        {
            try
            {
                return Ok(_cvService.GetEducation());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpGet("contact")]
        public IActionResult GetContact()
        {
            try
            {
                return Ok(_cvService.GetContactInfo());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

    }
}
