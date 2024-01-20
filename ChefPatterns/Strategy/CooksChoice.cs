namespace ChefPattenrs.Strategy;

public class CooksChoice
{
    private CookStrategy cookStrategy;

    public void SetCookStrategy(CookStrategy cookStrategy)
    {
        this.cookStrategy = cookStrategy;
    }

    public void AppointAChef()
    {
        cookStrategy.Cook();
    }
}