using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICH.DAL.Migrations
{
    public partial class AddedLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecialCategoryVacancy_SpecialCategory_SpecialCategoriesSpecialCategoryId",
                table: "SpecialCategoryVacancy");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_EmploymentType_EmploymentTypeId",
                table: "Vacancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialCategory",
                table: "SpecialCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmploymentType",
                table: "EmploymentType");

            migrationBuilder.RenameTable(
                name: "SpecialCategory",
                newName: "SpecialCategories");

            migrationBuilder.RenameTable(
                name: "EmploymentType",
                newName: "EmploymentTypes");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Vacancies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Vacancies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkTypeId",
                table: "Vacancies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "UserInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialCategories",
                table: "SpecialCategories",
                column: "SpecialCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmploymentTypes",
                table: "EmploymentTypes",
                column: "EmploymentTypeId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    WorkTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.WorkTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CategoryId",
                table: "Vacancies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_LocationId",
                table: "Vacancies",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_WorkTypeId",
                table: "Vacancies",
                column: "WorkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_LocationId",
                table: "UserInfo",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialCategoryVacancy_SpecialCategories_SpecialCategoriesSpecialCategoryId",
                table: "SpecialCategoryVacancy",
                column: "SpecialCategoriesSpecialCategoryId",
                principalTable: "SpecialCategories",
                principalColumn: "SpecialCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Locations_LocationId",
                table: "UserInfo",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_EmploymentTypes_EmploymentTypeId",
                table: "Vacancies",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "EmploymentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Locations_LocationId",
                table: "Vacancies",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_WorkTypes_WorkTypeId",
                table: "Vacancies",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "WorkTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecialCategoryVacancy_SpecialCategories_SpecialCategoriesSpecialCategoryId",
                table: "SpecialCategoryVacancy");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Locations_LocationId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_EmploymentTypes_EmploymentTypeId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Locations_LocationId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_WorkTypes_WorkTypeId",
                table: "Vacancies");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_CategoryId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_LocationId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_WorkTypeId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_UserInfo_LocationId",
                table: "UserInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialCategories",
                table: "SpecialCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmploymentTypes",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "WorkTypeId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "UserInfo");

            migrationBuilder.RenameTable(
                name: "SpecialCategories",
                newName: "SpecialCategory");

            migrationBuilder.RenameTable(
                name: "EmploymentTypes",
                newName: "EmploymentType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialCategory",
                table: "SpecialCategory",
                column: "SpecialCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmploymentType",
                table: "EmploymentType",
                column: "EmploymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialCategoryVacancy_SpecialCategory_SpecialCategoriesSpecialCategoryId",
                table: "SpecialCategoryVacancy",
                column: "SpecialCategoriesSpecialCategoryId",
                principalTable: "SpecialCategory",
                principalColumn: "SpecialCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_EmploymentType_EmploymentTypeId",
                table: "Vacancies",
                column: "EmploymentTypeId",
                principalTable: "EmploymentType",
                principalColumn: "EmploymentTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
