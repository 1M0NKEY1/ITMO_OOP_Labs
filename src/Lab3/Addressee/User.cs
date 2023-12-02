using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class User : IUser
{
    private readonly IList<UserMessageStatus> _messages = new List<UserMessageStatus>();
    private readonly IMessageStatusProxy _proxy;

    public User(IMessageStatusProxy proxy)
    {
        _proxy = proxy;
    }

    public void SaveMessage(IMessage message)
    {
        _messages.Add(new UserMessageStatus(message, false));
    }

    public void ChangeStatus(IMessage message)
    {
        UserMessageStatus? messageStatus = _messages.FirstOrDefault(target => target.Message.Equals(message));
        if (messageStatus is not null)
        {
            _messages[_messages.IndexOf(messageStatus)] = _proxy.ReadMessage(messageStatus);
        }
    }
}