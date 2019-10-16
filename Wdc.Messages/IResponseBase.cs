using System;
using System.Collections.Generic;
using System.Text;

namespace Wdc.Messages
{
    interface IResponseBase : IMessageBase
    {
        bool Success { get; set; }
        string Error { get; set; }
    }
}
