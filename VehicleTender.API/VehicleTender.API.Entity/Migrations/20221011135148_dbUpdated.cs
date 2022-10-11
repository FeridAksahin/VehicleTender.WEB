using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class dbUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenderVehicleDetail_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleDetail");

            migrationBuilder.DropTable(
                name: "BuyingTenderVehicle");

            migrationBuilder.RenameColumn(
                name: "TenEvaluationPrice",
                table: "IndividualVehicleSales",
                newName: "PreAssessmentPrice");

            migrationBuilder.CreateTable(
                name: "BuyingTender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TenderVehicleSalesId = table.Column<int>(type: "int", nullable: false),
                    Offer = table.Column<decimal>(type: "money", nullable: true),
                    IsItSold = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyingTender", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyingTender_TenderVehicleSales_TenderVehicleSalesId",
                        column: x => x.TenderVehicleSalesId,
                        principalTable: "TenderVehicleSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyingTender_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TenderVehicleBid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenderVehicleDetailId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Bid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenderVehicleBid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenderVehicleBid_TenderVehicleDetail_TenderVehicleDetailId",
                        column: x => x.TenderVehicleDetailId,
                        principalTable: "TenderVehicleDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TenderVehicleBid_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyingTender_TenderVehicleSalesId",
                table: "BuyingTender",
                column: "TenderVehicleSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyingTender_UserId",
                table: "BuyingTender",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderVehicleBid_TenderVehicleDetailId",
                table: "TenderVehicleBid",
                column: "TenderVehicleDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderVehicleBid_UserId",
                table: "TenderVehicleBid",
                column: "UserId");

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

            migrationBuilder.DropTable(
                name: "BuyingTender");

            migrationBuilder.DropTable(
                name: "TenderVehicleBid");

            migrationBuilder.RenameColumn(
                name: "PreAssessmentPrice",
                table: "IndividualVehicleSales",
                newName: "TenEvaluationPrice");

            migrationBuilder.CreateTable(
                name: "BuyingTenderVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenderVehicleSalesId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsItSold = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Offer = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyingTenderVehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyingTenderVehicle_TenderVehicleSales_TenderVehicleSalesId",
                        column: x => x.TenderVehicleSalesId,
                        principalTable: "TenderVehicleSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyingTenderVehicle_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyingTenderVehicle_TenderVehicleSalesId",
                table: "BuyingTenderVehicle",
                column: "TenderVehicleSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyingTenderVehicle_UserId",
                table: "BuyingTenderVehicle",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TenderVehicleDetail_CarDetailInfo_CarDetailInfoId",
                table: "TenderVehicleDetail",
                column: "CarDetailInfoId",
                principalTable: "CarDetailInfo",
                principalColumn: "Id");
        }
    }
}
