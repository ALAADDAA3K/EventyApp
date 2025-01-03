namespace EventyApp.DTO
{
    public struct TicketDto
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string BuyerName { get; set; }
        public string BuyerEmail { get; set; }
        public string SeatNumber { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
