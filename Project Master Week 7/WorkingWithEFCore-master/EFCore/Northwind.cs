using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;
namespace EFCore;

public  class Northwind: DbContext
{
	private string path = String.Empty;
	public DbSet<Product>? Products { get; set; }
	public DbSet<Category>? Categories { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
		string connectionPath = $"Data Source={path}";
		optionsBuilder.UseSqlite(connectionPath);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>()
			.Property(c => c.CategoryName)
			.IsRequired()
			.HasMaxLength(15);

		modelBuilder.Entity<Category>()
		.HasKey(c => c.CategoryId);
		
		if (Database.ProviderName?.Contains("Sqlite") ?? false)
		{
			modelBuilder.Entity<Product>()
			.Property(p => p.Cost)
			.HasConversion<double>();
		}
	}
}  
