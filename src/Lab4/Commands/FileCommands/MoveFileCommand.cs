using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class MoveFileCommand : ICommand
{
    private readonly string _sourcePath;
    private readonly string _destinationPath;

    private IStrategy? _strategy;

    public MoveFileCommand(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy?.MoveFile(_sourcePath, _destinationPath);
    }
}