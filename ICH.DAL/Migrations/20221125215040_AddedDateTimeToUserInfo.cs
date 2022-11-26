using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICH.DAL.Migrations
{
    public partial class AddedDateTimeToUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "UserInfo",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "UserInfo");
        }
    }
}
