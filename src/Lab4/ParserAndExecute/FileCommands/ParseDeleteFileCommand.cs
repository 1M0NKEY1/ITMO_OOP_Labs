using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseDeleteFileCommand : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseDeleteFileCommand()
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
        const string keyWordTwo = "delete";

        if (parts[0].Equals(keyWordOne, StringComparison.Ordinal) &&
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
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}