using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationSite.Migrations
{
    /// <inheritdoc />
    public partial class sixtymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "beneficiado",
                table: "Doacoes");

            migrationBuilder.CreateTable(
                name: "Beneficiarios",
                columns: table => new
                {
                    beneficiarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doacaoid = table.Column<int>(type: "int", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiarios");

            migrationBuilder.AddColumn<string>(
                name: "beneficiado",
                table: "Doacoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
