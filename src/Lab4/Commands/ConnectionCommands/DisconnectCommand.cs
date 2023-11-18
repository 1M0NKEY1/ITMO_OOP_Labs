using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class DisconnectCommand : ICommand
{
    public void Execute()
    {
        Environment.Exit(0);
    }
}