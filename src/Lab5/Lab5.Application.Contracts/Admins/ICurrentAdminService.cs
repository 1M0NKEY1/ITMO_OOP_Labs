using Lab5.Applixation.Models;

namespace Lab5.Application.Contracts.Admins;

public interface ICurrentAdminService
{
    Admin? Admin { get; }
}