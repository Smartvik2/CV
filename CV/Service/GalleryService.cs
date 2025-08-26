using CV.Data;
using CV.DTOs;
using CV.Interface;
using CV.Models;
using Microsoft.EntityFrameworkCore;

namespace CV.Service
{
    public class GalleryService : IGalleryService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public GalleryService(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<GalleryDTO> UploadPhotoAsync(UploadPhotoDTO dto)
        {
            if (dto.File == null || dto.File.Length == 0)
                throw new Exception("Invalid file");

            var uploadsFolder = Path.Combine(_env.WebRootPath ?? "wwwroot", "uploads");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.File.FileName)}";
            var filePath = Path.Combine(uploadsFolder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await dto.File.CopyToAsync(stream);
            }

            var galleryItem = new Gallery
            {
                Title = dto.Title,
                ImagePath = $"/uploads/{fileName}"
            };

            _context.GalleryItems.Add(galleryItem);
            await _context.SaveChangesAsync();

            return new GalleryDTO
            {
                Id = galleryItem.Id,
                Title = galleryItem.Title,
                ImageUrl = galleryItem.ImagePath,
                UploadedAt = galleryItem.UploadedAt
            };

        }

        public async Task<IEnumerable<GalleryDTO>> GetGalleryAsync()
        {
            return await _context.GalleryItems
                .OrderByDescending(x => x.UploadedAt)
                .Select(x => new GalleryDTO
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImagePath,
                    UploadedAt = x.UploadedAt
                })
                .ToListAsync();
        }
    }
}
