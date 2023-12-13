using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace DataAccess.Migrations;

[Migration(1, "Initial")]

public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
        """
        create type operation_state as enum
        (
            'created',
            'completed',
            'rejected'
        );

        create table users
        (
            user_id bigint primary key generated always as identity ,
            user_name text not null ,
            pin bigint ,
            balance numeric
        );
        
        create table admins
        (
            admin_id bigint primary key generated always as identity ,
            admin_name text not null ,
            administrator_key bigint
        );
        
        create table account_operation_history
        (
            user_id bigint primary key generated always as identify ,
            operation_type text not null ,
            operation_state operation_state
        );
        """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
        """
            drop table users;
            drop table admins;
            drop table account_operation_history

            drop type operation_state
        """;
}