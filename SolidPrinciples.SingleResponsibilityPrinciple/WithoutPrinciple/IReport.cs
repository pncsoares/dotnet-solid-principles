namespace SolidPrinciples.SingleResponsibilityPrinciple.WithoutPrinciple;

public interface IReport
{
    void AddEntry(int index);
    
    void RemoveEntry(int index);
    
    void SaveToFile(string directoryPath, string fileName);
}