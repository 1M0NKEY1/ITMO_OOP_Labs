namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class MessageStatusProxy : IMessageStatusProxy
{
    public UserMessageStatus ReadMessage(UserMessageStatus message)
    {
        if (message.ReadStatus)
        {
            return message;
        }
        else
        {
            UserMessageStatus temp = message with { ReadStatus = true };
            return temp;
        }
    }
}