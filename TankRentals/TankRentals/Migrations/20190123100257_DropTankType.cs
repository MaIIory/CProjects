using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class DropTankType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "TankTypeId",
                table: "Tanks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TankTypeId",
                table: "Tanks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TankType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
