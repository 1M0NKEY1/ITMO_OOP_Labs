using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseTreeGotoCommand : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseTreeGotoCommand()
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
        const string keyWordTwo = "goto";

        if (parts.Count == 3 &&
            parts[0].Equals(keyWordOne, StringComparison.Ordinal) &&
            parts[1].Equals(keyWordTwo, StringComparison.Ordinal))
        {
            string path = parts[2];
            Execute(path);
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    private static void Execute(string path)
    {
        if (Path.IsPathRooted(path))
        {
            Directory.SetCurrentDirectory(path);
        }
        else
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string combinedPath = Path.Combine(currentDirectory, path);

            Directory.SetCurrentDirectory(combinedPath);
        }

        Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
    }
}