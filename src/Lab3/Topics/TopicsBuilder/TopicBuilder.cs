using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir.TopicsBuilder;

public class TopicBuilder : ITopicBuilder
{
    private string? _name;
    private AddresseeBase? _addressee;

    public Topic Create()
    {
        return new Topic(_name, _addressee);
    }

    public ITopicBuilder WithName(string topicName)
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