﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TankRentals.Migrations
{
    public partial class PopulateMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MembershipType (DiscountLevel, Contract, ContractDurationInMonths) VALUES (0.0,0,0)");
            //migrationBuilder.Sql("INSERT INTO MembershipType (Id, DiscountLevel, Contract, ContractDurationInMonths) VALUES (1,0.15,0,0)");
            //migrationBuilder.Sql("INSERT INTO MembershipType (Id, DiscountLevel, Contract, ContractDurationInMonths) VALUES (2,0.30,0,0)");
            //migrationBuilder.Sql("INSERT INTO MembershipType (Id, DiscountLevel, Contract, ContractDurationInMonths) VALUES (3,0.50,1,12)");
            //migrationBuilder.Sql("INSERT INTO MembershipType (Id, DiscountLevel, Contract, ContractDurationInMonths) VALUES (4,1.0,1,24)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
