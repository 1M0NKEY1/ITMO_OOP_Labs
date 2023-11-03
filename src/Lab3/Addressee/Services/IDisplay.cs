using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public interface IDisplay
{
    void WriteText(ConsoleColor color, IMessage message);
}