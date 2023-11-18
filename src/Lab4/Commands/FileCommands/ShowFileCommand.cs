using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

public class ShowFileCommand : ICommand
{
    private const string KeyWordFour = "console";
    private readonly string _path;
    private readonly string _mode;

    public ShowFileCommand(string path, string mode)
    {
        _path = path;
        _mode = mode;
    }

    public void Execute()
    {
        string absolutePath = Path.GetFullPath(_path);

        if (File.Exists(absolutePath))
        {
            if (_mode.Equals(KeyWordFour, StringComparison.Ordinal))
            {
                string fileContent = File.ReadAllText(absolutePath);
                Console.WriteLine(fileContent);
            }
        }
    }
}