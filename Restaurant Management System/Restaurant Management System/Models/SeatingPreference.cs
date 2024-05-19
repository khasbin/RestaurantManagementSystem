namespace Restaurant_Management_System.Models
{
    public class SeatingPreference
    {
        public int SeatingPreferenceId { get; set; }    
        public int UserId { get; set; }
        public string PreferenceDetails { get; set; }
        public User User { get; set; }

    }
}
