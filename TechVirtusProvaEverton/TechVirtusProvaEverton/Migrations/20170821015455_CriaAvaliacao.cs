using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace TechVirtusProvaEverton.Migrations
{
    public partial class CriaAvaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_EmpresaContratada_Transacao_TransacaoId", table: "EmpresaContratada");
            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusAnalise = table.Column<string>(nullable: true),
                    TransacaoId = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Transacao_TransacaoId",
                        column: x => x.TransacaoId,
                        principalTable: "Transacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_EmpresaContratada_EmpresaContratadaId",
                table: "Transacao",
                column: "EmpresaContratadaId",
                principalTable: "EmpresaContratada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Transacao_EmpresaContratada_EmpresaContratadaId", table: "Transacao");
            migrationBuilder.DropTable("Avaliacao");
            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaContratada_Transacao_TransacaoId",
                table: "EmpresaContratada",
                column: "TransacaoId",
                principalTable: "Transacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
