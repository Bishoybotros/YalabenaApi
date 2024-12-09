using System.ComponentModel.DataAnnotations;

namespace YalabenaApi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }

        public int Age { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public string Country { get; set; }
        public string Preferences { get; set; }

        public ICollection<Itinerary> Itineraries { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Preference> UserPreferences { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<UserActivity> Activities { get; set; }
    }

}
