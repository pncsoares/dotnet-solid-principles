using SolidPrinciples.LiskovSubstitutionPrinciple.WithPrinciple.Abstract;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithPrinciple.Implementation;

public class TemporaryEmployee : Employee
{
    public TemporaryEmployee(int id, string name): base(id, name) { }
    
    public override decimal CalculateBonus(decimal salary)
    {
        return salary * .05M;
    }
    
    public override decimal GetMinimumSalary()
    {
        return 5000;
    }
}