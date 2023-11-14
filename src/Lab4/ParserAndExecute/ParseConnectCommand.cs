using System;
using System.Collections.Generic;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseConnectCommand : CommandParser, ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseConnectCommand()
    {
        AddCommandHandler(this);
    }

    public void SetNextHandler(ICommandHandler handler)
    {
        _nextHandler = handler;
    }

    public void Handle(IList<Request> parts)
    {
        const string keyWordOne = "connect";
        const string keyWordTwo = "-m";
        const string keyWordThree = "local";

        if (parts.Count >= 2 &&
            parts.Count <= 4 &&
            parts[0].Input.Equals(keyWordOne, StringComparison.Ordinal) &&
            !string.IsNullOrWhiteSpace(parts[1].Input))
        {
            string address = parts[1].Input;

            for (int i = 2; i < parts.Count; i++)
            {
                if (parts[i].Input.Equals(keyWordTwo, StringComparison.Ordinal) &&
                    i + 1 < parts.Count &&
                    parts[i + 1].Input.Equals(keyWordThree, StringComparison.Ordinal))
                {
                    Execute(address, keyWordThree);
                    return;
                }
            }

            Execute(address, keyWordThree);
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    private static void Execute(string address, string mode)
    {
        if (mode.Equals("local", StringComparison.Ordinal))
        {
            var fileInfo = new FileInfo(address);

            if (fileInfo is { Exists: true, Directory.Exists: true })
            {
                Console.WriteLine($"Connect to local file system: '{fileInfo.FullName}'");
            }
        }
    }
}