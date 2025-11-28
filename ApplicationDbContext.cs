using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CurriculumVitae.Models;

namespace CurriculumVitae.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CurriculumVitae.Models.CurriculumVitae> CurriculumVitae { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<CurriculumVitae.Models.CurriculumVitae>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.MiddleName).HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DateofBirth).IsRequired().HasMaxLength(20);
                entity.Property(e => e.PlaceofBirth).IsRequired().HasMaxLength(100);

                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .HasIndex(e => e.Email)
                    .IsUnique();
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.PhoneNumber)
                    .HasMaxLength(300);
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.Address)
                    .HasMaxLength(300);
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.Skills)
                    .HasMaxLength(100);
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.Interest)
                    .HasMaxLength(100);
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.Refrences)
                    .HasMaxLength(300);
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.MartialStatus)
                    .HasMaxLength(50);
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.Gender)
                    .HasMaxLength(20);
                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                    .Property(e => e.JobTitle)
                    .HasMaxLength(100);

                builder.Entity<CurriculumVitae.Models.CurriculumVitae>()
                     .ToTable("CurriculumVitaes");

            });
           
}
    }
}
