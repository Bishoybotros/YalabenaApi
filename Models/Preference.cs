using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YalabenaApi.Models
{
    public class Preference
    {
        [Key]
        public int Prre_Id { get; set; }
        public string TransportType { get; set; }



        public User User { get; set; }
        [DataType(DataType.Currency)]
        public int? Budget { get; set; }
        public int? Duration { get; set; }

        
        public ICollection<PreferenceTransportation> PreferenceTransportations { get; set; }
    }
}


