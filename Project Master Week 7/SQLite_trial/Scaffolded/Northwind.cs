using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore.AutoGen;

public partial class Northwind : DbContext
{
	private string path = String.Empty;
	
	// public Northwind()
	// {
	// }

	// public Northwind(DbContextOptions<Northwind> options)
	//     : base(options)
	// {
	// }

	public virtual DbSet<Employee> Employees { get; set; }
	public virtual DbSet<Order> Orders { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseSqlite("Filename=Northwind.db");

//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.Entity<Employee>(entity =>
//         {
//             entity.Property(e => e.EmployeeId).ValueGeneratedNever();
//         });

//         modelBuilder.Entity<Order>(entity =>
//         {
//             entity.Property(e => e.OrderId).ValueGeneratedNever();
//             entity.Property(e => e.Freight).HasDefaultValueSql("0");
//         });

//         OnModelCreatingPartial(modelBuilder);
//     }

//     partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		path = Path.Combine(Environment.CurrentDirectory,"Northwind.db");
		string connectionPath = $"Data Source={path}";
		optionsBuilder.UseSqlite(connectionPath);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		if (Database.ProviderName?.Contains("Sqlite") ?? false)
		{
			modelBuilder.Entity<Order>()
			.Property(p => p.Freight)
			.HasConversion<double>();
		}
	}
}
