﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class vsvs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenderStartDate",
                table: "TenderVehicleSales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenderStartDate",
                table: "TenderVehicleSales",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
