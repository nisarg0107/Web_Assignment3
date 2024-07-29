using System.ComponentModel.DataAnnotations;


namespace Assignment3_NisargPatel.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Username { get; set; }

        public List<string> PurchaseHistory { get; set; } = new List<string>();

        public string ShippingAddress { get; set; }
    }
}