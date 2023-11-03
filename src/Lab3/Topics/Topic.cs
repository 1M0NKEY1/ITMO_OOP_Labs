using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDir.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir;

public class Topic : TopicBase
{
    private readonly ITopicName? _topicName;
    private readonly AddresseeBase? _addressee;

    public Topic(ITopicName? name, AddresseeBase? addressee)
    {
        _topicName = name;
        _addressee = addressee;
    }

    public override void SendMessage(IMessage message)
    {
        _addressee?.ReceiveMessage(message);
    }
}