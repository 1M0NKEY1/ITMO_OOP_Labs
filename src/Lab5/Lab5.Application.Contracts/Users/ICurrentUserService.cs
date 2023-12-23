using Lab5.Applixation.Models;

namespace Lab5.Application.Contracts.Users;

public interface ICurrentUserService
{
    User? User { get; }
}