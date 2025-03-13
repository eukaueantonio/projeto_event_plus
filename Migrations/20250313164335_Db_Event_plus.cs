using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_event_plus.Migrations
{
    /// <inheritdoc />
    public partial class Db_Event_plus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    IdInstituicoes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.IdInstituicoes);
                });

            migrationBuilder.CreateTable(
                name: "TiposEventos",
                columns: table => new
                {
                    IdTiposEventos = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloTipoEvento = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEventos", x => x.IdTiposEventos);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuarios",
                columns: table => new
                {
                    IdTiposUsuarios = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloTipoUsuario = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuarios", x => x.IdTiposUsuarios);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEvento = table.Column<DateTime>(type: "DATE", nullable: false),
                    NomeEvento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    IdTiposEventos = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInstituicoes = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Eventos_Instituicoes_IdInstituicoes",
                        column: x => x.IdInstituicoes,
                        principalTable: "Instituicoes",
                        principalColumn: "IdInstituicoes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eventos_TiposEventos_IdTiposEventos",
                        column: x => x.IdTiposEventos,
                        principalTable: "TiposEventos",
                        principalColumn: "IdTiposEventos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeUsuario = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    IdTiposUsuarios = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_TiposUsuarios_IdTiposUsuarios",
                        column: x => x.IdTiposUsuarios,
                        principalTable: "TiposUsuarios",
                        principalColumn: "IdTiposUsuarios",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComentarioEvento",
                columns: table => new
                {
                    IdComentarioEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Exibe = table.Column<bool>(type: "BIT", nullable: false),
                    IdUsuarios = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEventos = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioEvento", x => x.IdComentarioEvento);
                    table.ForeignKey(
                        name: "FK_ComentarioEvento_Eventos_IdEventos",
                        column: x => x.IdEventos,
                        principalTable: "Eventos",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComentarioEvento_Usuarios_IdUsuarios",
                        column: x => x.IdUsuarios,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PresencasEventos",
                columns: table => new
                {
                    IdPresenca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Situacao = table.Column<bool>(type: "BIT", nullable: false),
                    IdUsuarios = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEventos = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresencasEventos", x => x.IdPresenca);
                    table.ForeignKey(
                        name: "FK_PresencasEventos_Eventos_IdEventos",
                        column: x => x.IdEventos,
                        principalTable: "Eventos",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PresencasEventos_Usuarios_IdUsuarios",
                        column: x => x.IdUsuarios,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEvento_IdEventos",
                table: "ComentarioEvento",
                column: "IdEventos");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEvento_IdUsuarios",
                table: "ComentarioEvento",
                column: "IdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_IdInstituicoes",
                table: "Eventos",
                column: "IdInstituicoes");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_IdTiposEventos",
                table: "Eventos",
                column: "IdTiposEventos");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicoes_CNPJ",
                table: "Instituicoes",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PresencasEventos_IdEventos",
                table: "PresencasEventos",
                column: "IdEventos");

            migrationBuilder.CreateIndex(
                name: "IX_PresencasEventos_IdUsuarios",
                table: "PresencasEventos",
                column: "IdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdTiposUsuarios",
                table: "Usuarios",
                column: "IdTiposUsuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentarioEvento");

            migrationBuilder.DropTable(
                name: "PresencasEventos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Instituicoes");

            migrationBuilder.DropTable(
                name: "TiposEventos");

            migrationBuilder.DropTable(
                name: "TiposUsuarios");
        }
    }
}
