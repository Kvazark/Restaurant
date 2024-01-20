namespace ChefPattenrs;

public class Poissonier : Builder
{
    public Poissonier()
    {
        chef = new Chef("Fish Chef");
    }
    public override void BuildName()
    {
        chef["name"] = "Lui Soll";
    }
    public override void BuildSpecialization()
    {
        chef["specialization"] = "Poissonier";
    }

    public override void BuildExperience()
    {
        chef["experience"] = "5";
    }
}