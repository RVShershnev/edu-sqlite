using Edu.Domains;
using Microsoft.EntityFrameworkCore;

namespace Edu.EfCore.SqlLite;

internal class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }

    public string Path { get; set; }

    public BloggingContext()
    {
        Path = "blogging.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={Path}");
    }
}
