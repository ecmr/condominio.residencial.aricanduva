using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCondominio.Residencial.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inquilino",
                columns: table => new
                {
                    IdInquilino = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroContrato = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquilino", x => x.IdInquilino);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    Rg = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone1 = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone2 = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone3 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "Proprietario",
                columns: table => new
                {
                    IdProprietario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroMatricula = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietario", x => x.IdProprietario);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    IdMorador = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bloco = table.Column<string>(type: "TEXT", nullable: true),
                    Apartamento = table.Column<string>(type: "TEXT", nullable: true),
                    PessoaIdPessoa = table.Column<int>(type: "INTEGER", nullable: true),
                    ProprietarioIdProprietario = table.Column<int>(type: "INTEGER", nullable: true),
                    InquilinoIdInquilino = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.IdMorador);
                    table.ForeignKey(
                        name: "FK_Contatos_Inquilino_InquilinoIdInquilino",
                        column: x => x.InquilinoIdInquilino,
                        principalTable: "Inquilino",
                        principalColumn: "IdInquilino",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contatos_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contatos_Proprietario_ProprietarioIdProprietario",
                        column: x => x.ProprietarioIdProprietario,
                        principalTable: "Proprietario",
                        principalColumn: "IdProprietario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    IdVeiculo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: true),
                    Ano = table.Column<string>(type: "TEXT", nullable: true),
                    Cor = table.Column<string>(type: "TEXT", nullable: true),
                    Placa = table.Column<string>(type: "TEXT", nullable: true),
                    MoradorIdMorador = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.IdVeiculo);
                    table.ForeignKey(
                        name: "FK_Veiculo_Contatos_MoradorIdMorador",
                        column: x => x.MoradorIdMorador,
                        principalTable: "Contatos",
                        principalColumn: "IdMorador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_InquilinoIdInquilino",
                table: "Contatos",
                column: "InquilinoIdInquilino");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_PessoaIdPessoa",
                table: "Contatos",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_ProprietarioIdProprietario",
                table: "Contatos",
                column: "ProprietarioIdProprietario");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_MoradorIdMorador",
                table: "Veiculo",
                column: "MoradorIdMorador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Inquilino");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Proprietario");
        }
    }
}
