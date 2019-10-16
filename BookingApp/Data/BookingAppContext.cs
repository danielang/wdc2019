using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Models
{
    public class BookingAppContext : DbContext
    {
        public BookingAppContext(DbContextOptions<BookingAppContext> options)
            : base(options)
        {
        }

        public DbSet<BookingApp.Models.Hotel> Hotel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Hafen Hamburg",
                    Rooms = 10,
                    AvailableRooms = 10,

                },
                new Hotel
                {
                    ID = 2,
                    Name = "River Side Hamburg",
                    Rooms = 10,
                    AvailableRooms = 10,

                },
                new Hotel
                {
                    ID = 3,
                    Name = "St.PAuli Hamburg",
                    Rooms = 10,
                    AvailableRooms = 10,
                }
           );
        }
    }
}
