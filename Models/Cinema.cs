namespace EventyApp.Models
{
    public class Cinema : Event
    {
        public string MovieTitle { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
    }
}
