using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class DropIdFromTankType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TemporaryId",
                table: "TankType");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TankType",
                newName: "TankTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TankTypeId",
                table: "TankType",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "TemporaryId",
                table: "TankType",
                nullable: false,
                defaultValue: 0);
        }
    }
}
