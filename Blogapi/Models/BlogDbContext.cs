using Microsoft.EntityFrameworkCore;

namespace Blogapi.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext()
        {

        }

        public BlogDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Blogger> bloggers { get; set; }
        public DbSet<Post> posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; database=blog; user=root; password=");
        }
    }
}
