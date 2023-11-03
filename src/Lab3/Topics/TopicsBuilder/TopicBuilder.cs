using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDir.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir.TopicsBuilder;

public class TopicBuilder : ITopicBuilder
{
    private ITopicName? _name;
    private AddresseeBase? _addressee;

    public Topic Create()
    {
        return new Topic(_name, _addressee);
    }

    public ITopicBuilder WithName(ITopicName topicName)
    {
        _name = topicName;
        return this;
    }

    public ITopicBuilder WithAddressee(AddresseeBase addressee)
    {
        _addressee = addressee;
        return this;
    }
}