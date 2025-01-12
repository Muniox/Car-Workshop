using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorkshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatedByIdAddedToWorkshop : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "CarWorkshops",
                type: "varchar(255)",
                nullable: true,
                collation: "utf8mb4_unicode_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CarWorkshops_CreatedById",
                table: "CarWorkshops",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_CarWorkshops_AspNetUsers_CreatedById",
                table: "CarWorkshops",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarWorkshops_AspNetUsers_CreatedById",
                table: "CarWorkshops");

            migrationBuilder.DropIndex(
                name: "IX_CarWorkshops_CreatedById",
                table: "CarWorkshops");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "CarWorkshops");

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
