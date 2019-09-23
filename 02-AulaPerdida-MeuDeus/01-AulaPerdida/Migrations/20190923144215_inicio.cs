using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _01AulaPerdida.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atletas",
                columns: table => new
                {
                    AtletaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Profissional = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atletas", x => x.AtletaId);
                });

            migrationBuilder.CreateTable(
                name: "Trajetos",
                columns: table => new
                {
                    TrajetoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Distancia = table.Column<float>(nullable: false),
                    LocalInicio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trajetos", x => x.TrajetoId);
                });

            migrationBuilder.CreateTable(
                name: "Corridas",
                columns: table => new
                {
                    CorridaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Distancia = table.Column<float>(nullable: false),
                    Premiacao = table.Column<bool>(nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    TrajetoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corridas", x => x.CorridaId);
                    table.ForeignKey(
                        name: "FK_Corridas_Trajetos_TrajetoId",
                        column: x => x.TrajetoId,
                        principalTable: "Trajetos",
                        principalColumn: "TrajetoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorridaAtletas",
                columns: table => new
                {
                    CorridaId = table.Column<int>(nullable: false),
                    AtletaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorridaAtletas", x => new { x.AtletaId, x.CorridaId });
                    table.ForeignKey(
                        name: "FK_CorridaAtletas_Atletas_AtletaId",
                        column: x => x.AtletaId,
                        principalTable: "Atletas",
                        principalColumn: "AtletaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorridaAtletas_Corridas_CorridaId",
                        column: x => x.CorridaId,
                        principalTable: "Corridas",
                        principalColumn: "CorridaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medalhas",
                columns: table => new
                {
                    MedalhaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    CorridaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medalhas", x => x.MedalhaId);
                    table.ForeignKey(
                        name: "FK_Medalhas_Corridas_CorridaId",
                        column: x => x.CorridaId,
                        principalTable: "Corridas",
                        principalColumn: "CorridaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CorridaAtletas_CorridaId",
                table: "CorridaAtletas",
                column: "CorridaId");

            migrationBuilder.CreateIndex(
                name: "IX_Corridas_TrajetoId",
                table: "Corridas",
                column: "TrajetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medalhas_CorridaId",
                table: "Medalhas",
                column: "CorridaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorridaAtletas");

            migrationBuilder.DropTable(
                name: "Medalhas");

            migrationBuilder.DropTable(
                name: "Atletas");

            migrationBuilder.DropTable(
                name: "Corridas");

            migrationBuilder.DropTable(
                name: "Trajetos");
        }
    }
}
