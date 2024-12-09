namespace YalabenaApi.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        // Relationships
     
        public Booking Booking { get; set; }
       
        public PaymentMethod PaymentMethod { get; set; }
    }

}
