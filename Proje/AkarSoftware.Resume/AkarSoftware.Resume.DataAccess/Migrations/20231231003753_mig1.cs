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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "ProgressBarSkilssMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillOrder = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressBarSkilssMasters", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "ProgressBarSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgressBarValue = table.Column<int>(type: "int", nullable: false),
                    ProgressBarSkilssMasterId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressBarSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressBarSkills_ProgressBarSkilssMasters_ProgressBarSkilssMasterId",
                        column: x => x.ProgressBarSkilssMasterId,
                        principalTable: "ProgressBarSkilssMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "ModifiedDate", "Name", "OrderNumber", "UrlPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4307), ".Net Core MVC, Asp.Net MVC, Flask, Django ile web uygulamaları geliştirebiliyorum", true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4320), "Web Uygulamaları", 1, "/StaticFiles/website.png" },
                    { 2, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4323), "Winform, PyQt5, Tkinter, JFrame ile masaüstü uygulamalar geliştirebiliyorum.", true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4324), "Masaüstü Uygulamalar", 2, "/StaticFiles/computer.png" },
                    { 3, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4325), "Restfull - Web Api Geliştirmesi Yapabiliyorum", true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4326), "Web Servisler", 3, "/StaticFiles/api.png" },
                    { 4, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4327), "HTML, CSS, BOOSTRAP, JS, JQUERY, REACT ile ön yüz uygulamaları geliştirebiliyorum", true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4328), "Front - End Geliştirme ", 4, "/StaticFiles/frontend.png" }
                });

            migrationBuilder.InsertData(
                table: "AboutMes",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4534), "<p><strong><strong><strong></strong></strong></strong></p><p><span style=\"letter-spacing: 0\">2021 yılında Düzce Üniversitesi Bilgisayar Mühendisliği bölümünden 3.03 ortalama mezun oldum. Genel olarak üniversite hayatım boyunca teorik ve uygulamalı olarak edinmiş olduğum bilgileri kurumsal firmalarda gerçekleştirmiş olduğum stajlar ve iş deneyimleri ile destekledim. Orta seviyede İngilizce bilgisine sahibim. Öğrenmeye ve çalışmaya açık bir insan olarak eğitim geçmişime ve kişisel&nbsp;</span><span style=\"letter-spacing: 0\">özelliklerime değer katabileceğim bir pozisyonda deneyim kazanmak ve süreçleri&nbsp;</span><span style=\"letter-spacing: 0\">gözlemlemek istiyorum.</span></p><ul><li><em>Çok Katmanlı Mimari</em> ile proje geliştirebiliyorum. (<strong>N-TIER ARCHITECTURE</strong>).</li><li><em>Django, Flask, ASP.NET Core W</em>eb frameworklerini kullanarak projeler geliştirebiliyorum.</li><li><em>MSSQL, MySQL</em>, <em>Oracle</em> ile veri tabanı yönetimi ve modellemesi yapabiliyorum.</li><li><em>Java, C#, Python</em> dillerinde projeler geliştirebiliyorum.&nbsp;</li><li><em>Devexpress, Windows Form, Pyqt5, Tkinter, Jframe</em> kullanarak masaüstü uygulamalar geliştirebiliyorum.</li><li><em>Windows Server 2012 R2</em> kullanım Orta Seviye <em>MacOS, Windows, Linux (Ubuntu)</em> Bilgisi.</li><li><em>Knime , Weka</em> gibi veri madenciliği araçlarını kullanabiliyorum ve <em>Sklearn, TensorFlow</em> kütüphanelerini kullanarak makine öğrenmesi, veri bilimi projeleri geliştirebiliyorum.</li><li><em>ODI</em> ve<em> SAP BODS</em> araçları kullanarak <em>ETL</em> süreçleri gerçekleştirebiliyorum.</li></ul><br><br><ul><li><strong>Github : https://github.com/mberkayakardev</strong></li><li><strong>Linkedin: https://www.linkedin.com/in/berkayakar/</strong></li></ul>", true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "BornDate", "CreatedDate", "CvPath", "Email", "IsActive", "Location", "ModifiedDate", "Name", "Password", "PhoneNumber1", "PhoneNumber2", "Position", "ProfilePhotos", "Surname", "UserName" },
                values: new object[] { 1, new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4616), "/StaticFiles/BerkayAkarCV.pdf", "mberkayakar@outlook.com", true, "Bayrampaşa / İstanbul", new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(4617), "Berkay", "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3", "+90 534 564 34 10", "+90 534 541 34 10", "Bilgisayar Mühendisi", "/StaticFiles/ProfilFoto.jpg", "AKAR", "mberkayakar" });

            migrationBuilder.InsertData(
                table: "SocailMedias",
                columns: new[] { "Id", "CreatedDate", "Description", "IconName", "IsActive", "ModifiedDate", "SocialMediaName", "SocialMediaUrl", "SocialMediaUserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5378), "Linkedin Profilim", "font-icon icon-linkedin2", true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5379), "Linkedin", "https://www.linkedin.com/in/berkayakar/", "in/berkayakar" },
                    { 2, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5381), "Github Profilim", "font-icon icon-github", true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5381), "Linkedin", "https://github.com/mberkayakardev", "in/berkayakar" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "CreatedDate", "Height", "IsActive", "ModifiedDate", "Name", "UrlPath", "Width" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5464), 50, true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5465), ".Net Core", "/StaticFiles/dotnetcore.svg", 50 },
                    { 2, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5467), 50, true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5467), ".Net Framework", "/StaticFiles/dotnetframework.svg", 50 },
                    { 3, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5469), 50, true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5469), "C#", "/StaticFiles/csharp.svg", 50 },
                    { 5, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5470), 50, true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5471), "Python", "/StaticFiles/python.svg", 50 },
                    { 6, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5472), 50, true, new DateTime(2023, 12, 31, 3, 37, 53, 613, DateTimeKind.Local).AddTicks(5472), "Django", "/StaticFiles/django.svg", 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgressBarSkills_ProgressBarSkilssMasterId",
                table: "ProgressBarSkills",
                column: "ProgressBarSkilssMasterId");
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
                name: "ProgressBarSkills");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "SocailMedias");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "ProgressBarSkilssMasters");
        }
    }
}
