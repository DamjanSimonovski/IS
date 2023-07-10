using Cinema.Models.Domain;
using Cinema.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data
{
    public class ApplicationDbContext : IdentityDbContext<CinemaUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<UserCart> UserCarts { get; set; }
        public virtual DbSet<TicketInUserCart> TicketInUserCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Ticket>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<UserCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<TicketInUserCart>()
                .HasKey(z => new { z.TicketId, z.UserCartId });

            builder.Entity<TicketInUserCart>()
                .HasOne(z => z.Ticket)
                .WithMany(z => z.TicketInUserCarts)
                .HasForeignKey(z => z.UserCartId);

            builder.Entity<TicketInUserCart>()
                .HasOne(z => z.UserCart)
                .WithMany(z => z.TicketInUserCarts)
                .HasForeignKey(z => z.TicketId);

            builder.Entity<UserCart>()
                .HasOne<CinemaUser>(z => z.Owner)
                .WithOne(z => z.UsersCart)
                .HasForeignKey<UserCart>(z => z.OwnerId);

        }
    }
}