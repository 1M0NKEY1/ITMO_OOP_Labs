using System;
using System.Collections.Generic;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseDeleteFileCommand : CommandParser, ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseDeleteFileCommand()
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
        const string keyWordTwo = "delete";

        if (parts[0].Input.Equals(keyWordOne, StringComparison.Ordinal) &&
            parts[1].Input.Equals(keyWordTwo, StringComparison.Ordinal))
        {
            string path = parts[2].Input;

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