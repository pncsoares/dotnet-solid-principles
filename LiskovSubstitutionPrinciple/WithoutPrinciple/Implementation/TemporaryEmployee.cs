using SolidPrinciples.LiskovSubstitutionPrinciple.WithoutPrinciple.Abstract;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithoutPrinciple.Implementation;

public class TemporaryEmployee : Employee
{
    public TemporaryEmployee(int id, string name): base(id, name) { }
    
    public override decimal CalculateBonus(decimal salary)
    {
        return salary * .05M;
    }
}