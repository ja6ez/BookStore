/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Domain.Models
{
    /// <summary>
    /// Entity model for Book object
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Id of the book. This is unique and a key field.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        /// <summary>
        /// ISBN of the book. Not used. Defaults to ISBN format
        /// </summary>
        public string ISBN { get; set; } = "000-00-00000-00-0";
        /// <summary>
        /// Name of the book
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Author of the book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Category of the book
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Edition of the book based on published year
        /// </summary>
        public string Edition { get; set; }
        /// <summary>
        /// Price of the book
        /// </summary>
        public double Price { get; set; } = 1.0;
        /// <summary>
        /// Denotes the Unit of the price for example: Indian rupee (INR), US dollar (USD), Singapore dollar (SGD), Euros (EUR) and so on
        /// </summary>
        public string PriceUnit { get; set; } = "INR";
    }
}
