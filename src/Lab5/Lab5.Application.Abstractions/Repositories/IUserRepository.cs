using Lab5.Applixation.Models;

namespace Lab5.Application.Abstractions.Repositories;

public interface IUserRepository
{
    User? FindUserByUserId(long id);
}