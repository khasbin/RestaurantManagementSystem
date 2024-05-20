using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class User:IdentityUser<Guid>
    {

        [Required(ErrorMessage = "Please Eneter your First Name.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Eneter your Last Name.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        public string? Address1 { get; set; }
        public DateTime DOB { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<ReservationHistory> reservationHistories { get; set; }
    }
}
