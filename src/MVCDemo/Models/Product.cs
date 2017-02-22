using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Product
    {
        [Required(ErrorMessage ="ID is required")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(25, MinimumLength =2, ErrorMessage ="Name should be 2..25 characters long")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal AmountDue { get
            {
                return Quantity * Price;
            }
        }
    }
}
