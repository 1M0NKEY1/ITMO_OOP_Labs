using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class Repository
{
    private ComponentsDataBase _componentsData = new();

    public object? SearchComponentByName(object component, string name)
    {
        return _componentsData.GetByName(component, name);
    }

    public object AddComponent()
    {
        
    }
}