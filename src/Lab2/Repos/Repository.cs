using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class Repository
{
    private readonly ComponentsDataBase _componentsData = new();

    public object? SearchComponentByName(object component, string name)
    {
        return _componentsData.GetByName(component, name);
    }

    public void AddComponent(object component)
    {
        _componentsData.AddNewComponent(component);
    }
}