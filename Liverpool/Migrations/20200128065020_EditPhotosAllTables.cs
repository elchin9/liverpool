using Microsoft.EntityFrameworkCore.Migrations;

namespace Liverpool.Migrations
{
    public partial class EditPhotosAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "StadiumPhotos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "NewsPhotos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "Gallery",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "StadiumPhotos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "NewsPhotos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoURL",
                table: "Gallery",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
