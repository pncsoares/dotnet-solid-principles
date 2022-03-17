namespace SolidPrinciples.OpenClosedPrinciple.WithPrinciple;

public class Pizza
{
    private readonly PizzaIngredients _ingredients;
    
    public PizzaType Type { get; }

    public Pizza(PizzaType type)
    {
        Type = type;
        _ingredients = new PizzaIngredients();
    }

    protected virtual void SetIngredients()
    {
        Console.WriteLine("Base pizza ingredients set");
    }

    public void Make(PizzaOven oven)
    {
        oven.Bake(_ingredients);
    }
}