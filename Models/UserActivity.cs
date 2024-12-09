namespace YalabenaApi.Models
{
    public class UserActivity
    {
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public int ItineraryId { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Activity Activity { get; set; }
        public Itinerary Itinerary { get; set; }
    }

}
