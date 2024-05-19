using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Restaurant_Management_System.Models
{
    public class Reservation
    {
        [Key]
        public Guid ReservationId { get; set; }  
        public Guid Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }   
        public int NumberOfReservations { get; set; }
        public int NumberofGuests { get; set; }
        public int Capacity { get; set; }   

        public User User { get; set; }
        public ICollection<ReservationHistory> ReservationHistories { get; set; }   
    }
}
