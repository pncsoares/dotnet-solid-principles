namespace SolidPrinciples.SingleResponsibilityPrinciple.WithPrinciple;

public interface IReport
{
    void AddEntry(int index);
    
    void RemoveEntry(int index);
}