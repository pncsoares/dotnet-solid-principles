namespace SolidPrinciples.DependencyInversionPrinciple.WithPrinciple;

public class BusinessLogicLayer
{
    private readonly IRepositoryLayer _dal;

    public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
    {
        _dal = repositoryLayer;
    }

    public void Save(object details)
    {
        _dal.Save(details);
    }
}