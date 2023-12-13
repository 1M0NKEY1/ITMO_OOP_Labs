using Itmo.Dev.Platform.Postgres.Plugins;
using Lab5.Applixation.Models;
using Npgsql;

namespace DataAccess.Plugins;

public class MappingPlugin : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder)
    {
        builder.MapEnum<UserRoles>();
    }
}