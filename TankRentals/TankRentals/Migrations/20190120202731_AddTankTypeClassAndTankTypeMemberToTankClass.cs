using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class AddTankTypeClassAndTankTypeMemberToTankClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Tanks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<short>(
                name: "NumberInGarage",
                table: "Tanks",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Tanks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte>(
                name: "TankTypeId",
                table: "Tanks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TankType",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TankType", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "TankType");

            migrationBuilder.DropIndex(
                name: "IX_Tanks_TankTypeId",
                table: "Tanks");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Tanks");

            migrationBuilder.DropColumn(
                name: "NumberInGarage",
                table: "Tanks");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Tanks");

            migrationBuilder.DropColumn(
                name: "TankTypeId",
                table: "Tanks");
        }
    }
}
