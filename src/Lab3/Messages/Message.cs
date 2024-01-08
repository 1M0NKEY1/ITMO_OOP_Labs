using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBody;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesHeadings;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Message : IMessage
{
    private readonly MessageHeading? _heading;
    private readonly MessageBody? _body;

    public Message(MessageHeading? heading, MessageBody? body, LevelOfImportance? levelOfImportance)
    {
        _heading = heading;
        _body = body;
        LevelOfImportance = levelOfImportance;
    }

    public string? Heading => _heading?.GetHeadingText();
    public string? Body => _body?.GetBodyText();
    public LevelOfImportance? LevelOfImportance { get; }

    public override bool Equals(object? obj)
    {
        if (obj is null || GetType() != obj.GetType())
            return false;

        var equalMessage = (Message)obj;
        return _heading == equalMessage._heading && _body == equalMessage._body;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}