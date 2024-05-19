using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class DailySpecial
    {
        [Key]
        public Guid DailySpecialId { get; set; }
        public Guid MenuItemId { get; set; }
        public DateTime Date { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
