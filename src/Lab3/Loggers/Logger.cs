using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Logger : ILogger
{
    public void OutputText(string text)
    {
        Console.WriteLine(text);
    }
}