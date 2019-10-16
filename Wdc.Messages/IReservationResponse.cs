using System;
using System.Collections.Generic;
using System.Text;

namespace Wdc.Messages
{
    interface IReservationResponse : IResponseBase
    {
        int ReservationId { get; set; }
    }
}
