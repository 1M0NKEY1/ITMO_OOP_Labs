using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseShowFileCommand : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseShowFileCommand()
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
        const string keyWordOne = "file";
        const string keyWordTwo = "show";
        const string keyWordThree = "-m";
        const string keyWordFour = "console";

        if (parts.Count == 5 &&
                 parts[0].Equals(keyWordOne, StringComparison.Ordinal) &&
                 parts[1].Equals(keyWordTwo, StringComparison.Ordinal) &&
                 parts[3].Equals(keyWordThree, StringComparison.Ordinal) &&
                 parts[4].Equals(keyWordFour, StringComparison.Ordinal))
        {
            string path = parts[2];
            Execute(path, keyWordFour);
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    private static void Execute(string path, string mode)
    {
        string absolutePath = Path.GetFullPath(path);

        if (File.Exists(absolutePath))
        {
            if (mode.Equals("console", StringComparison.Ordinal))
            {
                string fileContent = File.ReadAllText(absolutePath);
                Console.WriteLine(fileContent);
            }
        }
    }
}