namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public interface IUser
{
    void SaveMessage(IMessage message);
    void ChangeStatus(IMessage message);
}