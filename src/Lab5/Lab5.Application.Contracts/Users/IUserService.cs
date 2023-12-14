namespace Lab5.Application.Contracts.Users;

public interface IUserService
{
    UserLoginResult Login(long id, long pin);
    OperationResult CreateAccount(long id, string name, long pin);
    decimal ShowAccountBalance();
    OperationResult AddMoneyToBalance(decimal money);
    OperationResult RemoveMoneyFromBalance(decimal money);
    IList<string>? ShowAccountHistory();
}