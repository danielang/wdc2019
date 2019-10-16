using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNETCoreArchitektuenWorkShop.Database;
using DotNETCoreArchitektuenWorkShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNETCoreArchitektuenWorkShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        // GET api/hotels
        [HttpGet]
        public ActionResult<List<Hotel>> Get()
        {
            DatabaseHotel dbQ = new DatabaseHotel();
            return dbQ.selectAll();
        }

        // GET api/hotels/5
        [HttpGet("{id}")]
        public ActionResult<Hotel> Get(Int64 id)
        {
            DatabaseHotel dbQ = new DatabaseHotel();
            return dbQ.selectById(id);
        }

        // POST api/hotels
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/hotels/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Int16 bookedRooms)
        {
            DatabaseHotel dbQ = new DatabaseHotel();
            Hotel hotel = dbQ.selectById(id);

            var remainingRooms = hotel.rooms_curr - bookedRooms;

            if (remainingRooms >= 0)
            {
                dbQ.updateHotel(id, (Int16)remainingRooms);
            }
        }

        // DELETE api/hotels/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
