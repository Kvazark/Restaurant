namespace ChefPattenrs;

public class OrderSingleton
{
    static OrderSingleton instance;

    protected OrderSingleton()
    {
        
    }

    public static OrderSingleton GetOrder()
    {
        if (instance == null)
        {
            instance = new OrderSingleton();
        }
        return instance;
    }
    public string[] OrderADish(string dishName, string typeDish)
    {
        string[] description = {typeDish,dishName};
        Console.WriteLine("Было заказано блюдо '" + dishName+"'.");
        return description;
    }
}