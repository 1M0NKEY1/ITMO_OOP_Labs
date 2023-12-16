using Itmo.ObjectOrientedProgramming.Lab4.Commands.Strategy;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class CopyFileCommand : ICommand
{
    private readonly string _sourcePath;
    private readonly string _destinationPath;

    private IStrategy? _strategy;

    public CopyFileCommand(string sourcePath, string destinationPath)
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
        _strategy?.CopyFile(_sourcePath, _destinationPath);
    }
}