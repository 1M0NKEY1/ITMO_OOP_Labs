using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addresse;
using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeDisplay : AddresseeBase
{
    private readonly Display _display = new();
    private ConsoleColor _color;

    public void SetColor(ConsoleColor color)
    {
        _color = color;
    }

    public override string Log()
    {
        return "Message received";
    }

    public override bool FilterForLevel(LevelOfImportance levelOfImportance)
    {
        return levelOfImportance switch
        {
            HighLevelOfImportance or MiddleLevelOfImportance => true,
            _ => false,
        };
    }

    public override void ReceiveMessage(IMessage message)
    {
        if (message.LevelOfImportance != null && FilterForLevel(message.LevelOfImportance))
        {
            Console.WriteLine(Log());
            _display.WriteText(_color, message);
        }
    }
}