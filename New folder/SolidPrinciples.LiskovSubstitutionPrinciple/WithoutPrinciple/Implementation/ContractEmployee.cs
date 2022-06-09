using SolidPrinciples.LiskovSubstitutionPrinciple.WithoutPrinciple.Abstract;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithoutPrinciple.Implementation;

public class ContractEmployee : Employee
{
    public ContractEmployee(int id, string name): base(id, name) { }
    
    public override decimal CalculateBonus(decimal salary)
    {
        throw new NotImplementedException();
    }
}