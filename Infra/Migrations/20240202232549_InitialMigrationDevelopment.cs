using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationDevelopment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UF = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gestores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iatas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passageiros",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dtnascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    idade = table.Column<int>(type: "integer", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passageiros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aeroportos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IataID = table.Column<long>(type: "bigint", nullable: false),
                    CodigoIATA = table.Column<string>(type: "text", nullable: false),
                    CidadeID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeroportos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aeroportos_Cidades_CidadeID",
                        column: x => x.CidadeID,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aeroportos_Iatas_IataID",
                        column: x => x.IataID,
                        principalTable: "Iatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AeroportoOrigemID = table.Column<long>(type: "bigint", nullable: false),
                    AeroportoDestinoID = table.Column<long>(type: "bigint", nullable: false),
                    DataHoraPartida = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PrecoTotal = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voos_Aeroportos_AeroportoDestinoID",
                        column: x => x.AeroportoDestinoID,
                        principalTable: "Aeroportos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voos_Aeroportos_AeroportoOrigemID",
                        column: x => x.AeroportoOrigemID,
                        principalTable: "Aeroportos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TipoClasse = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeAssentos = table.Column<int>(type: "integer", nullable: false),
                    ValorAssento = table.Column<decimal>(type: "numeric", nullable: false),
                    VooID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Voos_VooID",
                        column: x => x.VooID,
                        principalTable: "Voos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompraDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PassageiroID = table.Column<long>(type: "bigint", nullable: false),
                    VooID = table.Column<long>(type: "bigint", nullable: false),
                    ClasseID = table.Column<long>(type: "bigint", nullable: false),
                    QuantidadePassagens = table.Column<int>(type: "integer", nullable: false),
                    VooId = table.Column<int>(type: "integer", nullable: false),
                    ClasseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraID);
                    table.ForeignKey(
                        name: "FK_Compras_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Passageiros_PassageiroID",
                        column: x => x.PassageiroID,
                        principalTable: "Passageiros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Voos_VooId",
                        column: x => x.VooId,
                        principalTable: "Voos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ReservaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PassageiroId = table.Column<long>(type: "bigint", nullable: false),
                    VooId = table.Column<int>(type: "integer", nullable: false),
                    ClasseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservaID);
                    table.ForeignKey(
                        name: "FK_Reservas_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Passageiros_PassageiroId",
                        column: x => x.PassageiroId,
                        principalTable: "Passageiros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Voos_VooId",
                        column: x => x.VooId,
                        principalTable: "Voos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    PassagemID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VooID = table.Column<long>(type: "bigint", nullable: false),
                    ClasseID = table.Column<long>(type: "bigint", nullable: false),
                    PassageiroID = table.Column<long>(type: "bigint", nullable: false),
                    CompraID = table.Column<long>(type: "bigint", nullable: false),
                    PrecoTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    VooId = table.Column<int>(type: "integer", nullable: false),
                    ClasseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.PassagemID);
                    table.ForeignKey(
                        name: "FK_Passagens_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Passagens_Compras_CompraID",
                        column: x => x.CompraID,
                        principalTable: "Compras",
                        principalColumn: "CompraID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Passagens_Passageiros_PassageiroID",
                        column: x => x.PassageiroID,
                        principalTable: "Passageiros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Passagens_Voos_VooId",
                        column: x => x.VooId,
                        principalTable: "Voos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bagagens",
                columns: table => new
                {
                    BagagemID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PassagemID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagagens", x => x.BagagemID);
                    table.ForeignKey(
                        name: "FK_Bagagens_Passagens_PassagemID",
                        column: x => x.PassagemID,
                        principalTable: "Passagens",
                        principalColumn: "PassagemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aeroportos_CidadeID",
                table: "Aeroportos",
                column: "CidadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Aeroportos_IataID",
                table: "Aeroportos",
                column: "IataID");

            migrationBuilder.CreateIndex(
                name: "IX_Bagagens_PassagemID",
                table: "Bagagens",
                column: "PassagemID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_VooID",
                table: "Classes",
                column: "VooID");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClasseId",
                table: "Compras",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_PassageiroID",
                table: "Compras",
                column: "PassageiroID");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_VooId",
                table: "Compras",
                column: "VooId");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_ClasseId",
                table: "Passagens",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_CompraID",
                table: "Passagens",
                column: "CompraID");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_PassageiroID",
                table: "Passagens",
                column: "PassageiroID");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_VooId",
                table: "Passagens",
                column: "VooId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClasseId",
                table: "Reservas",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PassageiroId",
                table: "Reservas",
                column: "PassageiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_VooId",
                table: "Reservas",
                column: "VooId");

            migrationBuilder.CreateIndex(
                name: "IX_Voos_AeroportoDestinoID",
                table: "Voos",
                column: "AeroportoDestinoID");

            migrationBuilder.CreateIndex(
                name: "IX_Voos_AeroportoOrigemID",
                table: "Voos",
                column: "AeroportoOrigemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagagens");

            migrationBuilder.DropTable(
                name: "Gestores");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Passagens");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Passageiros");

            migrationBuilder.DropTable(
                name: "Voos");

            migrationBuilder.DropTable(
                name: "Aeroportos");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Iatas");
        }
    }
}
