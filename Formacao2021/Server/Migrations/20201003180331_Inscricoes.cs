using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Formacao2021.Server.Migrations
{
    public partial class Inscricoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursosFormandos_Cursos_CursoID",
                table: "CursosFormandos");

            migrationBuilder.DropForeignKey(
                name: "FK_CursosFormandos_Formandos_FormandoID",
                table: "CursosFormandos");

            migrationBuilder.DropTable(
                name: "MarcacoesIniciais");

            migrationBuilder.DropTable(
                name: "RefrescamentosFormandos");

            migrationBuilder.DropTable(
                name: "Refrescamentos");

            migrationBuilder.DropIndex(
                name: "IX_CursosFormandos_CursoID",
                table: "CursosFormandos");

            migrationBuilder.CreateTable(
                name: "Inscricoes",
                columns: table => new
                {
                    FormandoID = table.Column<Guid>(nullable: false),
                    MarcacaoID = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricoes", x => new { x.FormandoID, x.MarcacaoID });
                });

            migrationBuilder.CreateTable(
                name: "Marcacoes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    Capacidade = table.Column<int>(nullable: false),
                    Observacoes = table.Column<string>(nullable: true),
                    SalaID = table.Column<Guid>(nullable: false),
                    CursoID = table.Column<Guid>(nullable: false),
                    UhID = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcacoes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Marcacoes_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Marcacoes_Salas_SalaID",
                        column: x => x.SalaID,
                        principalTable: "Salas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Marcacoes_Uhs_UhID",
                        column: x => x.UhID,
                        principalTable: "Uhs",
                        principalColumn: "UhID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Nome" },
                values: new object[,]
                {
                    { new Guid("f6df5993-d2ba-4d8b-9bcb-ac4f1b7fb624"), null, null, null, null, "PORTWAY" },
                    { new Guid("fd47ee52-979e-4381-b1be-93288de25af0"), null, null, null, null, "EXTERNO" }
                });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0573fc9-78cc-4d94-ac48-931de919f6ad", "AQAAAAEAACcQAAAAEK9oxRxsEji9BpEDLL5EwMNTFo3ZsVhz9hXDT+9sNzP9n1pQhQ55VzY7yt00BKRJeg==", "346b569d-a5e7-40e7-b2ed-49e101a80faf" });

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_CursoID",
                table: "Marcacoes",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_SalaID",
                table: "Marcacoes",
                column: "SalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_UhID",
                table: "Marcacoes",
                column: "UhID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscricoes");

            migrationBuilder.DropTable(
                name: "Marcacoes");

            migrationBuilder.DeleteData(
                table: "Grupos",
                keyColumn: "ID",
                keyValue: new Guid("f6df5993-d2ba-4d8b-9bcb-ac4f1b7fb624"));

            migrationBuilder.DeleteData(
                table: "Grupos",
                keyColumn: "ID",
                keyValue: new Guid("fd47ee52-979e-4381-b1be-93288de25af0"));

            migrationBuilder.CreateTable(
                name: "MarcacoesIniciais",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capaciade = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UhID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcacoesIniciais", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MarcacoesIniciais_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarcacoesIniciais_Salas_SalaID",
                        column: x => x.SalaID,
                        principalTable: "Salas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarcacoesIniciais_Uhs_UhID",
                        column: x => x.UhID,
                        principalTable: "Uhs",
                        principalColumn: "UhID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Refrescamentos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Duracao = table.Column<int>(type: "int", nullable: false),
                    Elearning = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refrescamentos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Refrescamentos_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefrescamentosFormandos",
                columns: table => new
                {
                    FormandoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefrescamentoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefrescamentosFormandos", x => new { x.FormandoID, x.RefrescamentoID });
                    table.ForeignKey(
                        name: "FK_RefrescamentosFormandos_Formandos_FormandoID",
                        column: x => x.FormandoID,
                        principalTable: "Formandos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefrescamentosFormandos_Refrescamentos_RefrescamentoID",
                        column: x => x.RefrescamentoID,
                        principalTable: "Refrescamentos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3b04aa8e-4307-4711-93a4-e2fb2f09f5a5",
                column: "ConcurrencyStamp",
                value: "32abb263-f01c-47b0-b91d-fdda97e1aeb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e7526d31-3669-4f80-8e85-046e272634b6",
                column: "ConcurrencyStamp",
                value: "34ee11d8-334c-40ce-82ac-af3263762b76");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cda89b3-91f3-4082-9bc1-1c81b050b8b6", "rui050476", "387ba83d-3eb6-4edf-8200-232923776a80" });

            migrationBuilder.CreateIndex(
                name: "IX_CursosFormandos_CursoID",
                table: "CursosFormandos",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacoesIniciais_CursoID",
                table: "MarcacoesIniciais",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacoesIniciais_SalaID",
                table: "MarcacoesIniciais",
                column: "SalaID");

            migrationBuilder.CreateIndex(
                name: "IX_MarcacoesIniciais_UhID",
                table: "MarcacoesIniciais",
                column: "UhID");

            migrationBuilder.CreateIndex(
                name: "IX_Refrescamentos_CursoID",
                table: "Refrescamentos",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_RefrescamentosFormandos_RefrescamentoID",
                table: "RefrescamentosFormandos",
                column: "RefrescamentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_CursosFormandos_Cursos_CursoID",
                table: "CursosFormandos",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursosFormandos_Formandos_FormandoID",
                table: "CursosFormandos",
                column: "FormandoID",
                principalTable: "Formandos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
