using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class SeatingPreference
    {
        [Key]
        public Guid SeatingPreferenceId { get; set; }    
        public Guid Id { get; set; }
        public string PreferenceDetails { get; set; }
        public User User { get; set; }

    }
}
