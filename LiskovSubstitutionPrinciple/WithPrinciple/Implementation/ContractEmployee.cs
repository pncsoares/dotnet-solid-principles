using SolidPrinciples.LiskovSubstitutionPrinciple.WithPrinciple.Interfaces;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithPrinciple.Implementation;

public class ContractEmployee : IEmployee
{
    public int Id { get; }
    public string Name { get; }
    
    public ContractEmployee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public decimal GetMinimumSalary()
    {
        return 5000;
    }
}