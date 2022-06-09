namespace SolidPrinciples.SingleResponsibilityPrinciple.WithoutPrinciple;

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

    public void SaveToFile(string directoryPath, string fileName)
    {
        Console.WriteLine($"File with name {fileName} saved in the following path: {directoryPath}");
    }
}