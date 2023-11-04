using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBody;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesHeadings;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDir;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDir.TopicsBuilder;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TestChangeMessageReadToRead
{
    private const string _topicName = "Name Egor";
    private const string _messageHeading = "239 time";
    private const string _messageBody = "239 and 241 - religious";

    private readonly TopicBuilder _topicBuilder = new();
    private readonly MessageBuilder _messageBuilder = new();

    public static IEnumerable<object[]> GetObjects
    {
        get
        {
            yield return new object[]
            {
                _topicName,
                new MessageHeading(_messageHeading),
                new MessageBody(_messageBody),
            };
        }
    }

    public static bool CompleteBuild(MessageBuilder messageBuilder, TopicBuilder topicBuilder)
    {
        Message message = messageBuilder.Create();
        Topic topic = topicBuilder.Create();
        topic.SendMessage(message);
        topic.ChangeStatus(message);
        topic.ChangeStatus(message);

        return !topic.MessageStatus(message);
    }

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestChangeMessageReadToRead))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(
        string topicName,
        MessageHeading messageHeading,
        MessageBody messageBody)
    {
        _topicBuilder.WithName(topicName);
        _topicBuilder.WithAddressee(new AddresseUser());
        _messageBuilder.WithHeading(messageHeading);
        _messageBuilder.WithBody(messageBody);
        _messageBuilder.WithLevelOfImportance(new HighLevelOfImportance());

        Assert.False(CompleteBuild(_messageBuilder, _topicBuilder));
    }
}