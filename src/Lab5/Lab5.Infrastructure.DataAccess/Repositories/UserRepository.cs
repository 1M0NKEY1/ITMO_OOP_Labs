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

    public User? FindUserByUserName(string name, long pin)
    {
        const string sql = """
                         select user_id, user_name, pin, balance
                         from users
                         where user_name = @user_name and pin = @pin;
                         """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_name", name);
        command.AddParameter("pin", pin);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new User(
            UserId: reader.GetInt64(0),
            Username: reader.GetString(1),
            Pin: reader.GetInt64(2),
            Balance: reader.GetDecimal(3));
    }

    public void CreateAccount(string name, long pin)
    {
        const string operationType = "Account has been created";
        const string sql = """
                           insert into users (user_name, pin, balance)
                           values (@user_name, @pin, @balance);
                           """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_name", name);
        command.AddParameter("pin", pin);
        command.AddParameter("balance", StartBalance);

        const string sql2 = """
                            select user_id
                            from users
                            where user_name = @user_name;
                            """;
        using var command2 = new NpgsqlCommand(sql2, connection);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read())
        {
            long userId = reader.GetInt64(0);
            UpdateOperationInHistory(userId, operationType);
        }

        reader.Close();
    }

    public decimal ShowAccountBalance(long id)
    {
        const string sql = """
                           select balance
                           from users
                           where user_id = @user_id;
                           """;
        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("user_id", id);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read())
        {
            return reader.GetDecimal(0);
        }

        return 0;
    }

    public void AddMoneyToBalance(long id, decimal money)
    {
        string operationType = "Replenishment of the balance for " + money.ToString(CultureInfo.InvariantCulture);
        const string sql = """
                           update users
                           set balance = balance + @money
                           where user_id = @user_id;
                           """;
        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", id);
        command.AddParameter("money", money);
        UpdateOperationInHistory(id, operationType);
        command.ExecuteNonQuery();
    }

    public void RemoveMoneyFromBalance(long id, decimal money)
    {
        string operationType = "Withdrawal of " + money.ToString(CultureInfo.InvariantCulture) + " from the balance";
        const string sql = """
                           update users
                           set balance = balance - @money
                           where user_id = @user_id;
                           """;
        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", id);
        command.AddParameter("money", money);
        UpdateOperationInHistory(id, operationType);
        command.ExecuteNonQuery();
    }

    public IList<string> ShowAccountHistory(long id)
    {
        IList<string>? newList = new List<string>();
        const string sql = """
                           select operation_type
                           from account_operation_history
                           where user_id = @user_id;
                           """;
        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("user_id", id);

        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            newList.Add(reader.GetString(0));
        }

        return newList;
    }

    private static void UpdateOperationInHistory(long id, string operation)
    {
        const string sql = """
                           insert into account_operation_history (user_id, operation_type)
                           values (@user_id, @operation);
                           """;
        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", id);
        command.AddParameter("operation", operation);

        command.ExecuteReader();
    }
}