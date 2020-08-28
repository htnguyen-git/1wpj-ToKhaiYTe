using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToKhaiYTe.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option)
            :base(option)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
        // Address
        public DbSet<Country> Country { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Ward> Ward { get; set; }

        public DbSet<Gate> Gate { get; set; }

        public DbSet<HistoryOfExposure> HistoryOfExposure { get; set; }
        public DbSet<PhatologicalSign> PhatologicalSign { get; set; }
        public DbSet<MedicalDeclarationForm> MedicalDeclarationForm { get; set; }
        public DbSet<TravelInfomation> TravelInfomation { get; set; }



    }
}
