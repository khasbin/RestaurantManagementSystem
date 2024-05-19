using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Eneter your user name.")]
        [StringLength(50)]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Eneter your First Name.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Eneter your Last Name.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        public string ContantNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Address1 { get; set; }
        public DateTime DOB { get; set; }
        public int RoleId { get; set; }


        public UserRole Role { get; set; }
        public SeatingPreference SeatingPreference { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
