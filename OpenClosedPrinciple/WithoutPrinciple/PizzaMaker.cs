namespace SolidPrinciples.OpenClosedPrinciple.WithoutPrinciple;

public class PizzaMaker
{
    private readonly PizzaOven _oven;

    public PizzaMaker()
    {
        _oven = new PizzaOven();
    }

    public void MakePizza(PizzaType type)
    {
        PizzaIngredients ingredients;
        
        switch (type)
        {
            case PizzaType.Tomato:
                Console.WriteLine("Making Tomato pizza...");
                ingredients = new PizzaIngredients();
                _oven.Bake(ingredients);
                break;
            
            case PizzaType.Mushroom:
                Console.WriteLine("Making Mushroom pizza...");
                ingredients = new PizzaIngredients();
                _oven.Bake(ingredients);
                break;
            
            default:
                ingredients = new PizzaIngredients();
                _oven.Bake(ingredients);
                break;
        }
    }
}