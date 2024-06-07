using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;

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