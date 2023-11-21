using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class ShowFileCommand : ICommand
{
    private readonly string _path;
    private readonly string _mode;

    private IStrategy? _strategy;

    public ShowFileCommand(string path, string mode)
    {
        _path = path;
        _mode = mode;
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy?.ShowFile(_path, _mode);
    }
}