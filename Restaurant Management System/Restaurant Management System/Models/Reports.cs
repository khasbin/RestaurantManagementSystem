namespace Restaurant_Management_System.Models
{
    public class Reports
    {
        public int ReportsId { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Content { get; set; }
        public string ReportType { get; set; }
    }
}
