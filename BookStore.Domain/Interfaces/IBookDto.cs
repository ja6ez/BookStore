/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */

using BookStore.Domain.Models;

namespace BookStore.Domain
{
    public interface IBookDto
    {
        public Book Search(string Category);        

    }
}
