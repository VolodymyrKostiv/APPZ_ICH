using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICH.DAL.Migrations
{
    public partial class AddedUserInfoNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "UserInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmploymentTypeId",
                table: "UserInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkTypeId",
                table: "UserInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpecialCategoryUserInfo",
                columns: table => new
                {
                    SpecialCategoriesSpecialCategoryId = table.Column<int>(type: "int", nullable: false),
                    UserInfosUserInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialCategoryUserInfo", x => new { x.SpecialCategoriesSpecialCategoryId, x.UserInfosUserInfoId });
                    table.ForeignKey(
                        name: "FK_SpecialCategoryUserInfo_SpecialCategories_SpecialCategoriesSpecialCategoryId",
                        column: x => x.SpecialCategoriesSpecialCategoryId,
                        principalTable: "SpecialCategories",
                        principalColumn: "SpecialCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialCategoryUserInfo_UserInfo_UserInfosUserInfoId",
                        column: x => x.UserInfosUserInfoId,
                        principalTable: "UserInfo",
                        principalColumn: "UserInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_CategoryId",
                table: "UserInfo",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_EmploymentTypeId",
                table: "UserInfo",
                column: "EmploymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_WorkTypeId",
                table: "UserInfo",
                column: "WorkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialCategoryUserInfo_UserInfosUserInfoId",
                table: "SpecialCategoryUserInfo",
                column: "UserInfosUserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Categories_CategoryId",
                table: "UserInfo",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_EmploymentTypes_EmploymentTypeId",
                table: "UserInfo",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "EmploymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_WorkTypes_WorkTypeId",
                table: "UserInfo",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "WorkTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Categories_CategoryId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_EmploymentTypes_EmploymentTypeId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_WorkTypes_WorkTypeId",
                table: "UserInfo");

            migrationBuilder.DropTable(
                name: "SpecialCategoryUserInfo");

            migrationBuilder.DropIndex(
                name: "IX_UserInfo_CategoryId",
                table: "UserInfo");

            migrationBuilder.DropIndex(
                name: "IX_UserInfo_EmploymentTypeId",
                table: "UserInfo");

            migrationBuilder.DropIndex(
                name: "IX_UserInfo_WorkTypeId",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "EmploymentTypeId",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "WorkTypeId",
                table: "UserInfo");
        }
    }
}
