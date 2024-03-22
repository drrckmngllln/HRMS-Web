using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceSetupCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceSetupCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveSetups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Credits = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveSetups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonAcademicDestinction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Desctinction = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonAcademicDestinction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Skills = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceSetups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    TimeIn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TimeOut = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    GracePeriod = table.Column<int>(type: "integer", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceSetups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceSetups_AttendanceSetupCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AttendanceSetupCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DepartmentId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    PositionId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    ContractStart = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    ContractEnd = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "integer", maxLength: 100, nullable: false)
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
                name: "AttendanceIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", nullable: false),
                    Data = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceIdentities_Employees_EmployeeNumberId",
                        column: x => x.EmployeeNumberId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TimeIn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TimeInRemarks = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TimeOut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TimeOutRemarks = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", nullable: false),
                    Eligibility = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Rating = table.Column<decimal>(type: "numeric", maxLength: 100, nullable: false),
                    DateOfExamination = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    PlaceOfExamination = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    LicenseNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DateOfValidity = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    NameOfSchool = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Course = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PeriodStart = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    UnitsEarned = table.Column<decimal>(type: "numeric", maxLength: 100, nullable: false),
                    YearGraduated = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    AcademicHonors = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    SpouseSurname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SpouseFirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SpouseMiddlename = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Occupation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    EmployerName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    BusinessAddress = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TelephoneNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FatherSurname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FatherFirstname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FatherMiddlename = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MotherSurnamne = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MotherFirstname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MotherMiddlename = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    TitleOfLearningAndDevelopment = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    NumberOfHours = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    TypeOfLd = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Conducted = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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
                name: "NameOfChildrens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    Fullname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "OtherInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    SpecialSkillsId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    NonAcademicDestinctionId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    Organization = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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
                    table.ForeignKey(
                        name: "FK_OtherInformations_NonAcademicDestinction_NonAcademicDestinc~",
                        column: x => x.NonAcademicDestinctionId,
                        principalTable: "NonAcademicDestinction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtherInformations_SpecialSkills_SpecialSkillsId",
                        column: x => x.SpecialSkillsId,
                        principalTable: "SpecialSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Firstname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Middlename = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Sex = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    CivilStatus = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    Height = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    BloodType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    GsisIdNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PagibigIdNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PhilhealthNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SssNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TinNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    AgencyEmployeeNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    NameAndAddressOfOrganization = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StartDate = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    EndDate = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NumberOfHours = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    NatureOfWork = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNumberId = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    StartDate = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    EndDate = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Position = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Department = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MonthlySalary = table.Column<decimal>(type: "numeric", maxLength: 100, nullable: false),
                    PayGrade = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StatusOfAppointment = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    GovernmentService = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceIdentities_EmployeeNumberId",
                table: "AttendanceIdentities",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_EmployeeId",
                table: "Attendances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceSetups_CategoryId",
                table: "AttendanceSetups",
                column: "CategoryId");

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
                name: "IX_OtherInformations_EmployeeNumberId",
                table: "OtherInformations",
                column: "EmployeeNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherInformations_NonAcademicDestinctionId",
                table: "OtherInformations",
                column: "NonAcademicDestinctionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherInformations_SpecialSkillsId",
                table: "OtherInformations",
                column: "SpecialSkillsId");

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
                name: "AttendanceIdentities");

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
                name: "FamilyBackgrounds");

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
                name: "AttendanceSetupCategory");

            migrationBuilder.DropTable(
                name: "NonAcademicDestinction");

            migrationBuilder.DropTable(
                name: "SpecialSkills");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
