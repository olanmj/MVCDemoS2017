using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Product
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        [StringLength(25, MinimumLength =2)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal AmountDue { get
            {
                return Quantity * Price;
            }
        }
    }
}
