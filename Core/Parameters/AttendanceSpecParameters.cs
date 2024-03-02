namespace Core.Parameters
{
    public class AttendanceSpecParameters
    {
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value;
        }

        public int? EmployeeId { get; set; }
        private string _search;

        public string Search
        {
            get => _search;
            set => _search = value;
        }
    }
}