using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_System.Models;
using Restaurant_Management_System.Models.Repositories;
using System.Security.Claims;

namespace Restaurant_Management_System.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ReservationController : Controller
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        public ReservationController(IReservationRepository reservationRepository, UserManager<User> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _reservationRepository = reservationRepository;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> CreateReservation(Reservation reservation)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            reservation.Id = currentUser.Id;

            if (ModelState.IsValid)
            {
                try
                {
                    reservation.ReservationId = reservation.Id;

                    var result = await _reservationRepository.CreateReseravationAsync(currentUser.Id, reservation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Error creating reservation: " + ex.Message);
                }
            }
            return View(reservation);
        }


        [Authorize]
        public async Task<IActionResult> CreateReservation()
        {
            return View();
        }

    }
}
