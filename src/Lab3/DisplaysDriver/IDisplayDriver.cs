using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplaysDriver;

public interface IDisplayDriver
{
    void ClearOutput();
    void AddText(string? addText);
    void NewTextColor(ConsoleColor color, IMessage message);
}