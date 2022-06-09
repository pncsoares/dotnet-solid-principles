namespace SolidPrinciples.SingleResponsibilityPrinciple.WithPrinciple;

public class ReportSaver : IReportSaver
{
    public void SaveToFile(string directoryPath, string fileName)
    {
        Console.WriteLine($"File with name {fileName} saved in the following path: {directoryPath}");
    }
}