using Cinema.Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models.Domain
{
    public class UserCart
    {
        public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public CinemaUser Owner { get; set; }
        public virtual ICollection<TicketInUserCart> TicketInUserCarts { get; set; }
    }
}
