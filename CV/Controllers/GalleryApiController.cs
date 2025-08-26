using CV.DTOs;
using CV.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CV.Api.Controllers
{
    [ApiController]
    [Route("api/gallery")]
    public class GalleryApiController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GalleryApiController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _galleryService.GetGalleryAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm] UploadPhotoDTO dto)
        {
            try
            {
                var result = await _galleryService.UploadPhotoAsync(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

    }
}
