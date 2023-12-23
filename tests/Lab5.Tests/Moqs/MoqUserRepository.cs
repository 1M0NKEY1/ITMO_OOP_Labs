using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Moqs;

public class MoqUserRepository : IMoqUserRepository
{
    private readonly IList<MoqUser> _users = new List<MoqUser>();

    public void AddMoneyToBalance(long id, decimal money)
    {
        MoqUser? user = _users.FirstOrDefault(u => u.Pin == id);
        if (user != null)
        {
            user.Balance += money;
        }
    }

    public void RemoveMoneyFromBalance(long id, decimal money)
    {
        MoqUser? user = _users.FirstOrDefault(u => u.Pin == id);
        if (user != null)
        {
            user.Balance -= money;
        }
    }
}