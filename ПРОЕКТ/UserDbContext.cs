using Microsoft.EntityFrameworkCore;

namespace ПРОЕКТ;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<ResponsPerson> ResponsePersoms { get; set; }
    public DbSet<FixedAsset> FixedAssets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<StateFixedAsset> StateFixedAssets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=project;User=root;Password=;", new MySqlServerVersion(new Version(8, 0, 22)));

    public UserDbContext()
    {
        Database.EnsureCreated();
    }
}
