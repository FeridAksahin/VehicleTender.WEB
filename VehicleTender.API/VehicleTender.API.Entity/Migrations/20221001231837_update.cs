using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenderVehicleSales_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleSales");

            migrationBuilder.AlterColumn<int>(
                name: "CarDetailInfoId",
                table: "TenderVehicleSales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "TenderVehicleDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: true),
                    TenderVehicleSalesId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenderVehicleDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenderVehicleDetail_CarDetailInfo_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "CarDetailInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TenderVehicleDetail_TenderVehicleSales_TenderVehicleSalesId",
                        column: x => x.TenderVehicleSalesId,
                        principalTable: "TenderVehicleSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TenderVehicleDetail_CarDetailInfoId",
                table: "TenderVehicleDetail",
                column: "CarDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderVehicleDetail_TenderVehicleSalesId",
                table: "TenderVehicleDetail",
                column: "TenderVehicleSalesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TenderVehicleSales_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleSales",
                column: "CarDetailInfoId",
                principalTable: "CarDetailInfo",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenderVehicleSales_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleSales");

            migrationBuilder.DropTable(
                name: "TenderVehicleDetail");

            migrationBuilder.AlterColumn<int>(
                name: "CarDetailInfoId",
                table: "TenderVehicleSales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TenderVehicleSales_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleSales",
                column: "CarDetailInfoId",
                principalTable: "CarDetailInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
