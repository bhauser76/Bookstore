using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    //The class that represents each row in the database
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        [Required]
        public string BookPublisher { get; set; }
        [Required]
        public string BookISBN { get; set; }
        [Required]
        public string BookCategory { get; set; }

        //verification for ISBN13 book number
        [Required, RegularExpression(@"^\d{3}-\d{10}$")]
        public double BookPrice { get; set; }
        
        [Required]
        public int BookPages { get; set; }
    }
}
