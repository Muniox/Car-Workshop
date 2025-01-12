using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorkshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CarWorkshopServicesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                oldCollation: "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "CarWorkshops")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserTokens")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUsers")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserRoles")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserLogins")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserClaims")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetRoles")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetRoleClaims")
                .OldAnnotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cost = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarWorkshopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_CarWorkshops_CarWorkshopId",
                        column: x => x.CarWorkshopId,
                        principalTable: "CarWorkshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_CarWorkshopId",
                table: "Services",
                column: "CarWorkshopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.AlterDatabase(
                collation: "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "CarWorkshops")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserTokens")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUsers")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserRoles")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserLogins")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetUserClaims")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetRoles")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.AlterTable(
                name: "AspNetRoleClaims")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");
        }
    }
}
