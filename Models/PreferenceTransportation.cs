namespace YalabenaApi.Models
{
    public class PreferenceTransportation
    {
        public int PreferenceId { get; set; }
        public int TransportId { get; set; }

        // Navigation Properties
        public Preference Preference { get; set; }
        public Transportation Transportation { get; set; }
    }

}
