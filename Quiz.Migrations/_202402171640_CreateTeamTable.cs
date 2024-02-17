using FluentMigrator;

namespace Quiz.Migrations;

[Migration(202402171640)]
public class _202402171640_CreateTeamTable : Migration
{
    public override void Up()
    {
        Create.Table("Team").WithColumn("Id").AsInt32().PrimaryKey()
            .Identity().WithColumn("Name").AsString().NotNullable()
            .WithColumn("FirstColor").AsString().NotNullable()
            .WithColumn("SecondColor").AsString().NotNullable();

        Create.Table("Player").WithColumn("Id").AsInt32().PrimaryKey()
            .Identity()
            .WithColumn("Name").AsString().NotNullable()
            .WithColumn("Birth").AsDateTime().NotNullable()
            .WithColumn("TeamId").AsInt32().Nullable()
            .ForeignKey("FK_Player_Team", "Team", "Id");
    }

    public override void Down()
    {
        Delete.Table("Player");
        Delete.Table("Team");
    }
}