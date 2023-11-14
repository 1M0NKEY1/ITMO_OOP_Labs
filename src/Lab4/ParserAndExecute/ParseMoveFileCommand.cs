using System;
using System.Collections.Generic;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseMoveFileCommand : CommandParser, ICommandHandler
{
    private ICommandHandler? _nextHandler;

    public ParseMoveFileCommand()
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
        const string keyWordTwo = "move";
        if (parts[0].Input.Equals(keyWordOne, StringComparison.Ordinal) &&
            parts[1].Input.Equals(keyWordTwo, StringComparison.Ordinal))
        {
            string sourcePath = parts[2].Input;
            string destinationPath = parts[3].Input;
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