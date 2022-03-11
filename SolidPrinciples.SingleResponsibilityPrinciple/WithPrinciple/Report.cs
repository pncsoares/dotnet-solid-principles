namespace SolidPrinciples.SingleResponsibilityPrinciple.WithPrinciple;

public class Report : IReport
{
    public void AddEntry(int index)
    {
        Console.WriteLine($"Entry added at index {index}");
    }

    public void RemoveEntry(int index)
    {
        Console.WriteLine($"Entry added from index {index}");
    }
}