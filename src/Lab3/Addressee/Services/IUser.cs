using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public interface IUser
{
    IList<IMessage> ListOfReadMessage { get; }
    IList<IMessage> ListOfUnreadMessages { get; }
    void SaveMessage(IMessage message);
    void ChangeStatus(IMessage message);
}