namespace ChefPattenrs;

public class Restaurant
{
    public void Construct(Builder builder)
    {
        builder.BuildName();
        builder.BuildSpecialization();
        builder.BuildExperience();
    }
}