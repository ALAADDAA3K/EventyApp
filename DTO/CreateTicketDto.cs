namespace EventyApp.DTO
{
    public struct CreateTicketDto
    {
        public int EventId { get; set; }
        public string BuyerName { get; set; }
        public string BuyerEmail { get; set; }
        public string SeatNumber { get; set; }
    }
}
