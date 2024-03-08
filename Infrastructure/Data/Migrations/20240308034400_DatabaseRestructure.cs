using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseRestructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NameOfChildrens_FamilyBackgrounds_FamilyBackgroundId",
                table: "NameOfChildrens");

            migrationBuilder.DropIndex(
                name: "IX_NameOfChildrens_FamilyBackgroundId",
                table: "NameOfChildrens");

            migrationBuilder.DropColumn(
                name: "NonAcademicDestinction",
                table: "OtherInformations");

            migrationBuilder.DropColumn(
                name: "SpecialSkills",
                table: "OtherInformations");

            migrationBuilder.DropColumn(
                name: "FamilyBackgroundId",
                table: "NameOfChildrens");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "AttendanceSetups",
                newName: "CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "NonAcademicDestinctionId",
                table: "OtherInformations",
                type: "INTEGER",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialSkillsId",
                table: "OtherInformations",
                type: "INTEGER",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "LearningAndDevelopments",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EndDate",
                table: "LearningAndDevelopments",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ContractStart",
                table: "Employees",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ContractEnd",
                table: "Employees",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "YearGraduated",
                table: "EducationalBackgrounds",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitsEarned",
                table: "EducationalBackgrounds",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "PeriodStart",
                table: "EducationalBackgrounds",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "PeriodEnd",
                table: "EducationalBackgrounds",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfExamination",
                table: "CivilServiceEligibilities",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Campuses",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AttendanceSetupCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceSetupCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonAcademicDestinction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Desctinction = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonAcademicDestinction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Skills = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialSkills", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OtherInformations_NonAcademicDestinctionId",
                table: "OtherInformations",
                column: "NonAcademicDestinctionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherInformations_SpecialSkillsId",
                table: "OtherInformations",
                column: "SpecialSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceSetups_CategoryId",
                table: "AttendanceSetups",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceSetups_AttendanceSetupCategory_CategoryId",
                table: "AttendanceSetups",
                column: "CategoryId",
                principalTable: "AttendanceSetupCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherInformations_NonAcademicDestinction_NonAcademicDestinctionId",
                table: "OtherInformations",
                column: "NonAcademicDestinctionId",
                principalTable: "NonAcademicDestinction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherInformations_SpecialSkills_SpecialSkillsId",
                table: "OtherInformations",
                column: "SpecialSkillsId",
                principalTable: "SpecialSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceSetups_AttendanceSetupCategory_CategoryId",
                table: "AttendanceSetups");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherInformations_NonAcademicDestinction_NonAcademicDestinctionId",
                table: "OtherInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherInformations_SpecialSkills_SpecialSkillsId",
                table: "OtherInformations");

            migrationBuilder.DropTable(
                name: "AttendanceSetupCategory");

            migrationBuilder.DropTable(
                name: "NonAcademicDestinction");

            migrationBuilder.DropTable(
                name: "SpecialSkills");

            migrationBuilder.DropIndex(
                name: "IX_OtherInformations_NonAcademicDestinctionId",
                table: "OtherInformations");

            migrationBuilder.DropIndex(
                name: "IX_OtherInformations_SpecialSkillsId",
                table: "OtherInformations");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceSetups_CategoryId",
                table: "AttendanceSetups");

            migrationBuilder.DropColumn(
                name: "NonAcademicDestinctionId",
                table: "OtherInformations");

            migrationBuilder.DropColumn(
                name: "SpecialSkillsId",
                table: "OtherInformations");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Campuses");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "AttendanceSetups",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "NonAcademicDestinction",
                table: "OtherInformations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialSkills",
                table: "OtherInformations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyBackgroundId",
                table: "NameOfChildrens",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "LearningAndDevelopments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "LearningAndDevelopments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ContractStart",
                table: "Employees",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ContractEnd",
                table: "Employees",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "YearGraduated",
                table: "EducationalBackgrounds",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "UnitsEarned",
                table: "EducationalBackgrounds",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PeriodStart",
                table: "EducationalBackgrounds",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PeriodEnd",
                table: "EducationalBackgrounds",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfExamination",
                table: "CivilServiceEligibilities",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_NameOfChildrens_FamilyBackgroundId",
                table: "NameOfChildrens",
                column: "FamilyBackgroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_NameOfChildrens_FamilyBackgrounds_FamilyBackgroundId",
                table: "NameOfChildrens",
                column: "FamilyBackgroundId",
                principalTable: "FamilyBackgrounds",
                principalColumn: "Id");
        }
    }
}
