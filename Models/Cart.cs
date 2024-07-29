using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;

namespace Assignment3_NisargPatel.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public List<CartProduct> Products { get; set; } = new List<CartProduct>();

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }

    public class CartProduct
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}