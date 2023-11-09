using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public interface IDisplay
{
    void WriteText(IMessage message);
    void WriteTextWithColor(ConsoleColor color, IMessage message);
}