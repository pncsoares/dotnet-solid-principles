namespace SolidPrinciples.InterfaceSegregationPrinciple.WithoutPrinciple;

public interface IPrintTasks
{
    bool PrintContent(string content);
    
    bool ScanContent(string content);
    
    bool FaxContent(string content);
    
    bool PhotocopyContent(string content);

    bool PrintDuplexContent(string content);
}