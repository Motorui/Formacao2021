using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Formacao2021.Server.Migrations
{
    public partial class InitialRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersUhs_Users_UserId",
                table: "UsersUhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersUhs",
                table: "UsersUhs");

            migrationBuilder.DropIndex(
                name: "IX_UsersUhs_UserId",
                table: "UsersUhs");

            migrationBuilder.DropColumn(
                name: "UserUhID",
                table: "UsersUhs");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UsersUhs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UsersUhs",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UhNome",
                table: "Uhs",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersUhs",
                table: "UsersUhs",
                columns: new[] { "UserId", "UhID" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b04aa8e-4307-4711-93a4-e2fb2f09f5a5", "32abb263-f01c-47b0-b91d-fdda97e1aeb2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "User", "USER" },
                    { "e7526d31-3669-4f80-8e85-046e272634b6", "34ee11d8-334c-40ce-82ac-af3263762b76", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Uhs",
                columns: new[] { "UhID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "UhIATA", "UhNome" },
                values: new object[,]
                {
                    { new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"), null, null, null, null, "LIS", "LISBOA" },
                    { new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"), null, null, null, null, "OPO", "PORTO" },
                    { new Guid("7b277149-86d7-4c19-816c-0e97e803f491"), null, null, null, null, "FAO", "FARO" },
                    { new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"), null, null, null, null, "FNC", "FUNCHAL" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ed3083c5-dada-44f6-8f3e-fec4c3c4477f", 0, "4cda89b3-91f3-4082-9bc1-1c81b050b8b6", "rui.santos@portway.pt", false, false, null, "Rui Pereira", "RUI.SANTOS@PORTWAY.PT", "RAPEREIRA", "AQAAAAEAACcQAAAAEK9oxRxsEji9BpEDLL5EwMNTFo3ZsVhz9hXDT+9sNzP9n1pQhQ55VzY7yt00BKRJeg==", null, false, "387ba83d-3eb6-4edf-8200-232923776a80", false, "RaPereira" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ed3083c5-dada-44f6-8f3e-fec4c3c4477f", "e7526d31-3669-4f80-8e85-046e272634b6" });

            migrationBuilder.InsertData(
                table: "UsersUhs",
                columns: new[] { "UserId", "UhID", "UserId1" },
                values: new object[,]
                {
                    { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"), null },
                    { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"), null },
                    { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("7b277149-86d7-4c19-816c-0e97e803f491"), null },
                    { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersUhs_UserId1",
                table: "UsersUhs",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersUhs_Users_UserId1",
                table: "UsersUhs",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersUhs_Users_UserId1",
                table: "UsersUhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersUhs",
                table: "UsersUhs");

            migrationBuilder.DropIndex(
                name: "IX_UsersUhs_UserId1",
                table: "UsersUhs");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3b04aa8e-4307-4711-93a4-e2fb2f09f5a5");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ed3083c5-dada-44f6-8f3e-fec4c3c4477f", "e7526d31-3669-4f80-8e85-046e272634b6" });

            migrationBuilder.DeleteData(
                table: "UsersUhs",
                keyColumns: new[] { "UserId", "UhID" },
                keyValues: new object[] { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac") });

            migrationBuilder.DeleteData(
                table: "UsersUhs",
                keyColumns: new[] { "UserId", "UhID" },
                keyValues: new object[] { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("7b277149-86d7-4c19-816c-0e97e803f491") });

            migrationBuilder.DeleteData(
                table: "UsersUhs",
                keyColumns: new[] { "UserId", "UhID" },
                keyValues: new object[] { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471") });

            migrationBuilder.DeleteData(
                table: "UsersUhs",
                keyColumns: new[] { "UserId", "UhID" },
                keyValues: new object[] { new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"), new Guid("807aeb52-f2d7-4152-8410-a668604a41d4") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e7526d31-3669-4f80-8e85-046e272634b6");

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "UhID",
                keyValue: new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"));

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "UhID",
                keyValue: new Guid("7b277149-86d7-4c19-816c-0e97e803f491"));

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "UhID",
                keyValue: new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"));

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "UhID",
                keyValue: new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed3083c5-dada-44f6-8f3e-fec4c3c4477f");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UsersUhs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UsersUhs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "UserUhID",
                table: "UsersUhs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "UhNome",
                table: "Uhs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersUhs",
                table: "UsersUhs",
                column: "UserUhID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersUhs_UserId",
                table: "UsersUhs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersUhs_Users_UserId",
                table: "UsersUhs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
