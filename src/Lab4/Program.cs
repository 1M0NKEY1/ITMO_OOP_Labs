using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Program
{
    public static void Main()
    {
        var request = new Request(Console.ReadLine() ?? string.Empty);
        char delimiter = ' ';
        IList<string> parts = request.Input.Split(delimiter);

        var parseTreeGotoCommand = new ParseTreeGotoCommand();
        parseTreeGotoCommand.Handle(parts);
    }
}