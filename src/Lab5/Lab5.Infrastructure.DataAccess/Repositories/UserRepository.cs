using System.Globalization;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Applixation.Models;
using Npgsql;

namespace DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private const decimal StartBalance = 0;
    private readonly IPostgresConnectionProvider _connectionProvider;

    public UserRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public User? FindUserByUserId(long id, long pin)
    {
        const string operationType = "Account has been logged in";
        const string sql = """
                         select user_id, user_name, pin, balance
                         from users
                         where user_id = :id and pin = :pin;
                         """;

        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default)
                    .ConfigureAwait(false))
                    .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", id);
        command.AddParameter("pin", pin);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        UpdateOperationInHistory(id, operationType);

        return new User(
            UserId: reader.GetInt64(0),
            Username: reader.GetString(1),
            Pin: reader.GetInt64(2),
            Balance: reader.GetDecimal(3));
    }

    public void CreateAccount(long id, string name, long pin)
    {
        const string operationType = "Account has been created";
        const string sql = """
                           insert into users (user_id, user_name, pin, balance)
                           values (:id, :name, :pin, :StartBalance);
                           """;

        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default)
                    .ConfigureAwait(false))
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", id);
        command.AddParameter("user_name", name);
        command.AddParameter("pin", pin);
        command.AddParameter("balance", StartBalance);

        UpdateOperationInHistory(id, operationType);

        command.ExecuteReader();
    }

    public decimal ShowAccountBalance(long id)
    {
        const string sql = """
                           select balance
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
        using NpgsqlDataReader reader = command.ExecuteReader();

        return reader.GetDecimal(3);
    }

    public void AddMoneyToBalance(long id, decimal money)
    {
        string operationType = "Replenishment of the balance for " + money.ToString(CultureInfo.InvariantCulture);
        const string sql = """
                           select balance
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
        using NpgsqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            decimal tempBalance = reader.GetDecimal(3);
            tempBalance += money;

            reader.Close();

            const string updateSql = """
                                     update users
                                     set balance = :balance
                                     where user_id = :id;
                                     """;

            using var updateCommand = new NpgsqlCommand(updateSql, connection);
            updateCommand.Parameters.AddWithValue("id", id);
            updateCommand.Parameters.AddWithValue("balance", tempBalance);

            UpdateOperationInHistory(id, operationType);

            updateCommand.ExecuteNonQuery();
        }
    }

    public void RemoveMoneyFromBalance(long id, decimal money)
    {
        string operationType = "Withdrawal of " + money.ToString(CultureInfo.InvariantCulture) + " from the balance";
        const string sql = """
                           select balance
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
        using NpgsqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            decimal tempBalance = reader.GetDecimal(3);
            tempBalance -= money;

            reader.Close();

            const string updateSql = """
                                     update users
                                     set balance = :balance
                                     where user_id = :id;
                                     """;

            using var updateCommand = new NpgsqlCommand(updateSql, connection);
            updateCommand.Parameters.AddWithValue("id", id);
            updateCommand.Parameters.AddWithValue("balance", tempBalance);

            UpdateOperationInHistory(id, operationType);

            updateCommand.ExecuteNonQuery();
        }
    }

    public IList<string>? ShowAccountHistory(long id)
    {
        IList<string>? newList = new List<string>();
        const string sql = """
                           select operation_type
                           from account_operation_history
                           where user_id = :id;
                           """;
        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false)).GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);

        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            newList.Add(reader.GetString(1));
        }

        return newList;
    }

    private void UpdateOperationInHistory(long id, string operation)
    {
        const string sql = """
                           insert into account_operation_history (user_id, operation_type)
                           values (:id, :operation);
                           """;
        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default)
                    .ConfigureAwait(false))
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", id);
        command.AddParameter("operation_type", operation);

        command.ExecuteReader();
    }
}