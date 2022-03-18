namespace SolidPrinciples.InterfaceSegregationPrinciple.WithPrinciple.Client;

public class CannonMg2470 : IPrinterTasks, IPrintDuplexTasks
{
    public bool PrintContent(string content)
    {
        Console.WriteLine("Printing...");
        return true;
    }

    public bool ScanContent(string content)
    {
        Console.WriteLine("Printing...");
        return true;
    }

    public bool PhotocopyContent(string content)
    {
        Console.WriteLine("Printing...");
        return true;
    }

    public bool PrintDuplexContent(string content)
    {
        Console.WriteLine("Printing duplex...");
        return true;
    }
}