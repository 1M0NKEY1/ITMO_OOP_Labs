using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Moqs;

public class MoqMessageStatusProxy : IMessageStatusProxy
{
    public virtual UserMessageStatus ReadMessage(UserMessageStatus message)
    {
        if (message.ReadStatus)
        {
            return message;
        }
        else
        {
            message = message with { ReadStatus = true };
            return message;
        }
    }
}