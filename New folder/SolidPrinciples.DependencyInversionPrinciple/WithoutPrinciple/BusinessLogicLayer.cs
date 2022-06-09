namespace SolidPrinciples.DependencyInversionPrinciple.WithoutPrinciple;

public class BusinessLogicLayer
{
    private readonly DataAccessLayer _dal;

    public BusinessLogicLayer()
    {
        _dal = new DataAccessLayer();
    }

    public void Save(object details)
    {
        _dal.Save(details);
    }
}