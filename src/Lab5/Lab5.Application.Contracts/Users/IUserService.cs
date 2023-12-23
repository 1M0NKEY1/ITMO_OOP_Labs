namespace Lab5.Application.Contracts.Users;

public interface IUserService
{
    UserLoginResult Login(string name, long pin);
    OperationResult CreateAccount(string name, long pin);
    decimal ShowAccountBalance();
    OperationResult AddMoneyToBalance(decimal money);
    OperationResult RemoveMoneyFromBalance(decimal money);
    IList<string>? ShowAccountHistory();
}