using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class DeleteFileCommand : ICommand
{
    private readonly string _path;
    private IStrategy? _strategy;

    public DeleteFileCommand(string path)
    {
        _path = path;
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy?.DeleteFile(_path);
    }
}