using Microsoft.EntityFrameworkCore;
using RunGroupWA.Models;

namespace RunGroupWA.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .HasOne(c => c.AppUser)
                .WithMany()
                .HasForeignKey(c => c.AppUserId);

            modelBuilder.Entity<Club>()
                .HasOne(c => c.Address)
                .WithMany()
                .HasForeignKey(c => c.AddressId);
        }
    }
}
