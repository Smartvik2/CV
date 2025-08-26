using CV.DTOs;
using CV.Interface;
using Microsoft.AspNetCore.Mvc;

public class GalleryController : Controller
{
    private readonly IGalleryService _galleryService;

    public GalleryController(IGalleryService galleryService)
    {
        _galleryService = galleryService;
    }

    public async Task<IActionResult> Index()
    {
        try
        {
            var photos = await _galleryService.GetGalleryAsync();
            return View(photos);
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = $"An error occurred while loading the gallery: {ex.Message}";
            return View(Enumerable.Empty<GalleryDTO>()); // empty list so page still loads
        }
    }

    [HttpGet]
    public IActionResult Upload()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Upload(UploadPhotoDTO dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        try
        {
            await _galleryService.UploadPhotoAsync(dto);
            TempData["SuccessMessage"] = "Photo uploaded successfully!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = $"An error occurred while uploading: {ex.Message}";
            return View(dto);
        }
    }
}
