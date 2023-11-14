using System;
using System.Collections.Generic;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseRenameFileCommand : CommandParser, ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseRenameFileCommand()
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
        const string keyWordTwo = "rename";
        if (parts[0].Input.Equals(keyWordOne, StringComparison.Ordinal) &&
            parts[1].Input.Equals(keyWordTwo, StringComparison.Ordinal))
        {
            string path = parts[2].Input;
            string newName = parts[3].Input;
            Execute(path, newName);
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    private static void Execute(string path, string newName)
    {
        string absolutePath = Path.GetFullPath(path);
        string directoryPath = Path.GetDirectoryName(absolutePath) ?? string.Empty;
        string newFilePath = Path.Combine(directoryPath, newName);

        if (File.Exists(absolutePath))
        {
            File.Copy(absolutePath, newFilePath, true);
            File.Delete(absolutePath);
        }
    }
}