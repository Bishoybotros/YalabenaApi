namespace YalabenaApi.Models
{
    public class ActivityTransportation
    {
        public int ActivityId { get; set; }
        public int TransportId { get; set; }

        // Navigation Properties
        public Activity Activity { get; set; }
        public Transportation Transportation { get; set; }
    }

}
