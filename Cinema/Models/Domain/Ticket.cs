using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string MovieImage { get; set; }
        [Required]
        public string MovieDirector { get; set; }
        [Required]
        public string MovieDescription { get; set; }
        [Required]
        public string MovieGenre { get; set; }
        [Required]
        public DateTime MovieDateTime { get; set; }
        [Required]
        public int TicketPrice { get; set; }
        [Required]
        public virtual ICollection<TicketInUserCart> TicketInUserCarts { get; set; }
    }
}
