namespace Cinema.Models.Domain
{
    public class TicketInUserCart
    {
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public Guid UserCartId { get; set; }
        public UserCart UserCart { get; set; }

        public int Quantity { get; set; }
    }
}
