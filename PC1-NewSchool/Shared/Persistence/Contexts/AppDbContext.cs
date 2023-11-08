using Microsoft.EntityFrameworkCore;
using PC1_NewSchool.Profiles.Domain.Models;
using PC1_NewSchool.Shared.Extensions;

namespace PC1_NewSchool.Shared.Persistence.Contexts;

/* Es la unica carpeta que se modifica de acuerdo al enunciado*/

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Student
        
        builder.Entity<Student>().ToTable("Students");
        builder.Entity<Student>().HasKey(p => p.Id);
        builder.Entity<Student>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd(); /*genera automaticamente el ID*/
        builder.Entity<Student>().Property(p => p.Name).IsRequired();
        builder.Entity<Student>().Property(p => p.DNI).IsRequired();
        builder.Entity<Student>().Property(p => p.gender).IsRequired();
        builder.Entity<Student>().Property(p => p.streetAddress).IsRequired();
        builder.Entity<Student>().Property(p => p.birthDate).IsRequired();
        builder.Entity<Student>().Property(p => p.speciality).IsRequired();
        
        // Apply Snake Case Naming Convention
        builder.UseSnakeCaseNamingConvention();

    }
    
}