using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{
    public class ProductDto
    {
        [MaxLength(100)]
        public string Title { get; set; } = "";

        [MaxLength(100)]
        public string Author { get; set; } = "";

        public string Description { get; set; } = "";

        public string ISBN { get; set; } = "";

        [Precision(16, 2)]
        public decimal Price { get; set; }

        [MaxLength(100)]
        public string Category { get; set; } = "";

        public IFormFile? ImageFile { get; set; }
    }
}
