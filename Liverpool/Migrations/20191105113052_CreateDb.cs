using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Liverpool.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    PhotoURL = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HistoryPhotoURL = table.Column<string>(nullable: true),
                    SquadPhotoURL = table.Column<string>(nullable: true),
                    CupPhotoURL = table.Column<string>(nullable: true),
                    StadiumPhotoURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CupType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoURL = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Place = table.Column<string>(nullable: false),
                    Map = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Clock = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoURL = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Info = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailBox",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    TextBody = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoURL = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stadium",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    MainInfo = table.Column<string>(nullable: false),
                    Time = table.Column<string>(maxLength: 10, nullable: false),
                    Capacity = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadium", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaticData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacebookLink = table.Column<string>(maxLength: 100, nullable: false),
                    InstagramLink = table.Column<string>(maxLength: 100, nullable: false),
                    TwitterLink = table.Column<string>(maxLength: 100, nullable: false),
                    YoutubeLink = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    MainInfo = table.Column<string>(nullable: false),
                    ShortInfo = table.Column<string>(maxLength: 200, nullable: false),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Place = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    CupTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cup_CupType_CupTypeId",
                        column: x => x.CupTypeId,
                        principalTable: "CupType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoURL = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: false),
                    Birthday = table.Column<string>(maxLength: 100, nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    Info = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StadiumPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoURL = table.Column<string>(maxLength: 100, nullable: false),
                    StadiumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StadiumPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StadiumPhotos_Stadium_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadium",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    PhotoURL = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    MainInfo = table.Column<string>(nullable: false),
                    VideoLink = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_VideoCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "VideoCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoURL = table.Column<string>(maxLength: 100, nullable: false),
                    NewsId = table.Column<int>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsPhotos_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Transfer" },
                    { 2, "Klub" }
                });

            migrationBuilder.InsertData(
                table: "CupType",
                columns: new[] { "Id", "Name", "PhotoURL" },
                values: new object[,]
                {
                    { 1, "Çempionlar Liqası", null },
                    { 2, "Premier Liqa", null },
                    { 3, "FA Kuboku", null },
                    { 4, "Avropa Liqası", null },
                    { 5, "UEFA Super Kuboku", null },
                    { 6, "Ölkə Kuboku", null },
                    { 7, "Community Shield", null }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Clock", "Map", "Phone", "Place", "Time", "Title" },
                values: new object[] { 1, "19:00", "<iframe src='https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24315.23772871157!2d49.85388954714356!3d40.37772197528239!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xd8897cf79ec36111!2s28%20Mall!5e0!3m2!1str!2s!4v1572944839076!5m2!1str!2s' width='600' height='450' frameborder='0' style='border:0;' allowfullscreen=''></iframe>", "051 555 55 55", "28 Mall", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liverpool - Manchester City" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "PhotoURL" },
                values: new object[,]
                {
                    { 1, "squad.jpg" },
                    { 2, "squad.jpg" }
                });

            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "Id", "Info" },
                values: new object[] { 1, "Liverpul futbol klubu 'Everton' və klub prezidenti, həmçinin Enfild stadionunda pay sahibi olan Con Houldinq arasında yaranmış münaqişə sonrası yaradılmışdır. Stadionda keçirdiyi 8 ildən sonra 1892-ci ildə 'Everton' Qudison Park stadionuna köçdü və Houldinq Liverpul adlı klubun əsasını qoydu. Beləliklə klub ev oyunlarını Enfild stadionunda keçirməyə başladı. Əsl adı Everton və Atletik Qraunds Ltd (qısaca Everton Atletik) olan klubu futbol assosiasiya Everton adlı klub kimi qəbul etməkdən imtina etməsindən sonra klub adını dəyişərək Liverpul etdi və 1892-ci ilin martında yaradılmasından 3 ay sonra futbol assosiasiyası tərəfindən rəsmi olaraq tanındı. Debüt mövsümündə klub Lankaşayr liqasını qazandı və 1893-94 mövsümündə ikinci divizyonda iştirak üçün vəsiqə qazandı. Klub mövsümü birinci pillədə tamamladıqdan sonra birinci divizyona yüksəldi ki, burada 1901 və 1906-cı ildə turniri birinci pillədə başa vurmağa müvəffəq oldu.Liverpu ilk dəfə İngiltərə Federasiya Kubokunun finalına 1914-cü ildə çıxmışdır ki, burada da onlar 'Börnli' klubuna 0-1 hesabı ilə məğlub olmuşdur. Ardıcıl olaraq isə klub 1922 və 1923-cü illərdə İngiltərə liqa çempionluğunu qazansada, 1946-47 mövsümünədək heç bir mükafat qazana bilməmişdir. Liverpul 1950-ci ildə ikinci dəfə çıxdığı İngiltərə Federasiya Kubokunun finalında bu dəfə 'Arsenal' 2-0 hesabı ilə məğlub oldu. Klub 1953–54 mövsümündə ikinci divizyona yuvarlandı. 1958-59 mövsümünün kubok matçında isə bu dəfə 'Uorçester' klubuna məğlub olduqdan sonra klubun məşqçi postunda dəyişiklik edilərək bu vəzifəyə Uilyam Bil Şenkli gətirildi. Kluba yeni gələn Uilyam Bil Şenkli dərhal 24 oyunçu ilə yollarını ayırdı və Enfilddə yerləşən ayaqqabı otağını dəyişərək buranı məşqçilik üçün işini görə biləcəyi bir otağa çevirdi. Şenkli və digərləri Co Faqan, Ruben Bennet və Bob Peysli klubda yenidən dəyişikliklər aparmağa başladılar.Klub 1962-ci iidə yenidən birinci divizyona geri qayıtdı və 17 ildən sonra 1964-cü ildə burada qalib oldu. 1965-ci ildə klub tarixində ilk dəfə İngiltərə Federasiya Kubokunu qazandı. Liverpul final görüşündə 'Lids' klubuna 2-1 hesabı ilə qalib gəlməklə kuboku başı üzərinə qaldırdı. Növbəti il, 1966-cı ildə klub birinci divizyonun qalibi oldu amma buna baxmayaraq UEFA Kuboklar Kuboku turnirinin finalında Almaniyanın 'Borussiya Dortmund' komandasına 2-1 hesabı ilə məğlub oldu. Finalda Liverpulun yeganə qoluna Rocer Hant imza atmışdır. Liverpul 1972-73 mövsümündə ölkə çempionluğunu, İngiltərə Federasiya Kubokunu qazanmaqla bərabər həmçinin UEFA Kubokunuda qazanmağı bacardı. UEFA Avropa Liqasının finalında onlar Almaniyanın 'Borussiya Münhenqladbax' klubuna iki oyunun yekun nəticəsində 3-2 hesabı ilə qalib gəldilər. Sonradan tezliklə Uilyam Bil Şenkli təqaüdə çıxdı və onu postunda Bob Peysli əvəz etdi. 1976-cı ildə Peyslinin ikinci məşqçilik dövründə Liverpul yenidən İngiltərə çempionluğunu və UEFA Kubokunu qazandı. UEFA Kubokunun finalında onlar Belçikanın 'Brügge' klubuna iki oyunun yekun nəticəsində 4-3 hesabı ilə qalib gəldilər. Növbəti mövsüm klub İngiltərə çempionluğunu qorudu və əlavə olaraq tarixində ilk dəfə UEFA Çempionlar Liqası turnirini qazandı. Finalda onlar 'Borussiya Münhenqladbax' klubuna 3-1 hesabı ilə qalib gəldilər. Amma İngiltərə Federasiya Kubokunun finalında onlar məğlub oldular. Liverpul 1978-ci ildə sahib olduğu UEFA Çempionlar Liqası titulunu qorumağı bacardı və 1979-cu ildə İngiltərədə liqa çempionluğu titulunu yenidən qazandı. Ümumilikdə Peyslinin klubda çalışdığı 9 il ərzində Liverpul 21 titul qazandı. Bunlara 3 dəfə UEFA Çempionlar Liqası kuboku, 1 dəfə UEFA Avropa Liqası, 6 dəfə ölkə çempionluğu və ardıcıl olaraq 3 dəfə İngiltərə Liqa Kuboku daxildir. Onun yeganə qazana bilmədiyi turnir isə İngiltərə Federasiya Kuboku olmuşdur." });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "İcarədə" },
                    { 4, "Hücumçu" },
                    { 3, "Yarımmüdafiəçi" },
                    { 2, "Müdafiəçi" },
                    { 1, "Baş Məşqçi" }
                });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "Id", "PhotoURL" },
                values: new object[,]
                {
                    { 1, "slider/liverpool1.jpg" },
                    { 2, "slider/liverpool2.jpg" },
                    { 3, "slider/liverpool3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Stadium",
                columns: new[] { "Id", "Capacity", "MainInfo", "Name", "Time" },
                values: new object[] { 1, "54 074", "İngiltərənin Liverpul şəhərində yerləşən futbol stadionu. UEFA-dan 4 ulduz almış stadionlardandır. Məşhur ingilis klubu 'Liverpul' bu stadiona ev sahibliyi etməkdədir. Stadion 54 074 nəfərlik yer tutumuna malikdir. Stadion haqqındakı ən maraqlı qeydlərdən biri, 'Liverpul' klubunun 'Enfild'i deyil də 'Enfild'in 'Liverpul'u inşa etmiş olmasıdır. 1884-cü ildə inşa edilən stadionu ilk 8 il 'Everton' futbol klubu işlədib. 1892-ci ildə 'Enfild' stadionunun sahibi Con Houlding ilə icarə haqqında münaqişə çıxınca 'Everton', 'Enfild' Stadionunu tərk etdi və 'Qudison Park'a köçdü. Əlində böyük bir boş stadionla qalan Con Houlding də Liverpul futbol klubunu qurdu. Stadionun rekord izləyici sayı 1952 ci ilin 2 fevralında, Wolverhampton klubu ilə maçta qeydə alınıb. Həmin oyunu 61 905 azarkeş izləyib.", "Anfield", "1884" });

            migrationBuilder.InsertData(
                table: "VideoCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Çempionlar Liqası" },
                    { 2, "Premier Liqa" },
                    { 3, "Ölkə Kuboku" },
                    { 4, "FA Kuboku" },
                    { 5, "Avropa Liqası" },
                    { 6, "UEFA Super Kuboku" },
                    { 7, "Community Shield" },
                    { 8, "FIFA Klublararası DÇ" },
                    { 9, "Yoldaşlıq" }
                });

            migrationBuilder.InsertData(
                table: "StadiumPhotos",
                columns: new[] { "Id", "PhotoURL", "StadiumId" },
                values: new object[,]
                {
                    { 1, "stadium/anfield.jpg", 1 },
                    { 2, "stadium/anfield.jpg2", 1 },
                    { 3, "stadium/anfield.jpg3", 1 },
                    { 4, "stadium/anfield.jpg4", 1 },
                    { 5, "stadium/anfield.jpg5", 1 },
                    { 6, "stadium/anfield.jpg6", 1 },
                    { 7, "stadium/anfield.jpg7", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cup_CupTypeId",
                table: "Cup",
                column: "CupTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsPhotos_NewsId",
                table: "NewsPhotos",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PositionId",
                table: "Player",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_StadiumPhotos_StadiumId",
                table: "StadiumPhotos",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_CategoryId",
                table: "Video",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BackgroundImages");

            migrationBuilder.DropTable(
                name: "Cup");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "MailBox");

            migrationBuilder.DropTable(
                name: "NewsPhotos");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "StadiumPhotos");

            migrationBuilder.DropTable(
                name: "StaticData");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CupType");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Stadium");

            migrationBuilder.DropTable(
                name: "VideoCategory");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
