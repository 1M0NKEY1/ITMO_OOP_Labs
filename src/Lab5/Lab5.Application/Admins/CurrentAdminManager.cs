using Lab5.Application.Contracts.Admins;
using Lab5.Applixation.Models;

namespace Lab5.Application.Admins;

internal class CurrentAdminManager : ICurrentAdminService
{
    public Admin? Admin { get; set; }
}