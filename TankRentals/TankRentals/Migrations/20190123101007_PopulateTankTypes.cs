using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class PopulateTankTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TankType (Name) VALUES ('Light Tank')");
            migrationBuilder.Sql("INSERT INTO TankType (Name) VALUES ('Medium Tank')");
            migrationBuilder.Sql("INSERT INTO TankType (Name) VALUES ('Heavy Tank')");
            migrationBuilder.Sql("INSERT INTO TankType (Name) VALUES ('Tank Destroyer')");
            migrationBuilder.Sql("INSERT INTO TankType (Name) VALUES ('Artillery')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
