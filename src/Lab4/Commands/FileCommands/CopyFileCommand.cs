using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class CopyFileCommand : ICommand
{
    private readonly string _sourcePath;
    private readonly string _destinationPath;

    public CopyFileCommand(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void Execute()
    {
        if (File.Exists(_sourcePath))
        {
            string sourceAbsolutePath = Path.GetFullPath(_sourcePath);
            string destinationAbsolutePath = Path.GetFullPath(_destinationPath);

            string fileName = Path.GetFileName(_sourcePath);
            string destinationFilePath = Path.Combine(destinationAbsolutePath, fileName);

            File.Copy(sourceAbsolutePath, destinationFilePath, true);
        }
    }
}