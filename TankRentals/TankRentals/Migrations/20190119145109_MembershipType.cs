using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class MembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeId1",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiscountLevel = table.Column<float>(nullable: false),
                    Contract = table.Column<bool>(nullable: false),
                    ContractDurationInMonths = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MembershipTypeId1",
                table: "Customers",
                column: "MembershipTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MembershipType_MembershipTypeId1",
                table: "Customers",
                column: "MembershipTypeId1",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipType_MembershipTypeId1",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "MembershipType");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MembershipTypeId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId1",
                table: "Customers");
        }
    }
}
