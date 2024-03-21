using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class AttendanceDto
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime TimeIn { get; set; }
        [Required]
        public string TimeInRemarks { get; set; }
        [Required]
        public DateTime TimeOut { get; set; }
        [Required]
        public string TimeOutRemarks { get; set; }
        [Required]
        public int Employee { get; set; }
    }
}