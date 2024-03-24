using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class AttendanceDto
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string TimeIn { get; set; }
        public string TimeInRemarks { get; set; }
        public string TimeOut { get; set; }
        public string TimeOutRemarks { get; set; }
        public int Employee { get; set; }
    }
}