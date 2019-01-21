using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class UpdateExistingMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Bronze' WHERE Id=1");
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Silver' WHERE Id=2");
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Gold' WHERE Id=3");
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Platinum' WHERE Id=4");
            migrationBuilder.Sql("UPDATE MembershipType SET Name='Mithril' WHERE Id=5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
