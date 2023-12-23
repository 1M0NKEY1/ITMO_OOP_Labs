using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

public class TreeGotoCommand : ICommand
{
    private readonly string _path;

    private IStrategy? _strategy;

    public TreeGotoCommand(string path)
    {
        _path = path;
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy?.TreeGoTo(_path);
    }
}