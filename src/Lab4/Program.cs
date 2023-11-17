using System;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Program
{
    public static void Main()
    {
        var request = new Request(Console.ReadLine() ?? string.Empty);

        var parseShowFileCommand = new ParseShowFileCommand();
        parseShowFileCommand.Handle(request.SplitString());
    }
}