using EpsilonLocal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace EpsilonLocal.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
    
        }

        public DbSet<EpExpense> EpExpenses { get; set; }
        public DbSet<EpPayable> EpPayables { get; set; }
        public DbSet<EtExpense> EtExpenses { get; set; }
        public DbSet<EtPayable> EtPayables { get; set; }
        public DbSet<EpReceivable> EpReceivables { get; set; }
        public DbSet<EtReceivable> EtReceivables { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }





    }
}

