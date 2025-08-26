namespace CV.DTOs
{
    public class UploadPhotoDTO
    {
        public string Title { get; set; } = string.Empty;
        public IFormFile File { get; set; }
    }
}
