using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookingApp.Models;

namespace BookingApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BookingApp.Models.BookingAppContext _context;

        public IndexModel(BookingApp.Models.BookingAppContext context)
        {
            _context = context;
        }

        public IList<ReservationViewModel> ReservationViewModel { get; set; }

        public async Task OnGetAsync()
        {
            var hotels = _context.Hotel.ToList();

            ReservationViewModel = new List<ReservationViewModel>();
            foreach (var hotel in hotels)
            {   

                ReservationViewModel.Add(
                    new Models.ReservationViewModel
                    {
                        HotelID = hotel.ID,
                        AvailableRooms = hotel.AvailableRooms
                    });
            }
        }

        public async Task<ActionResult> OnPostAsync()
        {
            return RedirectToPage(",/Index");
        }
    }
}
