using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class AddTankTypeToTank2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TankTypeId",
                table: "Tanks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tanks_TankTypeId",
                table: "Tanks",
                column: "TankTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tanks_TankType_TankTypeId",
                table: "Tanks",
                column: "TankTypeId",
                principalTable: "TankType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanks_TankType_TankTypeId",
                table: "Tanks");

            migrationBuilder.DropIndex(
                name: "IX_Tanks_TankTypeId",
                table: "Tanks");

            migrationBuilder.DropColumn(
                name: "TankTypeId",
                table: "Tanks");
        }
    }
}
