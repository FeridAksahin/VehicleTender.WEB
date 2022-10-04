using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class dbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDetailInfo_Commission_CarDetailInfoId",
                table: "CarDetailInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_User_CustomerId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_CustomerId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserMessage",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "HardwareName",
                table: "Hardware");

            migrationBuilder.DropColumn(
                name: "CarDetailInfoId",
                table: "Commission");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "KM",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "TransmissionType",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Ceiling",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "EngineBonnet",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "FrontBumper",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "LeftFrontDoor",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "LeftFrontMudguard",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "LeftRearDoor",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "LeftRearMudguard",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "RearBonnet",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "RearBumper",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "RightFrontDoor",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "RightFrontMudguard",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "RightRearDoor",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "RightRearMudguard",
                table: "AdvertInfo");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "VehicleStatuHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Kvkk",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnumMessageId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HardwareTypeId",
                table: "Hardware",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KM",
                table: "AdvertInfo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AdvertInfo",
                type: "money",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarFeatureCodeMeaning",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatureCodeMeaning", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPacketHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EnumPacketId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPacketHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyPacketHistory_EnumPacket_EnumPacketId",
                        column: x => x.EnumPacketId,
                        principalTable: "EnumPacket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyPacketHistory_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnumMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<int>(type: "int", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardwareType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualVehicleSalesStatuHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndividualVehicleSalesId = table.Column<int>(type: "int", nullable: false),
                    StatuId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualVehicleSalesStatuHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualVehicleSalesStatuHistory_IndividualVehicleSales_IndividualVehicleSalesId",
                        column: x => x.IndividualVehicleSalesId,
                        principalTable: "IndividualVehicleSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndividualVehicleSalesStatuHistory_Statu_StatuId",
                        column: x => x.StatuId,
                        principalTable: "Statu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TenderStatuHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatuId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenderStatuHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenderStatuHistory_Statu_StatuId",
                        column: x => x.StatuId,
                        principalTable: "Statu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TramerPart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramerPartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TramerPrice = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerPart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TramerSituationValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Situation = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerSituationValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarFeatureCodeMeaningId = table.Column<int>(type: "int", nullable: false),
                    CarFeatureName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarFeature_CarFeatureCodeMeaning_CarFeatureCodeMeaningId",
                        column: x => x.CarFeatureCodeMeaningId,
                        principalTable: "CarFeatureCodeMeaning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TramerValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramerPartId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    TramerSituationValueId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TramerValue_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramerValue_TramerPart_TramerPartId",
                        column: x => x.TramerPartId,
                        principalTable: "TramerPart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramerValue_TramerSituationValue_TramerSituationValueId",
                        column: x => x.TramerSituationValueId,
                        principalTable: "TramerSituationValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatureValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarFeatureId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatureValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarFeatureValue_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarFeatureValue_CarFeature_CarFeatureId",
                        column: x => x.CarFeatureId,
                        principalTable: "CarFeature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stock_UserId",
                table: "Stock",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_EnumMessageId",
                table: "Message",
                column: "EnumMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Hardware_HardwareTypeId",
                table: "Hardware",
                column: "HardwareTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeature_CarFeatureCodeMeaningId",
                table: "CarFeature",
                column: "CarFeatureCodeMeaningId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatureValue_CarFeatureId",
                table: "CarFeatureValue",
                column: "CarFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatureValue_CarId",
                table: "CarFeatureValue",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPacketHistory_EnumPacketId",
                table: "CompanyPacketHistory",
                column: "EnumPacketId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPacketHistory_UserId",
                table: "CompanyPacketHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualVehicleSalesStatuHistory_IndividualVehicleSalesId",
                table: "IndividualVehicleSalesStatuHistory",
                column: "IndividualVehicleSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualVehicleSalesStatuHistory_StatuId",
                table: "IndividualVehicleSalesStatuHistory",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderStatuHistory_StatuId",
                table: "TenderStatuHistory",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_TramerValue_CarId",
                table: "TramerValue",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_TramerValue_TramerPartId",
                table: "TramerValue",
                column: "TramerPartId");

            migrationBuilder.CreateIndex(
                name: "IX_TramerValue_TramerSituationValueId",
                table: "TramerValue",
                column: "TramerSituationValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hardware_HardwareType_HardwareTypeId",
                table: "Hardware",
                column: "HardwareTypeId",
                principalTable: "HardwareType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_EnumMessage_EnumMessageId",
                table: "Message",
                column: "EnumMessageId",
                principalTable: "EnumMessage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_User_UserId",
                table: "Stock",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hardware_HardwareType_HardwareTypeId",
                table: "Hardware");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_EnumMessage_EnumMessageId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_User_UserId",
                table: "Stock");

            migrationBuilder.DropTable(
                name: "CarFeatureValue");

            migrationBuilder.DropTable(
                name: "CompanyPacketHistory");

            migrationBuilder.DropTable(
                name: "EnumMessage");

            migrationBuilder.DropTable(
                name: "HardwareType");

            migrationBuilder.DropTable(
                name: "IndividualVehicleSalesStatuHistory");

            migrationBuilder.DropTable(
                name: "TenderStatuHistory");

            migrationBuilder.DropTable(
                name: "TramerValue");

            migrationBuilder.DropTable(
                name: "CarFeature");

            migrationBuilder.DropTable(
                name: "TramerPart");

            migrationBuilder.DropTable(
                name: "TramerSituationValue");

            migrationBuilder.DropTable(
                name: "CarFeatureCodeMeaning");

            migrationBuilder.DropIndex(
                name: "IX_Stock_UserId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Message_EnumMessageId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Hardware_HardwareTypeId",
                table: "Hardware");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "VehicleStatuHistory");

            migrationBuilder.DropColumn(
                name: "Kvkk",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EnumMessageId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "HardwareTypeId",
                table: "Hardware");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "KM",
                table: "AdvertInfo");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AdvertInfo");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Stock",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Message",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserMessage",
                table: "Message",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HardwareName",
                table: "Hardware",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CarDetailInfoId",
                table: "Commission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Car",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Car",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Car",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KM",
                table: "Car",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Car",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransmissionType",
                table: "Car",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Car",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ceiling",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngineBonnet",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrontBumper",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeftFrontDoor",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeftFrontMudguard",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeftRearDoor",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeftRearMudguard",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RearBonnet",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RearBumper",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RightFrontDoor",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RightFrontMudguard",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RightRearDoor",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RightRearMudguard",
                table: "AdvertInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_CustomerId",
                table: "Stock",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetailInfo_Commission_CarDetailInfoId",
                table: "CarDetailInfo",
                column: "CarDetailInfoId",
                principalTable: "Commission",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_User_CustomerId",
                table: "Stock",
                column: "CustomerId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
