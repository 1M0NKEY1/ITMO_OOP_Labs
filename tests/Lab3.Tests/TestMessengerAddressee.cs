using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addresse;
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

public class TestMessengerAddressee
{
    private const string _topicName = "Name Egor";
    private const string _messageHeading = "239 time";
    private const string _messageBody = " 239 and 241 - religious";

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
    [MemberData(nameof(GetObjects), MemberType = typeof(TestMessengerAddressee))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(
        string topicName,
        MessageHeading messageHeading,
        MessageBody messageBody)
    {
        var mockShowText = new Mock<IShowText>();
        var messenger = new Messenger(mockShowText.Object);
        var logger = new Logger();
        _topicBuilder.WithName(topicName);
        _topicBuilder.WithAddressee(new AddresseeMessenger(logger));
        _messageBuilder.WithHeading(messageHeading);
        _messageBuilder.WithBody(messageBody);
        _messageBuilder.WithLevelOfImportance(new HighLevelOfImportance());

        Message message = _messageBuilder.Create();
        Topic topic = _topicBuilder.Create();
        topic.SendMessage(message);

        messenger.WriteText(message);
        mockShowText.Verify(x => x.Render(It.IsAny<IMessage>()), "messenger 239 time 239 and 241 - religious");
    }
}