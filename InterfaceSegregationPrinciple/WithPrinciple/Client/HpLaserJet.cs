namespace SolidPrinciples.InterfaceSegregationPrinciple.WithPrinciple.Client;

public class HpLaserJet : IPrinterTasks, IFaxTasks
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
}