using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkarSoftware.Resume.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class projectclassess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectCreateDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProjectImageURL",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6368), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6372), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "AboutMes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6521), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6599), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7378), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7381), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7382), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7383), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7386), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7387), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7390), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7391), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7395), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7396), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7397), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7398), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7402), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7403), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7406), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7412), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7596), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7604), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7606), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7608), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7697), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7699), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7702), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7703), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7706), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7712), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7713), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7756), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "SocailMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7841), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "SocailMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7934), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7936), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7937), new DateTime(2024, 1, 1, 15, 49, 19, 674, DateTimeKind.Local).AddTicks(7938) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectCreateDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectImageURL",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Projects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(220), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(234), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(236), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "AboutMes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1265), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1268), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1270), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1272), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1273), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1274), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1275), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1276), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1278), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1280), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1281), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1282), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1284), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1285), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1286), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1287), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1288), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1290), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1291), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1292), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1293), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1295), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1296), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1298), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Badgets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1499), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1505), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1507), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1610), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1615), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Experiances",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1708), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1710), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1712), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1713), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1714), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1717), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1720), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1723), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1725), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1726), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1727), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "ProgressBarSkillses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1729), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "SocailMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "SocailMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1903), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1906), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1908), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 12, 31, 20, 10, 38, 862, DateTimeKind.Local).AddTicks(1912) });
        }
    }
}
