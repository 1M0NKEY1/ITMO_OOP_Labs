using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands;

public class TreeListCommand : ICommand
{
    private readonly int _depth;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public void Execute()
    {
        string basePath = Directory.GetCurrentDirectory();
        ListDirectoriesAndFiles(basePath, _depth, 0);
    }

    private static void ListDirectoriesAndFiles(string path, int maxDepth, int currentDepth)
    {
        if (currentDepth > maxDepth)
            return;

        IList<string> directories = Directory.GetDirectories(path);
        IList<string> files = Directory.GetFiles(path);

        foreach (string directory in directories)
        {
            Console.WriteLine("Directory: " + directory);
            ListDirectoriesAndFiles(directory, maxDepth, currentDepth + 1);
        }

        foreach (string file in files)
        {
            Console.WriteLine("File: " + file);
        }
    }
}