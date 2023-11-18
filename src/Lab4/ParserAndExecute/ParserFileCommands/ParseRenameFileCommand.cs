using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseRenameFileCommand : CommandHandlerBase
{
    private const string KeyWordOne = "file";
    private const string KeyWordTwo = "rename";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordTwo, StringComparison.Ordinal);
    }

    protected override void Process(IList<string> parts)
    {
        string path = parts[2];
        string newName = parts[3];
        var renameCommand = new RenameFileCommand(path, newName);

        renameCommand.Execute();
    }
}