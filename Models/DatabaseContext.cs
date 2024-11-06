using Microsoft.EntityFrameworkCore;


namespace URLShortenerCSReact.Models;

public class DatabaseContext : DbContext
{
  
  public DatabaseContext(DbContextOptions options)
      : base(options) { }

  public DbSet<URLModel> URLs => Set<URLModel>();
  public DbSet<UserModel> Users => Set<UserModel>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UserModel>()
      .HasMany(e => e.URLs)
      .WithOne(e => e.User)
      .HasForeignKey(e => e.UserId);

    modelBuilder.Entity<URLModel>(builder =>
    {
      builder
        .Property(e => e.Code)
        .IsRequired() // TODO: check if it's is necessary and doesn't break
        .HasMaxLength(7);

      builder
        .HasIndex(e => e.Code)
        .IsUnique();

      builder
        .Property(e => e.OriginalURL)
        .IsRequired();
      
    });
      
  }
}