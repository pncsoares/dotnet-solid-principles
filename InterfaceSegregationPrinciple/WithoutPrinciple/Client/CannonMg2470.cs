namespace SolidPrinciples.InterfaceSegregationPrinciple.WithoutPrinciple.Client;

public class CannonMg2470 : IPrintTasks
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

    public bool FaxContent(string content)
    {
        // The Cannon MG 2470 does not have fax capabilities
        throw new NotImplementedException();
    }

    public bool PhotocopyContent(string content)
    {
        Console.WriteLine("Printing...");
        return true;
    }

    public bool PrintDuplexContent(string content)
    {
        throw new NotImplementedException();
    }
}