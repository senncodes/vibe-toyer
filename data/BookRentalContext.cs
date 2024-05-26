using Microsoft.EntityFrameworkCore;
using BookRentalApi.Models;

public class BookRentalContext : DbContext
{
    public BookRentalContext(DbContextOptions<BookRentalContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Library> Libraries { get; set; }
    public DbSet<Rental> Rentals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Library>()
            .HasMany(l => l.Books)
            .WithOne(b => b.Library)
            .HasForeignKey(b => b.LibraryId);

        modelBuilder.Entity<Book>()
            .HasMany(b => b.Rentals)
            .WithOne(r => r.Book)
            .HasForeignKey(r => r.BookId);
    }
}
