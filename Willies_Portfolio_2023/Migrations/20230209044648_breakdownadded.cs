using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WilliesPortfolio2023.Migrations
{
    /// <inheritdoc />
    public partial class breakdownadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NetProjectId",
                table: "NetProjectsBreakdownSections",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NetProjectsBreakdownSections_NetProjectId",
                table: "NetProjectsBreakdownSections",
                column: "NetProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_NetProjectsBreakdownSections_NetProjects_NetProjectId",
                table: "NetProjectsBreakdownSections",
                column: "NetProjectId",
                principalTable: "NetProjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NetProjectsBreakdownSections_NetProjects_NetProjectId",
                table: "NetProjectsBreakdownSections");

            migrationBuilder.DropIndex(
                name: "IX_NetProjectsBreakdownSections_NetProjectId",
                table: "NetProjectsBreakdownSections");

            migrationBuilder.DropColumn(
                name: "NetProjectId",
                table: "NetProjectsBreakdownSections");
        }
    }
}
