namespace SolidPrinciples.LiskovSubstitutionPrinciple.WithoutPrinciple.Abstract;

public abstract class Employee
{
    private int Id { get; }
    private string Name { get; }

    protected Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract decimal CalculateBonus(decimal salary);

    public override string ToString()
    {
        return $"ID: {Id} Name: {Name}";
    }
}