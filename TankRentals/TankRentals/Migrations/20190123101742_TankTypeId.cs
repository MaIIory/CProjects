using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class TankTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanks_TankType_TankTypeId",
                table: "Tanks");

            migrationBuilder.AlterColumn<int>(
                name: "TankTypeId",
                table: "Tanks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tanks_TankType_TankTypeId",
                table: "Tanks",
                column: "TankTypeId",
                principalTable: "TankType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanks_TankType_TankTypeId",
                table: "Tanks");

            migrationBuilder.AlterColumn<int>(
                name: "TankTypeId",
                table: "Tanks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Tanks_TankType_TankTypeId",
                table: "Tanks",
                column: "TankTypeId",
                principalTable: "TankType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
