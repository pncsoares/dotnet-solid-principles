namespace SolidPrinciples.OpenClosedPrinciple.WithPrinciple;

public class TomatoPizza : Pizza
{
    public TomatoPizza() : base(PizzaType.Tomato) { }
    
    protected override void SetIngredients()
    {
        base.SetIngredients();
        Console.WriteLine("Tomato pizza ingredients set");
    }
}