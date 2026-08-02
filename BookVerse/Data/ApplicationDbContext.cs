using BookVerse.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookVerse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Category = "Self Help",
                    Description = "A practical guide to building good habits.",
                    Rating = 5,
                    CoverImage = "atomic-habits.jpg"
                },
                new Book
                {
                    Id = 2,
                    Title = "Rich Dad Poor Dad",
                    Author = "Robert Kiyosaki",
                    Category = "Finance",
                    Description = "A book about money, investing and financial education.",
                    Rating = 5,
                    CoverImage = "rich-dad-poor-dad.jpg"
                },
                new Book
                {
                    Id = 3,
                    Title = "Wings of Fire",
                    Author = "A.P.J. Abdul Kalam",
                    Category = "Biography",
                    Description = "The inspiring autobiography of A.P.J. Abdul Kalam.",
                    Rating = 5,
                    CoverImage = "wings-of-fire.jpg"
                }
            );
        }
    }
}
