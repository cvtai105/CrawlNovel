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

}