using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

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

        //[Required]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }

        public int Age { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public string Country { get; set; }
        // public string Preferences { get; set; }
        [AllowNull]
        public ICollection<Itinerary> Itineraries { get; set; }
        [AllowNull]
        public ICollection<Booking> Bookings { get; set; }
        [AllowNull]

        public Preference UserPreferences { get; set; }
        [AllowNull]

        public ICollection<Review> Reviews { get; set; }
        [AllowNull]

        public ICollection<UserActivity> Activities { get; set; }
        

       
    }

}
