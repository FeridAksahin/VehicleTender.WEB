using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class dbUpdateBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenderVehicleSales_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleSales");

            migrationBuilder.DropIndex(
                name: "IX_TenderVehicleSales_CarDetailInfoId",
                table: "TenderVehicleSales");

            migrationBuilder.DropColumn(
                name: "CarDetailInfoId",
                table: "TenderVehicleSales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarDetailInfoId",
                table: "TenderVehicleSales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TenderVehicleSales_CarDetailInfoId",
                table: "TenderVehicleSales",
                column: "CarDetailInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TenderVehicleSales_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleSales",
                column: "CarDetailInfoId",
                principalTable: "CarDetailInfo",
                principalColumn: "Id");
        }
    }
}
