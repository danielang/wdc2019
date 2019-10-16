using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class Reservation
    {
        public int HotelID { get; set; }

        public int GuestID { get; set; }

        public int Rooms { get; set; }

    }
}
