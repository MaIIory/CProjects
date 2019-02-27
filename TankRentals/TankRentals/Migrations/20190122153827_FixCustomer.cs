using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class FixCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId1",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "MembershipTypeId1",
                table: "Customers",
                newName: "MembershipTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MembershipTypeId1",
                table: "Customers",
                newName: "IX_Customers_MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "MembershipTypeId",
                table: "Customers",
                newName: "MembershipTypeId1");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "Customers",
                newName: "IX_Customers_MembershipTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId1",
                table: "Customers",
                column: "MembershipTypeId1",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
