using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICH.DAL.Migrations
{
    public partial class VacancyCategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Vacancies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Vacancies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }
    }
}
