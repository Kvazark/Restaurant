namespace ChefPattenrs;

public class Chef
{
    private string _chefType;

    private Dictionary<string, string> _parts =
        new Dictionary<string, string>();

    public Chef(string chefType)
    {
        this._chefType = chefType;
    }
    public string this[string key]
    {
        get { return _parts[key]; }
        set { _parts[key] = value; }
    }
    public string[] GetChef()
    {
        string[] infoAboutChef = { _chefType, _parts["name"]};
        return infoAboutChef;
    }

    public void ShowChef()
    {
        Console.WriteLine("Краткая информация о  " + _parts["name"] + ":\n    " +
                          "должность: "+ _chefType +"\n    " +
                          "опыт: "+_parts["experience"]+"\n    " +
                          "специализация: "+_parts["specialization"]+".");
    }
}