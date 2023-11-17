using System;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Program
{
    public static void Main()
    {
        var request = new Request(Console.ReadLine() ?? string.Empty);

        var parseTreeGotoCommand = new ParseTreeGotoCommand();
        parseTreeGotoCommand.Handle(request.SplitString());
    }
}