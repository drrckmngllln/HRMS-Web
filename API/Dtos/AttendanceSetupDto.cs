using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class AttendanceSetupDto
    {
        public int Id { get; set; }
        [Required]
        public string Category  { get; set; }
        [Required]
        public string TimeIn { get; set; }
        [Required]
        public string TimeOut { get; set; }
        [Required]
        public int GracePeriod { get; set; }
    }
}