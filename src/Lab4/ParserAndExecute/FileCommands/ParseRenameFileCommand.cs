using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseRenameFileCommand : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseRenameFileCommand()
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
        const string keyWordTwo = "rename";
        if (parts[0].Equals(keyWordOne, StringComparison.Ordinal) &&
            parts[1].Equals(keyWordTwo, StringComparison.Ordinal))
        {
            string path = parts[2];
            string newName = parts[3];
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