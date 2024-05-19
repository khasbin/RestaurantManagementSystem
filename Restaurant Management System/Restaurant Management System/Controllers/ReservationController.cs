using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_System.Models.Repositories;

namespace Restaurant_Management_System.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationRepository _reservationRepository;
        public ReservationController(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> CreateReservation()
        {
            return RedirectToAction(nameof(Index));
        } 

    }
}
