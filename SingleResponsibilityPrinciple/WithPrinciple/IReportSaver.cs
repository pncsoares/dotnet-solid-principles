namespace SolidPrinciples.SingleResponsibilityPrinciple.WithPrinciple;

public interface IReportSaver
{
    void SaveToFile(string directoryPath, string fileName);
}