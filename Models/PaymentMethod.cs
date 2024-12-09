using System.ComponentModel.DataAnnotations;

namespace YalabenaApi.Models
{
    public class PaymentMethod
    {
        [Key]
        public int Payment_Id { get; set; }
        [Required]
        public string Type_of_method { get; set; }

        [Required]
        [DataType(DataType.CreditCard)]
        public string Details { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }

}
