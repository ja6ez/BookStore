/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */

using BookStore.Domain;
using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BookStore.Infrastructure
{
    /// <summary>
    /// This class is for creating seed data if there are none at the time of launching the application
    /// </summary>
    public class DataGenerator : IDataGenerator
    {
        /// <summary>
        /// Seeds the basic data for the application to start up
        /// </summary>
        /// <param name="serviceProvider"></param>
        public void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BookStoreDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookStoreDBContext>>());
            // Look for any books.
            if (context.Books.Any())
            {
                return;   // Data was already seeded
            }

            context.Books.AddRange(
                new Book
                {
                    Id = 1,
                    Name = "Count of Monte Cristo",
                    Author = "Alexandre Dumas",
                    Category = "Adventure",
                    Edition = "4",
                    Price = 499.99,
                    PriceUnit = "INR"
                },
                new Book
                {
                    Id = 2,
                    Name = "Robinson Crusoe",
                    Author = "Daniel Defoe",
                    Category = "Fiction",
                    Edition = "2",
                    Price = 399.99,
                    PriceUnit = "INR"
                });

            context.SaveChanges();
        }
    }
}
