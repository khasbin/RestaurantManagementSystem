using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_Management_System.Models
{
    public class ReservationHistory
    {
        [Key]
        public int ReservationHistoryId { get; set; }
        public int ReservationId { get; set; }
        public string ReservationName { get; set;}
        public string ReservationStatus { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("ReservationId")]
        public Reservation Reservation { get; set; }
    }
    
}
