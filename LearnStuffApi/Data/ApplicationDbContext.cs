namespace Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class ApplicationDbContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		base.OnConfiguring(options);
		options.UseSqlite("Data Source=../Data/sqliteDatabase.db");
	}

	public DbSet<Author> Authors { get; set; }

	public DbSet<Title> Titles { get; set; }

	public DbSet<Book> Books { get; set; }

	public DbSet<Client> Cliens { get; set; }

	public DbSet<Borrow> Borrows { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Author>(entity =>
		{
			entity.ToTable("Authors");
		});

		modelBuilder.Entity<Title>(entity =>
		{
			entity.ToTable("Titles");

			entity.HasOne(t => t.Author)
				  .WithMany(a => a.Titles)
				  .HasForeignKey(t => t.AuthorId)
				  .IsRequired(true);
		});

		modelBuilder.Entity<Book>(entity =>
		{
			entity.ToTable("Books");

			entity.HasOne(b => b.Title)
				  .WithMany(t => t.Books)
				  .HasForeignKey(b => b.TitleId)
				  .IsRequired(true);
		});

		modelBuilder.Entity<Client>(entity =>
		{
			entity.ToTable("Clients");
		});

		modelBuilder.Entity<Borrow>(entity =>
		{
			entity.ToTable("Borrows");

			entity.HasOne(borrow => borrow.Book)
				  .WithMany(book => book.Borrows)
				  .HasForeignKey(borrow => borrow.BookId)
				  .IsRequired(true);

			entity.HasOne(b => b.Client)
				  .WithMany(c => c.Borrows)
				  .HasForeignKey(b => b.ClientId)
				  .IsRequired(true);
		});
	}

}
