using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBody;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesHeadings;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesBuilder;

public class MessageBuilder : IMessageBuilder
{
    private MessageHeading? _messageHeading;
    private MessageBody? _messageBody;
    private LevelOfImportance? _levelOfImportance;

    private IList<MessageBuildResult> _messageBuildResults = new List<MessageBuildResult>();

    public Message Create()
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

    public IList<MessageBuildResult> GetResults()
    {
        var value = new List<MessageBuildResult>();

        CheckLevelOfImportance();

        if (_messageBuildResults.Count > 0)
        {
            return value;
        }

        value.Add(MessageBuildResult.Unreaden);
        value.Add(MessageBuildResult.Success);

        return value;
    }

    private void CheckLevelOfImportance()
    {
        if (_levelOfImportance is LowLevelOfImportance)
        {
            _messageBuildResults.Add(MessageBuildResult.LowLevel);
        }
    }
}