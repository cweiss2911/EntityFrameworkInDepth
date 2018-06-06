using Microsoft.EntityFrameworkCore;

namespace CodeFirstCore
{
    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Port=5432;Database=user;User Id=user;Password=password123;Search Path=corefist");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTag>()
                .HasKey(t => new { t.CourseId, t.TagId });
        }
    }
}
