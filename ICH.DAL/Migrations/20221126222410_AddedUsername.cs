using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICH.DAL.Migrations
{
    public partial class AddedUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserInfo");
        }
    }
}
