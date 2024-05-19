using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Management_System.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
