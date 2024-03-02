namespace Core.Parameters
{
    public class EmployeeSpecParameters
    {
        public const int MaxPageSize = 20;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value;
        }

        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        private string _search;

        public string Search
        {
            get => _search; 
            set => _search = value.ToLower();
        }
    }
}