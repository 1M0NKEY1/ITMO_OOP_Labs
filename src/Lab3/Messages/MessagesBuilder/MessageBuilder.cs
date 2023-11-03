using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBody;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesHeadings;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesBuilder;

public class MessageBuilder : IMessageBuilder
{
    private MessageHeading? _messageHeading;
    private MessageBody? _messageBody;
    private LevelOfImportance? _levelOfImportance;

    public Message Crate()
    {
        return new Message(_messageHeading, _messageBody, _levelOfImportance);
    }

    public IMessageBuilder WithHeading(MessageHeading? heading)
    {
        _messageHeading = heading;
        return this;
    }

    public IMessageBuilder WithBody(MessageBody? body)
    {
        _messageBody = body;
        return this;
    }

    public IMessageBuilder WithLevelOfImportance(LevelOfImportance? levelOfImportance)
    {
        _levelOfImportance = levelOfImportance;
        return this;
    }
}