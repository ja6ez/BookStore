/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */

using BookStore.Domain;
using BookStore.Domain.Models;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BookStore.Infrastructure
{
    public class BookAPI
    {
        private readonly string _apiBaseURI = "https://localhost:44334";
        public HttpClient InitializeClient()
        {
            var client = new HttpClient();
            //Passing service base url    
            client.BaseAddress = new Uri(_apiBaseURI);

            client.DefaultRequestHeaders.Clear();
            //Define request data format    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        public class BookDTO : IBookDto
        {
            public long Id { get; set; }
            [DisplayName("Book Name")]
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public Book Search(string Category)
            {
                throw new NotImplementedException();
            }
        }
    }
}
