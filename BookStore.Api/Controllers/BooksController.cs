/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */

using BookStore.Domain;
using BookStore.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore.Api.Controllers
{
    /// <summary>
    /// Controller class for the Books API
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IDataRepository<Book, long> _iBookRepo;        
        
        public BooksController(IDataRepository<Book, long> repo)
        {
            _iBookRepo= repo;
        }

        /// <summary>
        /// Gets all the book from the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("all")]
        public IEnumerable<Book> Get()
        {
            return _iBookRepo.GetAll();
        }

        /// <summary>
        /// Get the book for the given id if found otherwise null
        /// </summary>
        /// <param name="Id">Id of the book to fetch</param>
        /// <returns>A book object</returns>
        [HttpGet]
        [Route("id")]
        public Book Get(long Id)
        {
            return _iBookRepo.Get(Id);
        }

        [HttpGet]
        [Route("find")]
        public string Find(long Id)
        {
            return "Not implemented";
        }

        /// <summary>
        /// Create a new book record in the database
        /// </summary>
        /// <param name="book">An object of type book with detail information</param>
        [HttpPost]
        [Route("add")]
        public void Create([FromBody]Book book)
        {
            _iBookRepo.Add(book);
        }

        /// <summary>
        /// Delete a book for the given Id if found otherwise returns without performing any operation
        /// </summary>
        /// <param name="Id">Id of the book to delete</param>
        /// <returns>Id of the deleted book</returns>
        [HttpDelete]
        public long Delete(long Id)
        {
            return _iBookRepo.Delete(Id);
        }
    }
}
