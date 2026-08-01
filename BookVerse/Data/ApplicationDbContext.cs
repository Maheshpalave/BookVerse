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
    }
}