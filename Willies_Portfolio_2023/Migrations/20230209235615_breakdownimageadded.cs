using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WilliesPortfolio2023.Migrations
{
    /// <inheritdoc />
    public partial class breakdownimageadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BreakdownImage",
                table: "NetProjectsBreakdownSections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BreakdownSecondaryImage",
                table: "NetProjectsBreakdownSections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreakdownImage",
                table: "NetProjectsBreakdownSections");

            migrationBuilder.DropColumn(
                name: "BreakdownSecondaryImage",
                table: "NetProjectsBreakdownSections");
        }
    }
}
