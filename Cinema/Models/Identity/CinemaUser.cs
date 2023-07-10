using Cinema.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace Cinema.Models.Identity
{
    public class CinemaUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        //public bool Role { get; set; }

        public virtual UserCart UsersCart {  get; set; }

    }
}
