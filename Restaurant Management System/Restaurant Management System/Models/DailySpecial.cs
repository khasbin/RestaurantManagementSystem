namespace Restaurant_Management_System.Models
{
    public class DailySpecial
    {
        public int DailySpecialId { get; set; }
        public int MenuItemId { get; set; }
        public DateTime Date { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
