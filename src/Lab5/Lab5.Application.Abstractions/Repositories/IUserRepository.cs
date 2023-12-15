using Lab5.Applixation.Models;

namespace Lab5.Application.Abstractions.Repositories;

public interface IUserRepository
{
    User? FindUserByUserName(string name, long pin);
    void CreateAccount(string name, long pin);
    decimal ShowAccountBalance(long id);
    void AddMoneyToBalance(long id, decimal money);
    void RemoveMoneyFromBalance(long id, decimal money);
    IList<string>? ShowAccountHistory(long id);
}