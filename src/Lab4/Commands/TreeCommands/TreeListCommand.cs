using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

public class TreeListCommand : ICommand
{
    private readonly int _depth;

    private IStrategy? _strategy;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy?.TreeList(_depth);
    }
}