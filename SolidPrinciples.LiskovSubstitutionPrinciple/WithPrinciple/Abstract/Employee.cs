using SolidPrinciples.LiskovSubstitutionPrinciple.WithPrinciple.Interfaces;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithPrinciple.Abstract;

public abstract class Employee : IEmployee, IEmployeeBonus
{
    public int Id { get; }
    public string Name { get; }

    protected Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract decimal GetMinimumSalary();
    
    public abstract decimal CalculateBonus(decimal salary);

    public override string ToString()
    {
        return $"ID: {Id} Name: {Name}";
    }
}