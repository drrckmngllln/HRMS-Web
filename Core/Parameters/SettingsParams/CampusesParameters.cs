namespace Core.Parameters.SettingsParams;

public class CampusesParameters
{
    private string _search { get; set; }

    public string Search
    {
        get => _search; 
        set => _search = value.ToLower();
    }
}