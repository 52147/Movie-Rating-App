using Microsoft.EntityFrameworkCore;

namespace MovieRatingApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        // Add more DbSet properties for other entities as needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationships, constraints, etc., for your entities if necessary
            // For example, if you have a relationship between Movie and Rating:
            // modelBuilder.Entity<Rating>()
            //     .HasOne(r => r.Movie)
            //     .WithMany(m => m.Ratings)
            //     .HasForeignKey(r => r.MovieId);
        }
    }
}
