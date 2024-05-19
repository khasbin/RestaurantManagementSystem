using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class MenuItem
    {
        [Key]
        public Guid MenuItemId { get; set; }

        [Required(ErrorMessage = "Please specify the name of the menu")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please specify a short description of the menu")]
        [StringLength(50)]
        public string ShortDescription { get; set; } = string.Empty;

        [StringLength(100)]
        public string LongDescription { get; set; } = string.Empty;
        public string Category { get; set; }

        [Required(ErrorMessage = "Please specify price for the menu")]
        public string Price { get; set; }
        public string AllergyInformation { get; set; }
        public bool isDishOfTheDay { get; set; }
        
        public ICollection<DailySpecial> DailySpecials { get; set; }

    }
}
