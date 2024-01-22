using Microsoft.EntityFrameworkCore;
using Test_NANY.Data.Models;
using Test_NANY.Data.ViewModels;

namespace Test_NANY.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Registration> Registration { get; set; }

        public DbSet<ChildProfile> ChildProfile { get; set; }
        public DbSet<NanyProfile> NanyProfile { get; set; }


        public DbSet<ShiftViewModel> Shift { get; set; }


        public DbSet<NanySchedule> NanySchedule { get; set; }


    }
}
