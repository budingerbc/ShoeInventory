using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeInventory.Models
{
    [Table("Shoes")]
    public class Shoe
    {
        [Key]
        public int ShoeId { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public virtual ApplicationUser User { get; set;}

        public Shoe()
        {
        }

        public Shoe(string brand, string color, decimal price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }
    }
}
