using BookListingMicroService.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BookListingMicroService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book
            {
                bookId = 1,
                title = "Atomic Habits",
                author = "James Clear",
                genre = "Self Help book",
                bookCondition = "Good",
                availability = "Available"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                bookId = 2,
                title = "The Fountainhead",
                author = "Ayn Rand",
                genre = "Philosophical fiction",
                bookCondition = "Good",
                availability = "Available"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                bookId = 3,
                title = "Rich Dad Poor Dad",
                author = "Robert Kiyosaki and Sharon Lechter",
                genre = "Personal finance",
                bookCondition = "Good",
                availability = "Available"
            });
        }
    }
}
