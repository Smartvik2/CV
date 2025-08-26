using CV.DTOs;

namespace CV.Interface
{
    public interface IGalleryService
    {
        Task<GalleryDTO> UploadPhotoAsync(UploadPhotoDTO dto);
        Task<IEnumerable<GalleryDTO>> GetGalleryAsync();
    }
}
