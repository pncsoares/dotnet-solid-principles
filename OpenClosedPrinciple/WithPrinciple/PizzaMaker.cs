namespace SolidPrinciples.OpenClosedPrinciple.WithPrinciple;

public class PizzaMaker
{
    private readonly PizzaOven _oven;

    public PizzaMaker()
    {
        _oven = new PizzaOven();
    }

    public void MakePizza(Pizza pizza)
    {
        Console.WriteLine($"Making {pizza.Type} pizza...");
        pizza.Make(_oven);
    }
}