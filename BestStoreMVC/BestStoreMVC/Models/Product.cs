using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

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

        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}
