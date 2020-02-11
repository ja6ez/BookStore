/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */
using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Domain
{
    public class BookStoreDBContext : DbContext
    {
        /// <summary>
        /// DI for the database context
        /// </summary>
        /// <param name="options"></param>
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options)
            :base(options)
        {

        }

        /// <summary>
        /// DB set for the schema Book
        /// </summary>
        public DbSet<Book> Books { get; set; }
    }
}
