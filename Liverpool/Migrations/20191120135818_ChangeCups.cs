using Microsoft.EntityFrameworkCore.Migrations;

namespace Liverpool.Migrations
{
    public partial class ChangeCups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundPhotoURL",
                table: "Cup",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Cup",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundPhotoURL",
                table: "Cup");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "Cup");
        }
    }
}
