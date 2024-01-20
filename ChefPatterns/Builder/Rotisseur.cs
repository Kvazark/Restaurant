namespace ChefPattenrs;

public class Rotisseur: Builder
{
    public Rotisseur()
    {
        chef = new Chef("Roast Chef");
    }
    public override void BuildName()
    {
        chef["name"] = "Jiny Fiterly";
    }
    public override void BuildSpecialization()
    {
        chef["specialization"] = "Rotisseur";
    }

    public override void BuildExperience()
    {
        chef["experience"] = "2";
    }
}