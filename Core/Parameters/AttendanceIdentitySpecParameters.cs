namespace Core.Parameters
{
    public class AttendanceIdentitySpecParameters
    {
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 20;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value;
        }

        private string _search;

        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }

        public int? EmployeeNumberId { get; set; }
    }
}