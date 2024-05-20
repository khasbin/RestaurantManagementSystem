using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class Reservation
    {
        [Key]
        public Guid ReservationId { get; set; }  
        public Guid Id { get; set; }

        public Guid SeatingPrefereceId { get; set; }
        public Guid ReservationHistoryId { get; set; }  
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }   
        public int NumberofGuests { get; set; }

        public User User { get; set; }
        public ReservationHistory ReservationHistory { get; set; }
        public SeatingPreference SeatingPreference { get; set; }   
    }
}
