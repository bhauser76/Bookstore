using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    //seed data to initially populate the database
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(


                    new Book
                    {
                        BookAuthor = "Victor Hugo",
                        BookCategory = "Fiction, Classic",
                        BookISBN = "978-0451419439",
                        BookPrice = 9.95,
                        BookPublisher = "Signet",
                        BookTitle = "Les Miserables",
                        BookPages = 1488,

                    },

                    new Book
                    {
                        BookAuthor = "Doris Kearns Goodwin",
                        BookCategory = "Non-Fiction, Biography",
                        BookISBN = "978-0743270755",
                        BookPrice = 14.58,
                        BookPublisher = "Simon & Shuster",
                        BookTitle = "Team of Rivals",
                        BookPages = 944,

                    },

                    new Book
                    {
                        BookAuthor = "Alice Schroeder",
                        BookCategory = "Non-Fiction, Biography",
                        BookISBN = "978-0553384611",
                        BookPrice = 21.54,
                        BookPublisher = "Bantam",
                        BookTitle = "The Snowball",
                        BookPages = 832,
                    },

                    new Book
                    {
                        BookAuthor = "Ronald C. White",
                        BookCategory = "Non-Fiction, Biography",
                        BookISBN = "978-0812981254",
                        BookPrice = 11.61,
                        BookPublisher = "Random House",
                        BookTitle = "American Ulysses",
                        BookPages = 864,
                    },

                    new Book
                    {
                        BookAuthor = "Laura Hillenbrand",
                        BookCategory = "Non-Fiction, Historical",
                        BookISBN = "978-0812974492",
                        BookPrice = 13.33,
                        BookPublisher = "Random House",
                        BookTitle = "Unbroken",
                        BookPages = 528,
                    },

                    new Book
                    {
                        BookAuthor = "Michael Crichton",
                        BookCategory = "Fiction, Historical Fiction",
                        BookISBN = "978-0804171281",
                        BookPrice = 15.95,
                        BookPublisher = "Vintage",
                        BookTitle = "The Great Train Robbery",
                        BookPages = 288,
                    },

                    new Book
                    {
                        BookAuthor = "Cal Newport",
                        BookCategory = "Non-Fiction, Self-Help",
                        BookISBN = "978-1455586691",
                        BookPrice = 14.99,
                        BookPublisher = "Grand Central Publishing",
                        BookTitle = "Deep Work",
                        BookPages = 304,
                    },

                    new Book
                    {
                        BookAuthor = "Michael Abrashoff",
                        BookCategory = "Non-Fiction, Self-Help",
                        BookISBN = "978-1455523023",
                        BookPrice = 21.66,
                        BookPublisher = "Grand Central Publishing",
                        BookTitle = "It's Your Ship",
                        BookPages = 240,
                    },

                    new Book
                    {
                        BookAuthor = "Richard Branson",
                        BookCategory = "Non-Fiction, Business",
                        BookISBN = "978-1591847984",
                        BookPrice = 29.16,
                        BookPublisher = "Portfolio",
                        BookTitle = "The Virgin Way",
                        BookPages = 400,
                    },

                    new Book
                    {
                        BookAuthor = "John Grisham",
                        BookCategory = "Fiction, Thrillers",
                        BookISBN = "978-0553393613",
                        BookPrice = 15.03,
                        BookPublisher = "Bantam",
                        BookTitle = "Sycamore Row",
                        BookPages = 642,
                    },
                    new Book
                    {
                        BookAuthor = "J.K. Rowling",
                        BookCategory = "Fantasy",
                        BookISBN = "978-0552293613",
                        BookPrice = 19.03,
                        BookPublisher = "Universal",
                        BookTitle = "Harry Potter and the Deathly Hallows",
                        BookPages = 1234,
                    },
                    new Book
                    {
                        BookAuthor = "Kim Scott",
                        BookCategory = "Self-Development",
                        BookISBN = "978-0512293653",
                        BookPrice = 12.05,
                        BookPublisher = "Health Studios",
                        BookTitle = "Radical Candor",
                        BookPages = 413,
                    },
                    new Book
                    {
                        BookAuthor = "Phil Knight",
                        BookCategory = "Biography",
                        BookISBN = "978-0554593613",
                        BookPrice = 21.03,
                        BookPublisher = "Nike",
                        BookTitle = "Shoe Dog",
                        BookPages = 333,
                    }


                );

                context.SaveChanges();
            }
        }
    }
}


