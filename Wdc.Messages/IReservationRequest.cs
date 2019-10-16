using System;
using System.Collections.Generic;
using System.Text;

namespace Wdc.Messages
{
    interface IReservationRequest : IMessageBase
    {
        string Name { get; set; }

        int HotelId { get; set; }

        int RoomsToBook { get; set; }
    }
}
