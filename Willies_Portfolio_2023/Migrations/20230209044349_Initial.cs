using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WilliesPortfolio2023.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmPreview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmMain = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NetProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NetProjectsBreakdownSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionHeader = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetProjectsBreakdownSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePreview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageHighQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageMediumQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageLowQuality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NetProjectsDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetProjectBreakdownSectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetProjectsDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NetProjectsDescriptions_NetProjectsBreakdownSections_NetProjectBreakdownSectionId",
                        column: x => x.NetProjectBreakdownSectionId,
                        principalTable: "NetProjectsBreakdownSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NetProjectsDescriptions_NetProjectBreakdownSectionId",
                table: "NetProjectsDescriptions",
                column: "NetProjectBreakdownSectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "NetProjects");

            migrationBuilder.DropTable(
                name: "NetProjectsDescriptions");

            migrationBuilder.DropTable(
                name: "Stills");

            migrationBuilder.DropTable(
                name: "NetProjectsBreakdownSections");
        }
    }
}
