using ChefPattenrs.Strategy;

namespace ChefPattenrs;

public class Program
{
    private static void Main(string[] args)
    {
        OrderSingleton order1 = OrderSingleton.GetOrder();
        OrderSingleton order2 = OrderSingleton.GetOrder();
        OrderSingleton order3 = OrderSingleton.GetOrder();
        
        var dish1 = order1.OrderADish("Smoked salmon", "fish dish");
        var dish2 = order2.OrderADish("Greek Salad", "vegetable dish"); 
        var dish3 = order3.OrderADish("Steak beef", "meat dish");
        var dish4 = order3.OrderADish("Fish with Saffron and cream sauce", "fish dish");
        
        List<string[]> dishes =new List<string[]>(){dish1,dish2,dish3, dish4};
        
        CooksChoice cooksChoice = new CooksChoice();
        for (int i = 0; i < dishes.Count; i++)
        {
            switch (dishes[i][0])
            {
                case "meat dish":
                    cooksChoice.SetCookStrategy(new CookMeatDish());
                    cooksChoice.AppointAChef();
                    break;
                case "fish dish":
                    cooksChoice.SetCookStrategy(new CookFishDish());
                    cooksChoice.AppointAChef();
                    break;
                case "vegetable dish":
                    cooksChoice.SetCookStrategy(new CookVegetableDish());
                    cooksChoice.AppointAChef();
                    break;
            }
            Console.WriteLine("Блюдо '"+ dishes[i][1] +"' было приготовлено.\n");
        }
    }
}