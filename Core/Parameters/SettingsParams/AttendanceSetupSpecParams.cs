namespace Core.Parameters.SettingsParams
{
    public class AttendanceSetupSpecParams
    {
        public int? CategoryId { get; set; }

        private string _search;
        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }

    }
}