namespace ChefPattenrs.Strategy;

public class CookMeatDish: CookStrategy
{
    public override void Cook()
    {
        Builder builder;
        Restaurant restaurant = new Restaurant();
        builder = new Rotisseur();
        restaurant.Construct(builder);
        var infoAboutChef = builder.Chef.GetChef();
        Console.WriteLine("Повар " + infoAboutChef[1] + " начинает готовить блюдо.");
        builder.Chef.ShowChef();
    }
}