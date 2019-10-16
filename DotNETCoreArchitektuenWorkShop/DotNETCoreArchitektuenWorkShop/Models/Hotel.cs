using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNETCoreArchitektuenWorkShop.Models
{
    public class Hotel
    {
        public Int64 id { get; set; }
        public String name { get; set; }
        public Int16 rooms_max { get; set; }
        public Int16 rooms_curr { get; set; }

    }
}
