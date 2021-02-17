using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
namespace OnlineBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Fiction",
                        Price = 9.95
                    },

                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Classic",
                        Price = 9.95
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
