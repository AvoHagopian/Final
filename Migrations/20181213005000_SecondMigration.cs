using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GodName",
                table: "Hero",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "God",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "GodName",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "God");
        }
    }
}
