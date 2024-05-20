using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class SeatingPreference
    {
        [Key]
        public Guid SeatingPreferenceId { get; set; }
        [DisplayName("Name")]
        public string PreferenceDetails { get; set; }
    }
}
