using System.ComponentModel.DataAnnotations;

namespace Restaurant_Management_System.Models
{
    public class Reports
    {
        [Key]
        public Guid ReportsId { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Content { get; set; }
        public string ReportType { get; set; }
    }
}
