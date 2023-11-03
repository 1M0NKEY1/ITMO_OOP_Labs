using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addresse;
using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeDisplay : AddresseeBase
{
    private readonly Display _display = new();
    private readonly Logger _logger = new();
    private ConsoleColor _color;

    public void SetColor(ConsoleColor color)
    {
        _color = color;
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
            _logger.OutputText("Received message");
            _display.WriteText(_color, message);
        }
    }
}