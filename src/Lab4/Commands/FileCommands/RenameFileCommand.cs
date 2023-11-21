using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class RenameFileCommand : ICommand
{
    private readonly string _path;
    private readonly string _newName;

    private IStrategy? _strategy;

    public RenameFileCommand(string path, string newName)
    {
        _path = path;
        _newName = newName;
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy?.RenameFile(_path, _newName);
    }
}