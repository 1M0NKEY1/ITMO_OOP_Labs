using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Moqs;

public class MoqUser : IUser
{
    private readonly IMessageStatusProxy _proxy;
    public MoqUser(IMessageStatusProxy proxy)
    {
        _proxy = proxy;
    }

    public IList<UserMessageStatus> Messages { get; } = new List<UserMessageStatus>();

    public void SaveMessage(IMessage message)
    {
        Messages.Add(new UserMessageStatus(message, false));
    }

    public void ChangeStatus(IMessage message)
    {
        UserMessageStatus? messageStatus = Messages.FirstOrDefault(target => target.Message.Equals(message));
        if (messageStatus is not null)
        {
            Messages[Messages.IndexOf(messageStatus)] = _proxy.ReadMessage(messageStatus);
        }
    }
}