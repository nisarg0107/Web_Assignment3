using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Assignment3_NisargPatel.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        public List<string> Images { get; set; } = new List<string>();

        [Required]
        public string Text { get; set; }
    }
}