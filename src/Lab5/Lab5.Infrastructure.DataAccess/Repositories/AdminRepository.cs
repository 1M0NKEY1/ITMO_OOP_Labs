using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Applixation.Models;
using Npgsql;

namespace DataAccess.Repositories;

public class AdminRepository : IAdminRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public AdminRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public Admin? FindAdminByAdminId(long id, long adminKey)
    {
        const string sql = """
                           select admin_id, admin_name, admin_key
                           from admins
                           where admin_id = @id and admin_key = @adminKey;
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
        command.AddParameter("admin_id", id);
        command.AddParameter("admin_key", adminKey);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new Admin(
            AdminId: reader.GetInt64(0),
            AdminName: reader.GetString(1),
            AdministratorKey: reader.GetInt64(2));
    }

    public void ChangeAdminKey(long id, long newAdminKey)
    {
        const string sql = """
                           select admin_key
                           from admins
                           where admin_id = @id;
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
        using NpgsqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            reader.Close();

            const string updateSql = """
                                     update admins
                                     set admin_key = @balance
                                     where admin_id = @id;
                                     """;

            using var updateCommand = new NpgsqlCommand(updateSql, connection);
            updateCommand.Parameters.AddWithValue("id", id);
            updateCommand.Parameters.AddWithValue("admin_key", newAdminKey);

            updateCommand.ExecuteNonQuery();
        }
    }
}