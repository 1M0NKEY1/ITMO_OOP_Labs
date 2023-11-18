using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class DeleteFileCommand : ICommand
{
    private readonly string _path;

    public DeleteFileCommand(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (File.Exists(_path))
        {
            File.Delete(_path);
        }
    }
}