using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YalabenaApi.Models
{
    public class Activity
    {
        [Key] 
        public int Activity_Id { get; set; }
        public string Activity_Name { get; set; }
        [DataType(DataType.Text)]
        public string Activity_Location { get; set; }
        
        
        [DataType(DataType.Currency)]

        public int Activity_Price { get; set; }
        public DateTime Activity_Duration { get; set; }



        //public User Users { get; set; }
        //public Itinerary Itineraries { get; set; }
        //public ICollection<Transportation> Transportations { get; set; }
        public ICollection<UserActivity> UserActivities { get; set; }
        public ICollection<ActivityTransportation> ActivityTransportations { get; set; }
    }


}
