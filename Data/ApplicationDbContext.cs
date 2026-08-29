using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CHINTAI.Models;


namespace CHINTAI.Data
{

    public class ApplicationDbContext
        : IdentityDbContext
    {


        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }



        public DbSet<CrimeCategory> CrimeCategories { get; set; }



        public DbSet<Location> Locations { get; set; }



        public DbSet<CrimeReport> CrimeReports { get; set; }



        public DbSet<CrimeImage> CrimeImages { get; set; }



        public DbSet<CrimeRiskScore> CrimeRiskScores { get; set; }



        public DbSet<SavedLocation> SavedLocations { get; set; }



        public DbSet<Notification> Notifications { get; set; }


    }

}
