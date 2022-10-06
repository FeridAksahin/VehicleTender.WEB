using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenderVehicleDetail_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleDetail");

            migrationBuilder.AlterColumn<int>(
                name: "CarDetailInfoId",
                table: "TenderVehicleDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TenderVehicleDetail_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleDetail",
                column: "CarDetailInfoId",
                principalTable: "CarDetailInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenderVehicleDetail_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleDetail");

            migrationBuilder.AlterColumn<int>(
                name: "CarDetailInfoId",
                table: "TenderVehicleDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TenderVehicleDetail_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleDetail",
                column: "CarDetailInfoId",
                principalTable: "CarDetailInfo",
                principalColumn: "Id");
        }
    }
}
