using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class ChangeNameOfTankTypeIdToTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanks_TankType_TankTypeId1",
                table: "Tanks");

            migrationBuilder.DropIndex(
                name: "IX_Tanks_TankTypeId1",
                table: "Tanks");

            migrationBuilder.DropColumn(
                name: "TankTypeId1",
                table: "Tanks");

            migrationBuilder.AlterColumn<byte>(
                name: "TankTypeId",
                table: "Tanks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Tanks",
                nullable: false,
                defaultValue: 0);

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
                name: "TypeId",
                table: "Tanks");

            migrationBuilder.AlterColumn<int>(
                name: "TankTypeId",
                table: "Tanks",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "TankTypeId1",
                table: "Tanks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tanks_TankTypeId1",
                table: "Tanks",
                column: "TankTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tanks_TankType_TankTypeId1",
                table: "Tanks",
                column: "TankTypeId1",
                principalTable: "TankType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
