using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using Youper.API.Patient.Domain.Model.Entities;

namespace Youper.API.Shared.Infrastuctures.Persistance.EFC.Configuration;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Recommendation> Recommendations { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<Music> Musics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aplica configuraciones si usas Fluent API
        base.OnModelCreating(modelBuilder);
    }
}