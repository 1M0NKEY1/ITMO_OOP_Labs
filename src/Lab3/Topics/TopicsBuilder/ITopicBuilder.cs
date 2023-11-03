using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDir.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir.TopicsBuilder;

public interface ITopicBuilder
{
    Topic Create();
    ITopicBuilder WithName(ITopicName topicName);
    ITopicBuilder WithAddressee(AddresseeBase addressee);
}