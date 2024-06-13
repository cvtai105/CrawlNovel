using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Repository.Data;
public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    DbSet<Novel> Novels { get; set; }
    DbSet<Chapter> Chapters { get; set; }
    DbSet<Genre> Genres { get; set; }
    DbSet<Source> Sources { get; set; }
    DbSet<ChapterSource> ChapterSources { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChapterSource>()
            .HasKey(cs => new { cs.ChapterId, cs.SourceId });

        modelBuilder.Entity<ChapterSource>()
            .OwnsOne(cs => cs.ChapterUrl);

        modelBuilder.Entity<Source>()
            .OwnsOne(s => s.HostURL);

        modelBuilder.Entity<Source>()
            .OwnsOne(s => s.BooklistURL);
    }
}