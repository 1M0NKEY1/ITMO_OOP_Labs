using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseMoveFileCommand : ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseMoveFileCommand()
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
        const string keyWordTwo = "move";
        if (parts[0].Equals(keyWordOne, StringComparison.Ordinal) &&
            parts[1].Equals(keyWordTwo, StringComparison.Ordinal))
        {
            string sourcePath = parts[2];
            string destinationPath = parts[3];
            Execute(sourcePath, destinationPath);
        }
        else
        {
            _nextHandler?.Handle(parts);
        }
    }

    private static void Execute(string sourcePath, string destinationPath)
    {
        if (File.Exists(sourcePath))
        {
            string sourceAbsolutePath = Path.GetFullPath(sourcePath);
            string destinationAbsolutePath = Path.GetFullPath(destinationPath);

            string fileName = Path.GetFileName(sourceAbsolutePath);
            string destinationFilePath = Path.Combine(destinationAbsolutePath, fileName);

            File.Move(sourceAbsolutePath, destinationFilePath);
        }
    }
}