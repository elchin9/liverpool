using Liverpool.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Liverpool.DAL
{
    public class DB_Liverpool : IdentityDbContext<AppUser>
    {
        public DB_Liverpool(DbContextOptions<DB_Liverpool> options) : base(options)
        {
        }
        public DbSet<CupType> CupType { get; set; }
        public DbSet<Cup> Cup { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<MailBox> MailBox { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<NewsPhotos> NewsPhotos { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<StadiumPhotos> StadiumPhotos { get; set; }
        public DbSet<Stadium> Stadium { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<FirstTeam> FirstTeam { get; set; }
        public DbSet<StaticData> StaticData { get; set; }
        public DbSet<VideoCategory> VideoCategory { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<BackgroundImages> BackgroundImages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
            //seeding Category table
            builder.Entity(typeof(Category)).HasData(
                new Category { Id = 1, Name = "Transfer" },
                new Category { Id = 2, Name = "Klub" }
            );

            //seeding Slider table
            builder.Entity(typeof(Slider)).HasData(
                new Slider { Id = 1, PhotoURL = "slider/liverpool6.jpg" },
                new Slider { Id = 2, PhotoURL = "slider/liverpool2.jpg" },
                new Slider { Id = 3, PhotoURL = "slider/liverpool3.jpg" }
            );

            //seeding Cup Type table
            builder.Entity(typeof(CupType)).HasData(
                new CupType { Id = 1, Name = "Çempionlar Liqası", PhotoURL = "champions2cup.png" },
                new CupType { Id = 2, Name = "Premier Liqa", PhotoURL = "premiercup.png" },
                new CupType { Id = 3, Name = "FA Kuboku", PhotoURL = "facup.png" },
                new CupType { Id = 4, Name = "Avropa Liqası", PhotoURL = "europecup.png" },
                new CupType { Id = 5, Name = "UEFA Super Kuboku", PhotoURL = "uefasupercup.png" },
                new CupType { Id = 6, Name = "Ölkə Kuboku", PhotoURL = "eflcup.png" },
                new CupType { Id = 7, Name = "Community Shield", PhotoURL = "communityshield.svg" },
                new CupType { Id = 8, Name = "FIFA Klublararası DÇ" , PhotoURL = "clubworldcup.png" }
            );

            //seeding Posiiton table
            builder.Entity(typeof(Position)).HasData(
                new Position { Id = 1, Name = "Baş Məşqçi" },
                new Position { Id = 2, Name = "Müdafiəçi" },
                new Position { Id = 3, Name = "Yarımmüdafiəçi" },
                new Position { Id = 4, Name = "Hücumçu" },
                new Position { Id = 5, Name = "İcarədə" }
            );

            //seeding Video Category table
            builder.Entity(typeof(VideoCategory)).HasData(
                new VideoCategory { Id = 1, Name = "Çempionlar Liqası" },
                new VideoCategory { Id = 2, Name = "Premier Liqa" },
                new VideoCategory { Id = 3, Name = "Ölkə Kuboku" },
                new VideoCategory { Id = 4, Name = "FA Kuboku" },
                new VideoCategory { Id = 5, Name = "Avropa Liqası" },
                new VideoCategory { Id = 6, Name = "UEFA Super Kuboku" },
                new VideoCategory { Id = 7, Name = "Community Shield" },
                new VideoCategory { Id = 8, Name = "FIFA DÇ" },
                new VideoCategory { Id = 9, Name = "Yoldaşlıq" }
            );

            //seeding History table
            builder.Entity(typeof(History)).HasData(
                new History { Id = 1, Info = "Liverpul futbol klubu 'Everton' və klub prezidenti, həmçinin Enfild stadionunda pay sahibi olan Con Houldinq arasında yaranmış münaqişə sonrası yaradılmışdır. Stadionda keçirdiyi 8 ildən sonra 1892-ci ildə 'Everton' Qudison Park stadionuna köçdü və Houldinq Liverpul adlı klubun əsasını qoydu. Beləliklə klub ev oyunlarını Enfild stadionunda keçirməyə başladı. Əsl adı Everton və Atletik Qraunds Ltd (qısaca Everton Atletik) olan klubu futbol assosiasiya Everton adlı klub kimi qəbul etməkdən imtina etməsindən sonra klub adını dəyişərək Liverpul etdi və 1892-ci ilin martında yaradılmasından 3 ay sonra futbol assosiasiyası tərəfindən rəsmi olaraq tanındı. Debüt mövsümündə klub Lankaşayr liqasını qazandı və 1893-94 mövsümündə ikinci divizyonda iştirak üçün vəsiqə qazandı. Klub mövsümü birinci pillədə tamamladıqdan sonra birinci divizyona yüksəldi ki, burada 1901 və 1906-cı ildə turniri birinci pillədə başa vurmağa müvəffəq oldu.Liverpu ilk dəfə İngiltərə Federasiya Kubokunun finalına 1914-cü ildə çıxmışdır ki, burada da onlar 'Börnli' klubuna 0-1 hesabı ilə məğlub olmuşdur. Ardıcıl olaraq isə klub 1922 və 1923-cü illərdə İngiltərə liqa çempionluğunu qazansada, 1946-47 mövsümünədək heç bir mükafat qazana bilməmişdir. Liverpul 1950-ci ildə ikinci dəfə çıxdığı İngiltərə Federasiya Kubokunun finalında bu dəfə 'Arsenal' 2-0 hesabı ilə məğlub oldu. Klub 1953–54 mövsümündə ikinci divizyona yuvarlandı. 1958-59 mövsümünün kubok matçında isə bu dəfə 'Uorçester' klubuna məğlub olduqdan sonra klubun məşqçi postunda dəyişiklik edilərək bu vəzifəyə Uilyam Bil Şenkli gətirildi. Kluba yeni gələn Uilyam Bil Şenkli dərhal 24 oyunçu ilə yollarını ayırdı və Enfilddə yerləşən ayaqqabı otağını dəyişərək buranı məşqçilik üçün işini görə biləcəyi bir otağa çevirdi. Şenkli və digərləri Co Faqan, Ruben Bennet və Bob Peysli klubda yenidən dəyişikliklər aparmağa başladılar.Klub 1962-ci iidə yenidən birinci divizyona geri qayıtdı və 17 ildən sonra 1964-cü ildə burada qalib oldu. 1965-ci ildə klub tarixində ilk dəfə İngiltərə Federasiya Kubokunu qazandı. Liverpul final görüşündə 'Lids' klubuna 2-1 hesabı ilə qalib gəlməklə kuboku başı üzərinə qaldırdı. Növbəti il, 1966-cı ildə klub birinci divizyonun qalibi oldu amma buna baxmayaraq UEFA Kuboklar Kuboku turnirinin finalında Almaniyanın 'Borussiya Dortmund' komandasına 2-1 hesabı ilə məğlub oldu. Finalda Liverpulun yeganə qoluna Rocer Hant imza atmışdır. Liverpul 1972-73 mövsümündə ölkə çempionluğunu, İngiltərə Federasiya Kubokunu qazanmaqla bərabər həmçinin UEFA Kubokunuda qazanmağı bacardı. UEFA Avropa Liqasının finalında onlar Almaniyanın 'Borussiya Münhenqladbax' klubuna iki oyunun yekun nəticəsində 3-2 hesabı ilə qalib gəldilər. Sonradan tezliklə Uilyam Bil Şenkli təqaüdə çıxdı və onu postunda Bob Peysli əvəz etdi. 1976-cı ildə Peyslinin ikinci məşqçilik dövründə Liverpul yenidən İngiltərə çempionluğunu və UEFA Kubokunu qazandı. UEFA Kubokunun finalında onlar Belçikanın 'Brügge' klubuna iki oyunun yekun nəticəsində 4-3 hesabı ilə qalib gəldilər. Növbəti mövsüm klub İngiltərə çempionluğunu qorudu və əlavə olaraq tarixində ilk dəfə UEFA Çempionlar Liqası turnirini qazandı. Finalda onlar 'Borussiya Münhenqladbax' klubuna 3-1 hesabı ilə qalib gəldilər. Amma İngiltərə Federasiya Kubokunun finalında onlar məğlub oldular. Liverpul 1978-ci ildə sahib olduğu UEFA Çempionlar Liqası titulunu qorumağı bacardı və 1979-cu ildə İngiltərədə liqa çempionluğu titulunu yenidən qazandı. Ümumilikdə Peyslinin klubda çalışdığı 9 il ərzində Liverpul 21 titul qazandı. Bunlara 3 dəfə UEFA Çempionlar Liqası kuboku, 1 dəfə UEFA Avropa Liqası, 6 dəfə ölkə çempionluğu və ardıcıl olaraq 3 dəfə İngiltərə Liqa Kuboku daxildir. Onun yeganə qazana bilmədiyi turnir isə İngiltərə Federasiya Kuboku olmuşdur." }
            );


            //seeding Stadium table
            builder.Entity(typeof(Stadium)).HasData(
                new Stadium { Id = 1,
                              Name = "Anfield",
                              Time = "1884",
                              Capacity = "54 074",
                              MainInfo = "İngiltərənin Liverpul şəhərində yerləşən futbol stadionu. UEFA-dan 4 ulduz almış stadionlardandır. Məşhur ingilis klubu 'Liverpul' bu stadiona ev sahibliyi etməkdədir. Stadion 54 074 nəfərlik yer tutumuna malikdir. Stadion haqqındakı ən maraqlı qeydlərdən biri, 'Liverpul' klubunun 'Enfild'i deyil də 'Enfild'in 'Liverpul'u inşa etmiş olmasıdır. 1884-cü ildə inşa edilən stadionu ilk 8 il 'Everton' futbol klubu işlədib. 1892-ci ildə 'Enfild' stadionunun sahibi Con Houlding ilə icarə haqqında münaqişə çıxınca 'Everton', 'Enfild' Stadionunu tərk etdi və 'Qudison Park'a köçdü. Əlində böyük bir boş stadionla qalan Con Houlding də Liverpul futbol klubunu qurdu. Stadionun rekord izləyici sayı 1952 ci ilin 2 fevralında, Wolverhampton klubu ilə maçta qeydə alınıb. Həmin oyunu 61 905 azarkeş izləyib." }
            );

            //seeding Stadium Photos table
            builder.Entity(typeof(StadiumPhotos)).HasData(
                new StadiumPhotos { Id = 1, PhotoURL = "stadium/anfield.jpg", StadiumId = 1 },
                new StadiumPhotos { Id = 2, PhotoURL = "stadium/anfield.jpg2", StadiumId = 1 },
                new StadiumPhotos { Id = 3, PhotoURL = "stadium/anfield.jpg3", StadiumId = 1 },
                new StadiumPhotos { Id = 4, PhotoURL = "stadium/anfield.jpg4", StadiumId = 1 },
                new StadiumPhotos { Id = 5, PhotoURL = "stadium/anfield.jpg5", StadiumId = 1 },
                new StadiumPhotos { Id = 6, PhotoURL = "stadium/anfield.jpg6", StadiumId = 1 },
                new StadiumPhotos { Id = 7, PhotoURL = "stadium/anfield.jpg7", StadiumId = 1 }
            );

            //seeding Gallery table
            builder.Entity(typeof(Gallery)).HasData(
                new Gallery { Id = 1, PhotoURL = "squad.jpg" },
                new Gallery { Id = 2, PhotoURL = "squad.jpg" }
            );

            //seeding Event table
            builder.Entity(typeof(Event)).HasData(
                new Event { Id = 1, Title = "Liverpool - Manchester City",
                            Place = "28 Mall", Time = new DateTime(12/09/19),
                            Clock = "19:00", Phone ="051 555 55 55",
                            Map = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24315.23772871157!2d49.85388954714356!3d40.37772197528239!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xd8897cf79ec36111!2s28%20Mall!5e0!3m2!1str!2s!4v1572944839076!5m2!1str!2s"

                }
            );
        }
    }
}
