namespace ChefPattenrs;

public class Entremetier : Builder
{
    public Entremetier()
    {
        chef = new Chef("Vegetable cook Chef");
    }
    public override void BuildName()
    {
        chef["name"] = "Jenny Sfol";
    }
    public override void BuildSpecialization()
    {
        chef["specialization"] = "Entremetier";
    }

    public override void BuildExperience()
    {
        chef["experience"] = "5";
    }
}