using System;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Models
{
    public class BookstoreDBContext : DbContext
    {
        public BookstoreDBContext(DbContextOptions<BookstoreDBContext> options):base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
