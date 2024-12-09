using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YalabenaApi.Models
{
    public class Transportation
    {
        [Key]
        public int Transport_Id { get; set; }
        public string Transport_Type { get; set; }
        public string Transport_Rout { get; set; }
        [DataType(DataType.Currency)]
        public int Transport_Cost { get; set; }
        public DateTime Activity_Duration { get; set; }




        //public Activity Activities { get; set; }
        // public Preference Preferences { get; set; }
        public ICollection<ActivityTransportation> ActivityTransportations { get; set; }
        public ICollection<PreferenceTransportation> PreferenceTransportations { get; set; }
    
}

}
