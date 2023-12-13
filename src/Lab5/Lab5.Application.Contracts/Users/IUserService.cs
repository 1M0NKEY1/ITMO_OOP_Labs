namespace Lab5.Application.Contracts.Users;

public interface IUserService
{
    UserLoginResult Login(long id, long pin);
    void CreateAccount(long id, string name, long pin);
    decimal ShowAccountBalance();
    void AddMoneyToBalance(decimal money);
    void RemoveMoneyFromBalance(decimal money);
    IList<string>? ShowAccountHistory();
}