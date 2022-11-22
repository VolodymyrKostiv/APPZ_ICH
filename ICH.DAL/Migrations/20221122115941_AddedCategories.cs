using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICH.DAL.Migrations
{
    public partial class AddedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecialCategory",
                columns: table => new
                {
                    SpecialCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialCategory", x => x.SpecialCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SpecialCategoryVacancy",
                columns: table => new
                {
                    SpecialCategoriesSpecialCategoryId = table.Column<int>(type: "int", nullable: false),
                    VacanciesVacancyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialCategoryVacancy", x => new { x.SpecialCategoriesSpecialCategoryId, x.VacanciesVacancyId });
                    table.ForeignKey(
                        name: "FK_SpecialCategoryVacancy_SpecialCategory_SpecialCategoriesSpecialCategoryId",
                        column: x => x.SpecialCategoriesSpecialCategoryId,
                        principalTable: "SpecialCategory",
                        principalColumn: "SpecialCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialCategoryVacancy_Vacancies_VacanciesVacancyId",
                        column: x => x.VacanciesVacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "VacancyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecialCategoryVacancy_VacanciesVacancyId",
                table: "SpecialCategoryVacancy",
                column: "VacanciesVacancyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecialCategoryVacancy");

            migrationBuilder.DropTable(
                name: "SpecialCategory");
        }
    }
}
