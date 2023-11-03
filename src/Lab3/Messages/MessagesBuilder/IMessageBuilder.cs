using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBody;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesHeadings;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesBuilder;

public interface IMessageBuilder
{
    Message Create();
    IMessageBuilder WithHeading(MessageHeading? heading);
    IMessageBuilder WithBody(MessageBody? body);
    IMessageBuilder WithLevelOfImportance(LevelOfImportance? levelOfImportance);
}