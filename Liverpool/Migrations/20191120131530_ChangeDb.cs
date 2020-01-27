using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Liverpool.Migrations
{
    public partial class ChangeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundPhotoURL",
                table: "Player",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FirstTeam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirstTeam_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoURL",
                value: "champions2cup.png");

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoURL",
                value: "premiercup.png");

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoURL",
                value: "facup.png");

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoURL",
                value: "europecup.png");

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoURL",
                value: "uefasupercup.png");

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoURL",
                value: "eflcup.png");

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoURL",
                value: "communityshield.svg");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "Map",
                value: "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24315.23772871157!2d49.85388954714356!3d40.37772197528239!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xd8897cf79ec36111!2s28%20Mall!5e0!3m2!1str!2s!4v1572944839076!5m2!1str!2s");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoURL",
                value: "slider/liverpool6.jpg");

            migrationBuilder.UpdateData(
                table: "VideoCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "FIFA DÇ");

            migrationBuilder.CreateIndex(
                name: "IX_FirstTeam_PlayerId",
                table: "FirstTeam",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstTeam");

            migrationBuilder.DropColumn(
                name: "BackgroundPhotoURL",
                table: "Player");

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "CupType",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "Map",
                value: "<iframe src='https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24315.23772871157!2d49.85388954714356!3d40.37772197528239!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xd8897cf79ec36111!2s28%20Mall!5e0!3m2!1str!2s!4v1572944839076!5m2!1str!2s' width='600' height='450' frameborder='0' style='border:0;' allowfullscreen=''></iframe>");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoURL",
                value: "slider/liverpool1.jpg");

            migrationBuilder.UpdateData(
                table: "VideoCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "FIFA Klublararası DÇ");
        }
    }
}
