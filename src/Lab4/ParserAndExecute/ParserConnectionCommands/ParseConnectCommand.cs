using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseConnectCommand : CommandHandlerBase
{
    private const string KeyWordOne = "connect";
    private const string KeyWordTwo = "-m";
    private const string KeyWordThree = "local";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count >= 2 &&
               parts.Count <= 4 &&
               parts[0].Equals(KeyWordOne, StringComparison.Ordinal) &&
               !string.IsNullOrWhiteSpace(parts[1]);
    }

    protected override void Process(IList<string> parts)
    {
        string address = parts[1];
        var connectCommand = new ConnectCommand(address, KeyWordThree);

        for (int i = 2; i < parts.Count; i++)
        {
            if (parts[i].Equals(KeyWordTwo, StringComparison.Ordinal) &&
                i + 1 < parts.Count &&
                parts[i + 1].Equals(KeyWordThree, StringComparison.Ordinal))
            {
                connectCommand.Execute();
                return;
            }
        }

        connectCommand.Execute();
    }
}