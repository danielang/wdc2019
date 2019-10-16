using System;
using System.Collections.Generic;
using System.Text;

namespace Wdc.Messages
{
    interface IMessageBase
    {
        Guid Id { get; set; }
        string Type { get; set; }
    }
}
