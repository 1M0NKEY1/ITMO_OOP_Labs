using System;
using System.Collections.Generic;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseShowFileCommand : CommandParser, ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseShowFileCommand()
    {
        AddCommandHandler(this);
    }

    public void SetNextHandler(ICommandHandler handler)
    {
        _nextHandler = handler;
    }

    public void Handle(IList<Request> parts)
    {
        const string keyWordOne = "file";
        const string keyWordTwo = "copy";
        const string keyWordThree = "-m";
        const string keyWordFour = "console";

        if (parts.Count == 4 &&
                 parts[0].Input.Equals(keyWordOne, StringComparison.Ordinal) &&
                 parts[1].Input.Equals(keyWordTwo, StringComparison.Ordinal) &&
                 parts[2].Input.Equals(keyWordThree, StringComparison.Ordinal) &&
                 parts[3].Input.Equals(keyWordFour, StringComparison.Ordinal))
        {
            string path = parts[3].Input;
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