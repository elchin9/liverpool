using Microsoft.EntityFrameworkCore.Migrations;

namespace Liverpool.Migrations
{
    public partial class ChangeSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "Slider",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "CupType",
                columns: new[] { "Id", "Name", "PhotoURL" },
                values: new object[] { 8, "FIFA Klublararası DÇ", "clubworldcup.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "Slider",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
