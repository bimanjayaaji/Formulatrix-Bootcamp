using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MarvelSnapDB;

public partial class MarvelSnap : DbContext
{
	private string _path = String.Empty;
	public virtual DbSet<Card> Cards { get; set; }
	public virtual DbSet<Player> Players { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		_path = @"D:\Learner\000 Work\230609 Formulatrix Bootcamp\Formulatrix Bootcamp\Formulatrix-Bootcamp\Project Master Week 7\DBMarvelSnap\MarvelSnap.db";
		string connectionPath = $"Data Source={_path}";
		optionsBuilder.UseSqlite(connectionPath);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
	}

	// 	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
	// 		=> optionsBuilder.UseSqlite("Filename=MarvelSnap.db");

	// 	protected override void OnModelCreating(ModelBuilder modelBuilder)
	// 	{
	// 		modelBuilder.Entity<Card>(entity =>
	// 		{
	// 			entity.Property(e => e.OwnerId).ValueGeneratedNever();
	// 		});

	// 		modelBuilder.Entity<Player>(entity =>
	// 		{
	// 			entity.Property(e => e.PlayerId).ValueGeneratedNever();
	// 		});

	// 		OnModelCreatingPartial(modelBuilder);
	// 	}


	// 	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
