using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

public class TreeGotoCommand : ICommand
{
    private readonly string _path;

    public TreeGotoCommand(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (Path.IsPathRooted(_path))
        {
            Directory.SetCurrentDirectory(_path);
        }
        else
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string combinedPath = Path.Combine(currentDirectory, _path);

            Directory.SetCurrentDirectory(combinedPath);
        }

        Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
    }
}