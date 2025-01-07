using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorkshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CarWorkshopabout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                oldCollation: "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "CarWorkshops")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "CarWorkshops",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_unicode_ci")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "CarWorkshops");

            migrationBuilder.AlterDatabase(
                collation: "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "CarWorkshops")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");
        }
    }
}
