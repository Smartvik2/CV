namespace CV.DTOs
{
    public class GalleryDTO
    {
        public Guid Id { get; set; }
        public string? Title { get; set; } 
        public string? ImageUrl { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
