using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir.TopicsBuilder;

public interface ITopicBuilder
{
    Topic Create();
    ITopicBuilder WithName(string topicName);
    ITopicBuilder WithAddressee(AddresseeBase addressee);
}