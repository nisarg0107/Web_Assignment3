using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment3_NisargPatel.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public List<OrderProduct> Products { get; set; } = new List<OrderProduct>();

        [Required]
        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }

    public class OrderProduct
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