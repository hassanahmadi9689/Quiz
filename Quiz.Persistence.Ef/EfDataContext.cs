using Microsoft.EntityFrameworkCore;
using Quiz.Services.Team.Dtos;

namespace Quiz.Persistence.Ef;

public class EfDataContext : DbContext
{
    public DbSet<Entities.Team> Team { get; set; }
    public DbSet<Entities.Player> Player { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=Quiz2;\n" +
                                    "Trusted_Connection=true;TrustServerCertificate=yes");
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDataContext).Assembly);
        
    }
}