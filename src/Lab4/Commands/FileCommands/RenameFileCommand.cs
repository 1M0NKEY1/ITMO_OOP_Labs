using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class RenameFileCommand : ICommand
{
    private readonly string _path;
    private readonly string _newName;

    public RenameFileCommand(string path, string newName)
    {
        _path = path;
        _newName = newName;
    }

    public void Execute()
    {
        string absolutePath = Path.GetFullPath(_path);
        string directoryPath = Path.GetDirectoryName(absolutePath) ?? string.Empty;
        string newFilePath = Path.Combine(directoryPath, _newName);

        if (File.Exists(absolutePath))
        {
            File.Copy(absolutePath, newFilePath, true);
            File.Delete(absolutePath);
        }
    }
}