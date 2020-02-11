/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */

using BookStore.Infrastructure;
using BookStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStore.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// API helper for Managing Books
        /// </summary>
        BookAPI bookAPI = new BookAPI();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Lists all books in the launch page
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            List<BookAPI.BookDTO> dto = new List<BookAPI.BookDTO>();
            HttpClient client = bookAPI.InitializeClient();

            HttpResponseMessage res = await client.GetAsync("api/books/all");

            //Checking the response is successful or not which is sent using HttpClient    
            if (res.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api     
                var result = res.Content.ReadAsStringAsync().Result;

                //Deserializing the response recieved from web api and storing into the Employee list    
                dto = JsonConvert.DeserializeObject<List<BookAPI.BookDTO>>(result);

            }
            //returning the employee list to view    
            return View(dto);            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
