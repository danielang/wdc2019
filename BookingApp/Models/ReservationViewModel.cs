using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class ReservationViewModel
    {
        public int ID { get; set; }

        public string GuestName { get; set; }

        public int HotelID { get; set; }
           
        public int AvailableRooms { get; set; }

        public int NoOfRooms { get; set; }
    }



}
