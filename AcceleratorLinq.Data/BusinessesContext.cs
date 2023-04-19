using AcceleratorLinq.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AcceleratorLinq.Data;

public class BusinessesContext : DbContext
{
    public DbSet<Business> Businesses { get; set; }
    public DbSet<Shareholder> Shareholders { get; set; }

    public readonly string DbPath;

    public BusinessesContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        
        DbPath = Path.Join(path, "businesses.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options
            .UseSqlite($"Data Source={DbPath}")
            .LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });
}



