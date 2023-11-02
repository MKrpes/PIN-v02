using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> bookings = new List<HotelBooking>();
        public IActionResult Index(){
            return View(bookings);
        }

        public IActionResult Create(){
            HotelBooking booking= new HotelBooking();
            return View(booking);
        }

        public IActionResult CreateBooking(HotelBooking hotelBookingViewModel) {
            bookings.Add(hotelBookingViewModel);
            return RedirectToAction("Index");
        }
    }
}
