using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class Gallery
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public string? ImagePath { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}
