using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Formacao2021.Server.Migrations
{
    public partial class SomeFixesInscricoesEFormandos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formandos_Departamentos_DepartamentoID",
                table: "Formandos");

            migrationBuilder.DropForeignKey(
                name: "FK_Formandos_Empresas_EmpresaID",
                table: "Formandos");

            migrationBuilder.DropForeignKey(
                name: "FK_Marcacoes_Uhs_UhID",
                table: "Marcacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Uhs_UhID",
                table: "Salas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersUhs_Uhs_UhID",
                table: "UsersUhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Uhs",
                table: "Uhs");

            migrationBuilder.DropIndex(
                name: "IX_Formandos_EmpresaID",
                table: "Formandos");

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

            migrationBuilder.DropColumn(
                name: "UhID",
                table: "Uhs");

            migrationBuilder.DropColumn(
                name: "UhIATA",
                table: "Uhs");

            migrationBuilder.DropColumn(
                name: "UhNome",
                table: "Uhs");

            migrationBuilder.DropColumn(
                name: "EmpresaID",
                table: "Formandos");

            migrationBuilder.DropColumn(
                name: "Interno",
                table: "Formandos");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "Uhs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "IATA",
                table: "Uhs",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Uhs",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Inscricoes",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartamentoID",
                table: "Formandos",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Formandos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UhID",
                table: "Formandos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CursosFormandos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CursosFormandos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "CursosFormandos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "CursosFormandos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uhs",
                table: "Uhs",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3b04aa8e-4307-4711-93a4-e2fb2f09f5a5",
                column: "ConcurrencyStamp",
                value: "f454c11c-8ec9-4a7b-8a91-6b56b926c225");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e7526d31-3669-4f80-8e85-046e272634b6",
                column: "ConcurrencyStamp",
                value: "257fe161-aa07-4d8c-b3b0-7e7775b7485b");

            migrationBuilder.InsertData(
                table: "Uhs",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "IATA", "LastUpdatedAt", "LastUpdatedBy", "Nome" },
                values: new object[,]
                {
                    { new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"), null, null, "LIS", null, null, "LISBOA" },
                    { new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"), null, null, "OPO", null, null, "PORTO" },
                    { new Guid("7b277149-86d7-4c19-816c-0e97e803f491"), null, null, "FAO", null, null, "FARO" },
                    { new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"), null, null, "FNC", null, null, "FUNCHAL" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f03d16f2-90c6-434b-a36c-8a7ca7bc43c0", "4ff00216-786b-48fd-9275-69d2c29dcdf9" });

            migrationBuilder.CreateIndex(
                name: "IX_Formandos_UhID",
                table: "Formandos",
                column: "UhID");

            migrationBuilder.AddForeignKey(
                name: "FK_Formandos_Departamentos_DepartamentoID",
                table: "Formandos",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Formandos_Uhs_UhID",
                table: "Formandos",
                column: "UhID",
                principalTable: "Uhs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marcacoes_Uhs_UhID",
                table: "Marcacoes",
                column: "UhID",
                principalTable: "Uhs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Uhs_UhID",
                table: "Salas",
                column: "UhID",
                principalTable: "Uhs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersUhs_Uhs_UhID",
                table: "UsersUhs",
                column: "UhID",
                principalTable: "Uhs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formandos_Departamentos_DepartamentoID",
                table: "Formandos");

            migrationBuilder.DropForeignKey(
                name: "FK_Formandos_Uhs_UhID",
                table: "Formandos");

            migrationBuilder.DropForeignKey(
                name: "FK_Marcacoes_Uhs_UhID",
                table: "Marcacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Uhs_UhID",
                table: "Salas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersUhs_Uhs_UhID",
                table: "UsersUhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Uhs",
                table: "Uhs");

            migrationBuilder.DropIndex(
                name: "IX_Formandos_UhID",
                table: "Formandos");

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "ID",
                keyValue: new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"));

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "ID",
                keyValue: new Guid("7b277149-86d7-4c19-816c-0e97e803f491"));

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "ID",
                keyValue: new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"));

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "ID",
                keyValue: new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"));

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Uhs");

            migrationBuilder.DropColumn(
                name: "IATA",
                table: "Uhs");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Uhs");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Inscricoes");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Formandos");

            migrationBuilder.DropColumn(
                name: "UhID",
                table: "Formandos");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CursosFormandos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CursosFormandos");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "CursosFormandos");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "CursosFormandos");

            migrationBuilder.AddColumn<Guid>(
                name: "UhID",
                table: "Uhs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UhIATA",
                table: "Uhs",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UhNome",
                table: "Uhs",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartamentoID",
                table: "Formandos",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaID",
                table: "Formandos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Interno",
                table: "Formandos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uhs",
                table: "Uhs",
                column: "UhID");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3b04aa8e-4307-4711-93a4-e2fb2f09f5a5",
                column: "ConcurrencyStamp",
                value: "f3943327-7367-4757-a941-e578c0188e35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e7526d31-3669-4f80-8e85-046e272634b6",
                column: "ConcurrencyStamp",
                value: "d80f113f-059d-4065-8791-96d5c057e3b6");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0573fc9-78cc-4d94-ac48-931de919f6ad", "346b569d-a5e7-40e7-b2ed-49e101a80faf" });

            migrationBuilder.CreateIndex(
                name: "IX_Formandos_EmpresaID",
                table: "Formandos",
                column: "EmpresaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Formandos_Departamentos_DepartamentoID",
                table: "Formandos",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formandos_Empresas_EmpresaID",
                table: "Formandos",
                column: "EmpresaID",
                principalTable: "Empresas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Marcacoes_Uhs_UhID",
                table: "Marcacoes",
                column: "UhID",
                principalTable: "Uhs",
                principalColumn: "UhID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Uhs_UhID",
                table: "Salas",
                column: "UhID",
                principalTable: "Uhs",
                principalColumn: "UhID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersUhs_Uhs_UhID",
                table: "UsersUhs",
                column: "UhID",
                principalTable: "Uhs",
                principalColumn: "UhID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
