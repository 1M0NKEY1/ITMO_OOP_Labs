using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplaysDriver;

public class DisplayDriver : IDisplayDriver
{
    private string? _emptyString;
    private Display _display = new();

    public void ClearOutput()
    {
        Console.Clear();
    }

    public void AddText(string? addText)
    {
        _emptyString += addText;
    }

    public void NewTextColor(ConsoleColor color, IMessage message)
    {
        _display.WriteTextWithColor(color, message);
    }
}