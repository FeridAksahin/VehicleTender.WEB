using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class bugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenderVehicleSales_AdvertInfo_CarDetailInfoId",
                table: "TenderVehicleSales");

            migrationBuilder.DropIndex(
                name: "IX_TenderVehicleSales_CarDetailInfoId",
                table: "TenderVehicleSales");

            migrationBuilder.DropColumn(
                name: "CarDetailInfoId",
                table: "TenderVehicleSales");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetailInfo_AdvertInfo_CarDetailInfoId",
                table: "CarDetailInfo",
                column: "CarDetailInfoId",
                principalTable: "AdvertInfo",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDetailInfo_AdvertInfo_CarDetailInfoId",
                table: "CarDetailInfo");

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
                name: "FK_TenderVehicleSales_AdvertInfo_CarDetailInfoId",
                table: "TenderVehicleSales",
                column: "CarDetailInfoId",
                principalTable: "AdvertInfo",
                principalColumn: "Id");
        }
    }
}
