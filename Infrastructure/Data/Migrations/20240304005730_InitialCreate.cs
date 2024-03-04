using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceSetups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeIn = table.Column<string>(type: "TEXT", nullable: true),
                    TimeOut = table.Column<string>(type: "TEXT", nullable: true),
                    GracePeriod = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceSetups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveSetups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Credits = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveSetups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumber = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    PositionId = table.Column<int>(type: "INTEGER", nullable: false),
                    ContractStart = table.Column<string>(type: "TEXT", nullable: true),
                    ContractEnd = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeIn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeInRemarks = table.Column<string>(type: "TEXT", nullable: true),
                    TimeOut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeOutRemarks = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CivilServiceEligibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Eligibility = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<decimal>(type: "TEXT", nullable: false),
                    DateOfExamination = table.Column<string>(type: "TEXT", nullable: true),
                    PlaceOfExamination = table.Column<string>(type: "TEXT", nullable: true),
                    LicenseNumber = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfValidity = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivilServiceEligibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CivilServiceEligibilities_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalBackgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    NameOfSchool = table.Column<string>(type: "TEXT", nullable: true),
                    Course = table.Column<string>(type: "TEXT", nullable: true),
                    PeriodStart = table.Column<string>(type: "TEXT", nullable: true),
                    PeriodEnd = table.Column<string>(type: "TEXT", nullable: true),
                    UnitsEarned = table.Column<string>(type: "TEXT", nullable: true),
                    YearGraduated = table.Column<string>(type: "TEXT", nullable: true),
                    AcademicHonors = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalBackgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalBackgrounds_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyBackgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    SpouseSurname = table.Column<string>(type: "TEXT", nullable: true),
                    SpouseFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    SpouseMiddlename = table.Column<string>(type: "TEXT", nullable: true),
                    Occupation = table.Column<string>(type: "TEXT", nullable: true),
                    EmployerName = table.Column<string>(type: "TEXT", nullable: true),
                    BusinessAddress = table.Column<string>(type: "TEXT", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    FatherSurname = table.Column<string>(type: "TEXT", nullable: true),
                    FatherFirstname = table.Column<string>(type: "TEXT", nullable: true),
                    FatherMiddlename = table.Column<string>(type: "TEXT", nullable: true),
                    MotherSurnamne = table.Column<string>(type: "TEXT", nullable: true),
                    MotherFirstname = table.Column<string>(type: "TEXT", nullable: true),
                    MotherMiddlename = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyBackgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyBackgrounds_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LearningAndDevelopments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    TitleOfLearningAndDevelopment = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<string>(type: "TEXT", nullable: true),
                    NumberOfHours = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeOfLd = table.Column<string>(type: "TEXT", nullable: true),
                    Conducted = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningAndDevelopments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LearningAndDevelopments_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    SpecialSkills = table.Column<string>(type: "TEXT", nullable: true),
                    NonAcademicDestinction = table.Column<string>(type: "TEXT", nullable: true),
                    Organization = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherInformations_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: true),
                    Middlename = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<string>(type: "TEXT", nullable: true),
                    Sex = table.Column<int>(type: "INTEGER", nullable: false),
                    CivilStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<string>(type: "TEXT", nullable: true),
                    BloodType = table.Column<string>(type: "TEXT", nullable: true),
                    GsisIdNo = table.Column<string>(type: "TEXT", nullable: true),
                    PagibigIdNo = table.Column<string>(type: "TEXT", nullable: true),
                    PhilhealthNo = table.Column<string>(type: "TEXT", nullable: true),
                    SssNo = table.Column<string>(type: "TEXT", nullable: true),
                    TinNo = table.Column<string>(type: "TEXT", nullable: true),
                    AgencyEmployeeNo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalInformations_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoluntaryWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    NameAndAddressOfOrganization = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<string>(type: "TEXT", nullable: true),
                    NumberOfHours = table.Column<int>(type: "INTEGER", nullable: false),
                    NatureOfWork = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoluntaryWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoluntaryWorks_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<string>(type: "TEXT", nullable: true),
                    Position = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    MonthlySalary = table.Column<decimal>(type: "TEXT", nullable: false),
                    PayGrade = table.Column<string>(type: "TEXT", nullable: true),
                    StatusOfAppointment = table.Column<string>(type: "TEXT", nullable: true),
                    GovernmentService = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NameOfChildrens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyBackgroundId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameOfChildrens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NameOfChildrens_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NameOfChildrens_FamilyBackgrounds_FamilyBackgroundId",
                        column: x => x.FamilyBackgroundId,
                        principalTable: "FamilyBackgrounds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_EmployeeId",
                table: "Attendances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CivilServiceEligibilities_EmployeeNumberId",
                table: "CivilServiceEligibilities",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalBackgrounds_EmployeeNumberId",
                table: "EducationalBackgrounds",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyBackgrounds_EmployeeNumberId",
                table: "FamilyBackgrounds",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningAndDevelopments_EmployeeNumberId",
                table: "LearningAndDevelopments",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_NameOfChildrens_EmployeeNumberId",
                table: "NameOfChildrens",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_NameOfChildrens_FamilyBackgroundId",
                table: "NameOfChildrens",
                column: "FamilyBackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherInformations_EmployeeNumberId",
                table: "OtherInformations",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_EmployeeNumberId",
                table: "PersonalInformations",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_VoluntaryWorks_EmployeeNumberId",
                table: "VoluntaryWorks",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_EmployeeNumberId",
                table: "WorkExperiences",
                column: "EmployeeNumberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "AttendanceSetups");

            migrationBuilder.DropTable(
                name: "Campuses");

            migrationBuilder.DropTable(
                name: "CivilServiceEligibilities");

            migrationBuilder.DropTable(
                name: "EducationalBackgrounds");

            migrationBuilder.DropTable(
                name: "LearningAndDevelopments");

            migrationBuilder.DropTable(
                name: "LeaveSetups");

            migrationBuilder.DropTable(
                name: "NameOfChildrens");

            migrationBuilder.DropTable(
                name: "OtherInformations");

            migrationBuilder.DropTable(
                name: "PersonalInformations");

            migrationBuilder.DropTable(
                name: "VoluntaryWorks");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "FamilyBackgrounds");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
