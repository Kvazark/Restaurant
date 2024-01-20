namespace ChefPattenrs;

public abstract class Builder
{
    protected Chef chef;

    public Chef Chef
    {
        get { return chef; }
    }

    public abstract void BuildName();
    public abstract void BuildSpecialization();
    public abstract void BuildExperience();
}

