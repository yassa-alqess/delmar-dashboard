using FluentMigrator;
using Serenity.Extensions;

namespace Dashboard.Migrations.DefaultDB
{
    [Migration(20141111113000)]
    public class DefaultDB_20141111_113000_Permissions : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("UserPermissions", "UserPermissionId", s => s
                .WithColumn("UserId").AsInt32().NotNullable()
                    .ForeignKey("FK_UserPermissions_UserId", "Users", "UserId")
                .WithColumn("PermissionKey").AsString(100).NotNullable()
                .WithColumn("Granted").AsBoolean().NotNullable().WithDefaultValue(true), "serene");

            Create.Index("UQ_UserPerm_UserId_PermKey")
                .OnTable("UserPermissions")
                .InSchema("serene")
                .OnColumn("UserId").Ascending()
                .OnColumn("PermissionKey").Ascending()
                .WithOptions().Unique();

            this.CreateTableWithId32("Roles", "RoleId", s => s
                .WithColumn("RoleName").AsString(100).NotNullable(), "serene");

            this.CreateTableWithId64("RolePermissions", "RolePermissionId", s => s
                .WithColumn("RoleId").AsInt32().NotNullable()
                    .ForeignKey("FK_RolePermissions_RoleId", "Roles", "RoleId")
                .WithColumn("PermissionKey").AsString(100).NotNullable(), "serene");

            Create.Index("UQ_RolePerm_RoleId_PermKey")
                .OnTable("RolePermissions")
                .InSchema("serene")
                .OnColumn("RoleId").Ascending()
                .OnColumn("PermissionKey").Ascending()
                .WithOptions().Unique();

            this.CreateTableWithId64("UserRoles", "UserRoleId", s => s
                .WithColumn("UserId").AsInt32().NotNullable()
                    .ForeignKey("FK_UserRoles_UserId", "Users", "UserId")
                .WithColumn("RoleId").AsInt32().NotNullable()
                    .ForeignKey("FK_UserRoles_RoleId", "Roles", "RoleId"), "serene");

            Create.Index("UQ_UserRoles_UserId_RoleId")
                .OnTable("UserRoles")
                .InSchema("serene")
                .OnColumn("UserId").Ascending()
                .OnColumn("RoleId").Ascending()
                .WithOptions().Unique();

            Create.Index("IX_UserRoles_RoleId_UserId")
                .OnTable("UserRoles")
                .InSchema("serene")
                .OnColumn("RoleId").Ascending()
                .OnColumn("UserId").Ascending();
        }
    }
}