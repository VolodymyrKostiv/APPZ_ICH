using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICH.DAL.Migrations
{
    public partial class UserVacancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VacancyStatusId",
                table: "Vacancies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserVacancyStatus",
                columns: table => new
                {
                    UserVacancyStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVacancyStatus", x => x.UserVacancyStatusId);
                });

            migrationBuilder.CreateTable(
                name: "VacancyStatus",
                columns: table => new
                {
                    VacancyStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyStatus", x => x.VacancyStatusId);
                });

            migrationBuilder.CreateTable(
                name: "UserVacancies",
                columns: table => new
                {
                    UserVacanaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    VacancyId = table.Column<int>(type: "int", nullable: true),
                    UserVacancyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVacancies", x => x.UserVacanaId);
                    table.ForeignKey(
                        name: "FK_UserVacancies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_UserVacancies_UserVacancyStatus_UserVacancyStatusId",
                        column: x => x.UserVacancyStatusId,
                        principalTable: "UserVacancyStatus",
                        principalColumn: "UserVacancyStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserVacancies_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "VacancyId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_VacancyStatusId",
                table: "Vacancies",
                column: "VacancyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVacancies_UserId",
                table: "UserVacancies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVacancies_UserVacancyStatusId",
                table: "UserVacancies",
                column: "UserVacancyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVacancies_VacancyId",
                table: "UserVacancies",
                column: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_VacancyStatus_VacancyStatusId",
                table: "Vacancies",
                column: "VacancyStatusId",
                principalTable: "VacancyStatus",
                principalColumn: "VacancyStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_VacancyStatus_VacancyStatusId",
                table: "Vacancies");

            migrationBuilder.DropTable(
                name: "UserVacancies");

            migrationBuilder.DropTable(
                name: "VacancyStatus");

            migrationBuilder.DropTable(
                name: "UserVacancyStatus");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_VacancyStatusId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "VacancyStatusId",
                table: "Vacancies");
        }
    }
}
