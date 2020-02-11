/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */

using BookStore.Domain;
using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Infrastructure
{
    /// <summary>
    /// Business logic for the BookStore
    /// </summary>
    public class BooksManager : IDataRepository<Book, long>
    {
        /// <summary>
        /// Readonly member variable for handling database context
        /// </summary>
        private readonly BookStoreDBContext _context;
        /// <summary>
        /// Constructor with DI for database context
        /// </summary>
        /// <param name="context"></param>
        public BooksManager(BookStoreDBContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Adds a new book object to the database
        /// </summary>
        /// <param name="b">Object of type Book with details</param>
        /// <returns>Id of the newly created book</returns>
        public long Add(Book b)
        {
            _context.Books.Add(b);
            long bookId = _context.SaveChanges();
            return bookId;
        }

        /// <summary>
        /// Delete a book by given Id
        /// </summary>
        /// <param name="id">Id of the book to delete</param>
        /// <returns>Id of the book that was deleted by this operation</returns>
        public long Delete(long id)
        {
            long bookId = 0;
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if(book!=null)
            {
                _context.Books.Remove(book);
                bookId = _context.SaveChanges();
            }
            return bookId;
        }

        /// <summary>
        /// Gets a book object for the given id
        /// </summary>
        /// <param name="id">Id of the book to read</param>
        /// <returns>Book object for the given Id if exists otherwise this will be null</returns>
        public Book Get(long id)
        {
            var book = _context.Books.FirstOrDefault(b=>b.Id == id);
            return book;
        }

        /// <summary>
        /// Gets a list of all available books
        /// </summary>
        /// <returns>List of all books from the database</returns>
        public IEnumerable<Book> GetAll()
        {
            var books = _context.Books.ToList();
            return books;
        }

        /// <summary>
        /// Update a given book object with the latest data provided
        /// </summary>
        /// <param name="id">Id of the Book to update</param>
        /// <param name="b">Book object with latest data</param>
        /// <returns>Id of the updated book</returns>
        public long Update(long id, Book b)
        {
            throw new NotImplementedException();
        }
    }
}
