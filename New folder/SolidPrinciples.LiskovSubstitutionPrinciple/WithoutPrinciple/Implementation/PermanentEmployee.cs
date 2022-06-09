using SolidPrinciples.LiskovSubstitutionPrinciple.WithoutPrinciple.Abstract;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithoutPrinciple.Implementation;

public class PermanentEmployee : Employee
{
    public PermanentEmployee(int id, string name): base(id, name) { }
    
    public override decimal CalculateBonus(decimal salary)
    {
        return salary * .1M;
    }
}