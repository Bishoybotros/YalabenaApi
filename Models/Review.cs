using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YalabenaApi.Models
{
    public class Review
    {
        [Key]
        public int Review_Id { get; set; }

        [Required]
        [StringLength(500)] // Limit feedback length to 500 characters
        public string Review_Feedback { get; set; }

      
        public Activity Activity { get; set; }

      
        public User User { get; set; }
    }
}
