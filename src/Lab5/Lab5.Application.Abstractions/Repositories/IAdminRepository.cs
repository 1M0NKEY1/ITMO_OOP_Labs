using Lab5.Applixation.Models;

namespace Lab5.Application.Abstractions.Repositories;

public interface IAdminRepository
{
    Admin? FindAdminByAdminId(long id, long adminKey);
    void ChangeAdminKey(long id, long newAdminKey);
}