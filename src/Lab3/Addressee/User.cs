using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class User : IUser
{
    public IList<IMessage> ListOfReadMessage { get; } = new List<IMessage>();
    public IList<IMessage> ListOfUnreadMessages { get; } = new List<IMessage>();

    public void SaveMessage(IMessage message)
    {
        ListOfUnreadMessages.Add(message);
    }

    public void ChangeStatus(IMessage message)
    {
        if (ListOfReadMessage.Contains(message))
        {
            ListOfReadMessage.Remove(message);
            ListOfUnreadMessages.Add(message);
        }
        else if (ListOfUnreadMessages.Contains(message))
        {
            ListOfUnreadMessages.Remove(message);
            ListOfReadMessage.Add(message);
        }
    }
}