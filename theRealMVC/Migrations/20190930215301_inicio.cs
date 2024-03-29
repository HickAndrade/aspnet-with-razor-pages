﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace theRealMVC.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celas",
                columns: table => new
                {
                    CelaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Area = table.Column<float>(nullable: false),
                    QuantidadeMaxima = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celas", x => x.CelaId);
                });

            migrationBuilder.CreateTable(
                name: "Presidiarios",
                columns: table => new
                {
                    PresidiarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    dataEntrada = table.Column<DateTime>(nullable: false),
                    dataSaida = table.Column<DateTime>(nullable: false),
                    nivelEscolaridade = table.Column<int>(nullable: false),
                    saidaTemporaria = table.Column<bool>(nullable: false),
                    CelaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presidiarios", x => x.PresidiarioId);
                    table.ForeignKey(
                        name: "FK_Presidiarios_Celas_CelaId",
                        column: x => x.CelaId,
                        principalTable: "Celas",
                        principalColumn: "CelaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presidiarios_CelaId",
                table: "Presidiarios",
                column: "CelaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presidiarios");

            migrationBuilder.DropTable(
                name: "Celas");
        }
    }
}
