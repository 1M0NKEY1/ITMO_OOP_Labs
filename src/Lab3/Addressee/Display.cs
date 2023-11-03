using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class Display : IDisplay
{
    public void WriteText(ConsoleColor color, IMessage message)
    {
        Console.ForegroundColor = color;
        Console.Write(message.Heading + message.Body);
    }
}