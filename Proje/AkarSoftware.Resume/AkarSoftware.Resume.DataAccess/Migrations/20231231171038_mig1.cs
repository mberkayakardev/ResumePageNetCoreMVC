using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkarSoftware.Resume.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutMes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutMes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BornDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CvPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePhotos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Badgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDateFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDateFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDateFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDateFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgressBarSkillses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProgressBarValue = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressBarSkillses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocailMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocailMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "ModifiedDate", "Name", "OrderNumber", "UrlPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(220), ".Net Core MVC, Asp.Net MVC, Flask, Django ile web uygulamaları geliştirebiliyorum", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(232), "Web Uygulamaları", 1, "/StaticFiles/website.png" },
                    { 2, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(234), "Winform, PyQt5, Tkinter, JFrame ile masaüstü uygulamalar geliştirebiliyorum.", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(235), "Masaüstü Uygulamalar", 2, "/StaticFiles/computer.png" },
                    { 3, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(236), "Restfull - Web Api Geliştirmesi Yapabiliyorum", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(237), "Web Servisler", 3, "/StaticFiles/api.png" },
                    { 4, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(238), "HTML, CSS, BOOSTRAP, JS, JQUERY, REACT ile ön yüz uygulamaları geliştirebiliyorum", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(238), "Front - End Geliştirme ", 4, "/StaticFiles/frontend.png" }
                });

            migrationBuilder.InsertData(
                table: "AboutMes",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(402), "<p><strong><strong><strong></strong></strong></strong></p><p><span style=\"letter-spacing: 0\">2021 yılında Düzce Üniversitesi Bilgisayar Mühendisliği bölümünden 3.03 ortalama mezun oldum. Genel olarak üniversite hayatım boyunca teorik ve uygulamalı olarak edinmiş olduğum bilgileri kurumsal firmalarda gerçekleştirmiş olduğum stajlar ve iş deneyimleri ile destekledim. Orta seviyede İngilizce bilgisine sahibim. Öğrenmeye ve çalışmaya açık bir insan olarak eğitim geçmişime ve kişisel&nbsp;</span><span style=\"letter-spacing: 0\">özelliklerime değer katabileceğim bir pozisyonda deneyim kazanmak ve süreçleri&nbsp;</span><span style=\"letter-spacing: 0\">gözlemlemek istiyorum.</span></p><ul><li><em>Çok Katmanlı Mimari</em> ile proje geliştirebiliyorum. (<strong>N-TIER ARCHITECTURE</strong>).</li><li><em>Django, Flask, ASP.NET Core W</em>eb frameworklerini kullanarak projeler geliştirebiliyorum.</li><li><em>MSSQL, MySQL</em>, <em>Oracle</em> ile veri tabanı yönetimi ve modellemesi yapabiliyorum.</li><li><em>Java, C#, Python</em> dillerinde projeler geliştirebiliyorum.&nbsp;</li><li><em>Devexpress, Windows Form, Pyqt5, Tkinter, Jframe</em> kullanarak masaüstü uygulamalar geliştirebiliyorum.</li><li><em>Windows Server 2012 R2</em> kullanım Orta Seviye <em>MacOS, Windows, Linux (Ubuntu)</em> Bilgisi.</li><li><em>Knime , Weka</em> gibi veri madenciliği araçlarını kullanabiliyorum ve <em>Sklearn, TensorFlow</em> kütüphanelerini kullanarak makine öğrenmesi, veri bilimi projeleri geliştirebiliyorum.</li><li><em>ODI</em> ve<em> SAP BODS</em> araçları kullanarak <em>ETL</em> süreçleri gerçekleştirebiliyorum.</li></ul><br><br><ul><li><strong>Github : https://github.com/mberkayakardev</strong></li><li><strong>Linkedin: https://www.linkedin.com/in/berkayakar/</strong></li></ul>", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "BornDate", "CreatedDate", "CvPath", "Email", "IsActive", "Location", "ModifiedDate", "Name", "Password", "PhoneNumber1", "PhoneNumber2", "Position", "ProfilePhotos", "Surname", "UserName" },
                values: new object[] { 1, new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(487), "/StaticFiles/BerkayAkarCV.pdf", "mberkayakar@outlook.com", true, "Bayrampaşa / İstanbul", new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(488), "Berkay", "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3", "+90 534 564 34 10", "+90 534 541 34 10", "Bilgisayar Mühendisi", "/StaticFiles/ProfilFoto.jpg", "AKAR", "mberkayakar" });

            migrationBuilder.InsertData(
                table: "Badgets",
                columns: new[] { "Id", "CreatedDate", "IsActive", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1265), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1267), ".Net Core" },
                    { 2, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1268), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1268), ".Net FrameWork" },
                    { 3, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1269), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1269), "C#" },
                    { 4, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1270), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1271), ".Net Core MVC" },
                    { 5, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1272), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1272), ".Net Framework MVC" },
                    { 6, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1273), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1273), ".Net Core Web Api" },
                    { 7, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1274), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1274), "RestFull " },
                    { 8, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1275), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1275), "Windows Forms " },
                    { 9, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1276), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1277), "Devexpress" },
                    { 10, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1278), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1278), "Ado.Net" },
                    { 11, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1279), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1279), "Dapper" },
                    { 12, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1280), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1280), "Dapper.Contrib" },
                    { 13, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1281), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1281), "Entity Framework" },
                    { 14, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1282), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1283), "Sql Server" },
                    { 15, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1284), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1284), "T-SQL" },
                    { 16, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1285), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1285), "PL-SQL" },
                    { 17, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1286), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1286), "Oracle" },
                    { 18, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1287), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1288), "ODI" },
                    { 19, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1288), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1289), "SAP BODS" },
                    { 20, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1290), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1290), "AOP" },
                    { 21, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1291), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1291), "JavaScript" },
                    { 22, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1292), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1292), "HTML" },
                    { 23, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1293), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1294), "React" },
                    { 24, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1295), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1295), "CSS" },
                    { 25, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1296), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1296), "BOOSTRAP" },
                    { 26, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1297), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1298), "N-Tier Architecture" },
                    { 27, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1298), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1299), "UnitOfWork" },
                    { 28, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1300), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1300), "Repository Desing Pattern" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreatedDate", "EducationDescription", "EndDate", "EndDateFormat", "ImagePath", "IsActive", "ModifiedDate", "Name", "StartDate", "StartDateFormat", "SubName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1499), "<p>Lisans &ouml;ğrenimim burada ger&ccedil;ekleşti.</p>\r\n<p><strong>Bilgisayar M&uuml;hendisliği</strong> B&ouml;l&uuml;m&uuml; i&ccedil;in <strong>Ortalama : 3.03</strong></p>", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/duzceuni.png", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1503), "Düzce Üniversitesi", new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Bilgisayar Mühendisliği" },
                    { 2, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1505), "<p>İŞ-KUR kapsamında Nitelikli Bilişim Uzmanlığı eğitimi alındı.</p>", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/BilisimEgitimMerkezi.png", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1506), "Bilişim Eğitim Merkezi - IS-KUR", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Nitelikli Bilişim Uzmanlığı" },
                    { 3, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1507), "<p><strong>.Net Core</strong> i&ccedil;in <strong>FullStack</strong> Development &uuml;zerine bir eğitim alındı.</p>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/my,.jpg", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1509), "Bilişim Eğitim Merkezi - IS-KUR", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Nitelikli Bilişim Uzmanlığı" }
                });

            migrationBuilder.InsertData(
                table: "Experiances",
                columns: new[] { "Id", "CreatedDate", "EducationDescription", "EndDate", "EndDateFormat", "ImagePath", "IsActive", "ModifiedDate", "Name", "StartDate", "StartDateFormat", "SubName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1602), "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Horoz ERP projesi kapsamında N-Tier Achitechture Devexpress, Windows Form, Oracle ve şirket i&ccedil;i geliştirilmiş olan birtakım teknolojiler kullanılarak ERP projesi geliştirildi.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Honest &uuml;zerinden kullanıcılara destek verildi.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Kurum ihtiya&ccedil;ları doğrultusunda yazılım ekibi ile beraber yazılım geliştirme s&uuml;re&ccedil;lerinde yer alındı.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Dağıtım alan dışı, Rota optimizasyonu, Otomatik eskalasyon, E-İhracat projelerinde rol alındı.</li>\r\n</ul>", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/hl.png", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1608), "Horoz Lojistik Kargo Hizmetleri A.Ş.", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Yazılım Uzmanı" },
                    { 2, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1610), "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;\">Firma b&uuml;nyesinde Yazılım M&uuml;hendisi &uuml;nvanı ile .Net Core Web Api, Sql Server teknolojisini kullanarak backend projeleri geliştirdim.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Turkish Cargo Ara&ccedil; Backend ve Powerşarj projelerinde yer alındı. Geliştirme &ccedil;alışmalarında bulunuldu.</li>\r\n</ul>", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/wr.png", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1611), "White Rose", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Yazılım Mühendisi" },
                    { 3, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1613), "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;\">SAP ABAP &uuml;zerinde eğitimler alındı.&nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">ABAP &uuml;zerinde programlama, geliştirme ve mod&uuml;llerin kullanımı &ouml;ğrenildi.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">ODI ve BODS ile ETL s&uuml;re&ccedil;leri ger&ccedil;ekleştirildi.&nbsp;</li>\r\n</ul>", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/teampro.jpg", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1614), "TeamPro Danışmanlık Ve Bilişim Hizmetleri", new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Stajer" },
                    { 4, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1615), "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;\">Firma b&uuml;nyesinde u&ccedil;tan uca veri bilimi s&uuml;re&ccedil;leri i&ccedil;erisinde bulunuldu.&nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Tensorflow, Sklearn, Matplotlib, Seaborn, Plotly k&uuml;t&uuml;phanelerini kullanarak veri bilimi projeleri ve veri analizleri ger&ccedil;ekleştirildi.&nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Knime, Weka ile u&ccedil;tan uca veri bilimi ara&ccedil;larını kullanarak projeler ger&ccedil;ekleştirildi. &Ccedil;ıkan modeller analiz edildi.&nbsp; &nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Geliştirilen modelleri sekt&ouml;rde bilindik olan ara&ccedil;lar ile karşılaştırarak istatiksel olarak a&ccedil;ıklayacak makaleler yazdım.</li>\r\n</ul>", new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/Optiwisdom.jpg", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1616), "Optiwisdom", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Stajer" },
                    { 5, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1617), "<p style=\"box-sizing: border-box; margin: 0px 0px 1rem; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">&bull; Nesne y&ouml;nelimli programlama y&ouml;ntemleri ile oluşturulmuş bir iş s&uuml;recinin katmanlı mimari ile geliştirilmesini g&ouml;zlemledim.</p>\r\n<p style=\"box-sizing: border-box; margin: 0px 0px 1rem; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">&bull; Daha &ouml;ncesinde sadece teorik bilgi sahibi olduğum sunucu sistemlerini ve sunucu elemanlarını yakından g&ouml;zlemledim, oluşan hasarlarda hasar tespiti yaptım ve m&uuml;mk&uuml;nse hasarın tamiratını ger&ccedil;ekleştirdim.</p>\r\n<p style=\"box-sizing: border-box; margin: 0px 0px 1rem; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">&bull;Windows Server 2012 R2 işletim sisteminde Active Directory, Group policy gibi yapılar ile domaine bağlı makinelerin dosya erişimlerinde yetkilendirmeler yaptım, Domain'e bağlı makinelere sanal bir ortam &uuml;zerinde yetkiler verdim.</p>", new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "/StaticFiles/diler.jpg", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1619), "Diler Holding", new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MM/yyyy", "Stajer" }
                });

            migrationBuilder.InsertData(
                table: "ProgressBarSkillses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "ModifiedDate", "ProgressBarValue", "SkillName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1708), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1709), 75, ".Net Core" },
                    { 2, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1710), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1711), 65, ".Net Framework" },
                    { 3, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1712), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1712), 70, ".Net Core MVC" },
                    { 4, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1713), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1714), 70, ".Net Core Web Api" },
                    { 5, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1714), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1715), 75, "HTML" },
                    { 6, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1716), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1716), 50, "CSS" },
                    { 7, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1717), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1718), 70, "Boostrap" },
                    { 8, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1718), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1719), 55, "JQuery" },
                    { 9, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1720), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1720), 40, "JavaScript" },
                    { 10, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1721), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1721), 70, "C#" },
                    { 11, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1722), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1723), 60, "Python" },
                    { 12, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1723), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1724), 50, "Django" },
                    { 13, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1725), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1725), 25, "Flask" },
                    { 14, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1726), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1726), 70, "Sql Server - (TSQL)" },
                    { 15, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1727), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1728), 75, "Oracle - (PL/SQL)" },
                    { 16, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1729), true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1729), 60, "Knime" }
                });

            migrationBuilder.InsertData(
                table: "SocailMedias",
                columns: new[] { "Id", "CreatedDate", "Description", "IconName", "IsActive", "ModifiedDate", "SocialMediaName", "SocialMediaUrl", "SocialMediaUserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1817), "Linkedin Profilim", "font-icon icon-linkedin2", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1818), "Linkedin", "https://www.linkedin.com/in/berkayakar/", "in/berkayakar" },
                    { 2, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1820), "Github Profilim", "font-icon icon-github", true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1821), "Linkedin", "https://github.com/mberkayakardev", "in/berkayakar" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "CreatedDate", "Height", "IsActive", "ModifiedDate", "Name", "UrlPath", "Width" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1903), 50, true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1905), ".Net Core", "/StaticFiles/dotnetcore.svg", 50 },
                    { 2, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1906), 50, true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1907), ".Net Framework", "/StaticFiles/dotnetframework.svg", 50 },
                    { 3, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1908), 50, true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1909), "C#", "/StaticFiles/csharp.svg", 50 },
                    { 5, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1910), 50, true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1910), "Python", "/StaticFiles/python.svg", 50 },
                    { 6, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1911), 50, true, new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1912), "Django", "/StaticFiles/django.svg", 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "AboutMes");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Badgets");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiances");

            migrationBuilder.DropTable(
                name: "ProgressBarSkillses");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "SocailMedias");

            migrationBuilder.DropTable(
                name: "Technologies");
        }
    }
}
