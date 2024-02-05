using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationSite.Migrations
{
    /// <inheritdoc />
    public partial class eightymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiarios",
                columns: table => new
                {
                    beneficiarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doacaoid = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiarios", x => x.beneficiarioId);
                    table.ForeignKey(
                        name: "FK_Beneficiarios_Doacoes_doacaoid",
                        column: x => x.doacaoid,
                        principalTable: "Doacoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiarios_doacaoid",
                table: "Beneficiarios",
                column: "doacaoid");
        }
    }
}
