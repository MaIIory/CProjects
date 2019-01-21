using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class PopulateTankTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TankType (Id,Name) VALUES (1,'Light Tank')");
            migrationBuilder.Sql("INSERT INTO TankType (Id,Name) VALUES (2,'Medium Tank')");
            migrationBuilder.Sql("INSERT INTO TankType (Id,Name) VALUES (3,'Heavy Tank')");
            migrationBuilder.Sql("INSERT INTO TankType (Id,Name) VALUES (4,'Tank Destroyer')");
            migrationBuilder.Sql("INSERT INTO TankType (Id,Name) VALUES (5,'Artillery')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
