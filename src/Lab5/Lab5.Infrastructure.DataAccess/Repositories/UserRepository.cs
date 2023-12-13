using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Applixation.Models;
using Npgsql;

namespace DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public UserRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public User? FindUserByUserId(long id)
    {
        const string sql = """
                         select user_id, user_name, pin, balance
                         from users
                         where user_id = :id;
                         """;

        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default)
                    .ConfigureAwait(false))
                    .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", id);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new User(
            UserId: reader.GetInt64(0),
            Username: reader.GetString(1),
            Pin: reader.GetInt64(0),
            Balance: reader.GetDecimal(0));
    }
}