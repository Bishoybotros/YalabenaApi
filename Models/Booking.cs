using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YalabenaApi.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string PaymentStatus { get; set; }
       
        public int UserId { get; set; } 
        public User User { get; set; }
       
       

        public Itinerary Itinerary { get; set; }

        [Required]
        [DataType(DataType.CreditCard)]
        public PaymentMethod PaymentMethod { get; set; }
    }

}
