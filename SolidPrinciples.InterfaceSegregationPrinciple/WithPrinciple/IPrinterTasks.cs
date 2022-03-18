namespace SolidPrinciples.InterfaceSegregationPrinciple.WithPrinciple;

public interface IPrinterTasks
{
    bool PrintContent(string content);
    
    bool ScanContent(string content);
    
    bool PhotocopyContent(string content);
}