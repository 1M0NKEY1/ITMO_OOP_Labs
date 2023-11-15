using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeListCommand : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseTreeListCommand()
    {
        CommandHandlers?.Add(this);
    }

    public IList<ICommandHandler>? CommandHandlers { get; }

    public void SetNextHandler(ICommandHandler handler)
    {
        _nextHandler = handler;
    }

    public void Handle(IList<string> parts)
    {
        const string keyWordOne = "tree";
        const string keyWordTwo = "list";
        const string keyWordThree = "-d";

        if (parts.Count == 4 &&
            parts[0].Equals(keyWordOne, StringComparison.Ordinal) &&
            parts[1].Equals(keyWordTwo, StringComparison.Ordinal) &&
            parts[2].Equals(keyWordThree, StringComparison.Ordinal))
        {
            if (int.TryParse(parts[3], out int depth))
            {
                Execute(depth);
            }
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    private static void Execute(int depth)
    {
        string basePath = Directory.GetCurrentDirectory();
        ListDirectoriesAndFiles(basePath, depth, 0);
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