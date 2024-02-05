using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonationSite.Migrations
{
    /// <inheritdoc />
    public partial class ninetymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "beneficario",
                table: "Doacoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "beneficario",
                table: "Doacoes");
        }
    }
}
