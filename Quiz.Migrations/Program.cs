// See https://aka.ms/new-console-template for more information

using Quiz.Migrations;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Quiz.Migrations;


const string connectionString = "Server=.;Database=Quiz2;Trusted_Connection=True;" +
                                "TrustServerCertificate=True;Integrated Security=true";

var serviceCollection = new ServiceCollection()
    .AddFluentMigratorCore()
    .ConfigureRunner(rb => rb.AddSqlServer()
        .WithGlobalConnectionString(connectionString)
        .ScanIn(typeof( _202402171640_CreateTeamTable   ).Assembly).For.Migrations())
    .BuildServiceProvider();
serviceCollection.GetRequiredService<IMigrationRunner>().MigrateUp();