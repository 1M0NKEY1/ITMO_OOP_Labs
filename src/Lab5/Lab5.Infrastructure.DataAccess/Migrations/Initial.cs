using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace DataAccess.Migrations;

[Migration(1, "Initial")]

public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
        """
        create type user_role as enum
        (
        'admin',
        'customer'
        );
        
        create type account_state as enum
        (
        'created',
        'completed',
        'rejected'
        );

        create type account_result_state as enum
        (
            'completed',
            'rejected'
        );

        create table users
        (
            user_id bigint primary key generated always as identity ,
            user_name text not null ,
            user_role user_role not null 
        );

        create table accounts
        (
            account_id bigint primary key generated always as identity ,
            balance number
        );
        
        create table account_operation_history
        (
            account_id bigint primary key generated always as identify ,
            
        );

        create table orders
        (
            order_id bigint primary key generated always as identity ,
            order_state order_state not null ,
            shop_id bigint not null references shops(shop_id)
        );

        create table order_products
        (
            order_id bigint not null references orders(order_id),
            product_category_id bigint not null references product_categories(product_category_id),
            order_product_count int not null ,
            
            primary key (order_id, product_category_id)
        );

        create table order_results
        (
            order_id bigint not null references orders(order_id) primary key,
            order_result_state order_result_state not null ,
            order_result_cost money not null 
        );

        create table order_result_products
        (
            order_result_id bigint not null references order_results(order_id),
            product_id bigint not null references products(product_id),
            order_result_product_count int not null ,
            
            primary key (order_result_id, product_id)
        );
        """;

    protected override string GetDownSql(IServiceProvider serviceProvider)
    {
        throw new NotImplementedException();
    }
}