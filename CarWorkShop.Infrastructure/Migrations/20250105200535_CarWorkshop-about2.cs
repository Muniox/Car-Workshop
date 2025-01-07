using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorkshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CarWorkshopabout2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                oldCollation: "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "CarWorkshops")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                collation: "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "CarWorkshops")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");
        }
    }
}
