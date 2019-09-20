using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _01AulaPerdida.Migrations
{
    public partial class addmigrationinicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atleta",
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
                    table.PrimaryKey("PK_Atleta", x => x.AtletaId);
                });

            migrationBuilder.CreateTable(
                name: "Trajeto",
                columns: table => new
                {
                    TrajetoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Distancia = table.Column<float>(nullable: false),
                    LocalInicio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trajeto", x => x.TrajetoId);
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
                        name: "FK_Corridas_Trajeto_TrajetoId",
                        column: x => x.TrajetoId,
                        principalTable: "Trajeto",
                        principalColumn: "TrajetoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorridaAtleta",
                columns: table => new
                {
                    CorridaId = table.Column<int>(nullable: false),
                    AtletaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorridaAtleta", x => new { x.AtletaId, x.CorridaId });
                    table.ForeignKey(
                        name: "FK_CorridaAtleta_Atleta_AtletaId",
                        column: x => x.AtletaId,
                        principalTable: "Atleta",
                        principalColumn: "AtletaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorridaAtleta_Corridas_CorridaId",
                        column: x => x.CorridaId,
                        principalTable: "Corridas",
                        principalColumn: "CorridaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medalha",
                columns: table => new
                {
                    MedalhaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    CorridaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medalha", x => x.MedalhaId);
                    table.ForeignKey(
                        name: "FK_Medalha_Corridas_CorridaId",
                        column: x => x.CorridaId,
                        principalTable: "Corridas",
                        principalColumn: "CorridaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CorridaAtleta_CorridaId",
                table: "CorridaAtleta",
                column: "CorridaId");

            migrationBuilder.CreateIndex(
                name: "IX_Corridas_TrajetoId",
                table: "Corridas",
                column: "TrajetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medalha_CorridaId",
                table: "Medalha",
                column: "CorridaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorridaAtleta");

            migrationBuilder.DropTable(
                name: "Medalha");

            migrationBuilder.DropTable(
                name: "Atleta");

            migrationBuilder.DropTable(
                name: "Corridas");

            migrationBuilder.DropTable(
                name: "Trajeto");
        }
    }
}
