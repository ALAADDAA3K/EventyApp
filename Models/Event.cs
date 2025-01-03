namespace EventyApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public int AvailableSeats { get; set; }
        public int TicketsSold { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
