namespace EventyApp.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string BuyerName { get; set; }
        public string BuyerEmail { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SeatNumber { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
