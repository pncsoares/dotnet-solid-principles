namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithPrinciple.Interfaces;

public interface IEmployee
{
    int Id { get; }
    string Name { get; }
    
    decimal GetMinimumSalary();
}