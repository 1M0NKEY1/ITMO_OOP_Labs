using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseConnectCommand : CommandHandlerBase
{
    private const string KeyWordConnect = "connect";
    private const string KeyWordDashM = "-m";
    private const string KeyWordLocal = "local";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts.Count >= 2 &&
               parts.Count <= 4 &&
               parts[0].Equals(KeyWordConnect, StringComparison.Ordinal) &&
               parts[2].Equals(KeyWordDashM, StringComparison.Ordinal) &&
               !string.IsNullOrWhiteSpace(parts[1]);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        string address = parts[1];

        return new ConnectCommand(address, KeyWordLocal);
    }
}