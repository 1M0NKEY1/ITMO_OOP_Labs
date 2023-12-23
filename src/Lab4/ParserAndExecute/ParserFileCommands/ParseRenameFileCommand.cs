using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseRenameFileCommand : CommandHandlerBase
{
    private const string KeyWordFile = "file";
    private const string KeyWordRename = "rename";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordFile, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordRename, StringComparison.Ordinal);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        string path = parts[2];
        string newName = parts[3];
        return new RenameFileCommand(path, newName);
    }
}