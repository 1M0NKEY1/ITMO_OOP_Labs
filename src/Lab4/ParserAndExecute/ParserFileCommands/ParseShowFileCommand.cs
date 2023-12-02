using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseShowFileCommand : CommandHandlerBase
{
    private const string KeyWordFile = "file";
    private const string KeyWordShow = "show";
    private const string KeyWordDashM = "-m";
    private const string KeyWordConsole = "console";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count == 5 &&
               parts[0].Equals(KeyWordFile, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordShow, StringComparison.Ordinal) &&
               parts[3].Equals(KeyWordDashM, StringComparison.Ordinal) &&
               parts[4].Equals(KeyWordConsole, StringComparison.Ordinal);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        string path = parts[2];
        return new ShowFileCommand(path, KeyWordConsole);
    }
}