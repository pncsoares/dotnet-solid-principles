namespace SolidPrinciples.InterfaceSegregationPrinciple.WithoutPrinciple.Client;

public class HpLaserJet : IPrintTasks
{
    public bool PrintContent(string content)
    {
        Console.WriteLine("Printing...");
        return true;
    }

    public bool ScanContent(string content)
    {
        Console.WriteLine("Scanning...");
        return true;
    }

    public bool FaxContent(string content)
    {
        Console.WriteLine("Sending fax...");
        return true;
    }

    public bool PhotocopyContent(string content)
    {
        Console.WriteLine("Photocopying...");
        return true;
    }

    public bool PrintDuplexContent(string content)
    {
        // The HP LaserJet does not have print duplex capabilities
        throw new NotImplementedException();
    }
}