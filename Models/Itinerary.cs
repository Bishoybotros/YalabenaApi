using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace YalabenaApi.Models
{
    public class Itinerary
    {
        public int ItineraryID { get; set; }
        public string ItineraryName { get; set; }
        public string ItineraryActivities { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User User { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<UserActivity> Activities { get; set; }
    }

}
