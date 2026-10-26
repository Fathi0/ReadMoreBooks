using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMoreBooks.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime PublishedYear { get; set; }
        public bool IsInStock { get; set; }
    }
}
