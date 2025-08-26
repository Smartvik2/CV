using CV.Models;
using Microsoft.EntityFrameworkCore;

namespace CV.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Gallery> GalleryItems => Set<Gallery>();
    }
}
