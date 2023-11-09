using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeDisplay : AddresseeBase
{
    private readonly Display _display = new();
    private ConsoleColor _color;

    public void SetColor(ConsoleColor color)
    {
        _color = color;
    }

    public override void ReceiveMessage(IMessage message)
    {
        _display.WriteTextWithColor(_color, message);
    }
}