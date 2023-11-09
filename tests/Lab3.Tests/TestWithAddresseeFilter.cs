using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.LevelOfImportant;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBody;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesHeadings;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDir;
using Itmo.ObjectOrientedProgramming.Lab3.TopicDir.TopicsBuilder;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TestWithAddresseeFilter
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

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestWithAddresseeFilter))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(
        string topicName,
        MessageHeading messageHeading,
        MessageBody messageBody)
    {
        var mocklogger = new Mock<ILogger>();
        _topicBuilder.WithName(topicName);
        _topicBuilder.WithAddressee(new FilterDecorator(new AddresseeUser(), new LowLevelOfImportance()));
        _messageBuilder.WithHeading(messageHeading);
        _messageBuilder.WithBody(messageBody);
        _messageBuilder.WithLevelOfImportance(new LowLevelOfImportance());

        Message message = _messageBuilder.Create();
        Topic topic = _topicBuilder.Create();
        topic.SendMessage(message);

        mocklogger.Verify(log => log.OutputText(It.IsAny<string>()), Times.Never);
    }
}