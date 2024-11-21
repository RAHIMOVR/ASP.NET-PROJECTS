using Microsoft.EntityFrameworkCore;
using MoviePark.Models;

namespace MoviePark.Data
{
    public class MovieParkContext : DbContext
    {
        public MovieParkContext(DbContextOptions<MovieParkContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Movie>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
