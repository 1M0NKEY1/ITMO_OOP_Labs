using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Applixation.Models;
using Npgsql;

namespace DataAccess.Repositories;

public class AdministratorRepository : IAdminRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public AdministratorRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public Admin? FindAdminByAdminId(long id)
    {
        const string sql = """
                           select admin_id, admin_name, administrator_key
                           from admins
                           where admin_id = :id;
                           """;
        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default)
                    .ConfigureAwait(false))
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("admin_id", id);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new Admin(
            AdminId: reader.GetInt64(0),
            AdminName: reader.GetString(1),
            AdministratorKey: reader.GetInt64(0));
    }
}