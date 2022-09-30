using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: true),
                    RightRearMudguard = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RearBonnet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeftRearMudguard = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RightRearDoor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RightFrontDoor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ceiling = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeftRearDoor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeftFrontDoor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RightFrontMudguard = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EngineBonnet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeftFrontMudguard = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FrontBumper = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RearBumper = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalTramerPrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BodyType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransmissionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Version = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionPrice = table.Column<decimal>(type: "money", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnumCompanyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumCompanyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnumPacket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumPacket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnumStatuType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumStatuType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expertise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteSearchCriteria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    KM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSearchCriteria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogProcess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotaryPrice = table.Column<decimal>(type: "money", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertInfoId = table.Column<int>(type: "int", nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_AdvertInfo_AdvertInfoId",
                        column: x => x.AdvertInfoId,
                        principalTable: "AdvertInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hardware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    HardwareName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hardware_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacketAuthority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyTenderLimit = table.Column<int>(type: "int", nullable: true),
                    EnumPacketId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacketAuthority", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacketAuthority_EnumPacket_EnumPacketId",
                        column: x => x.EnumPacketId,
                        principalTable: "EnumPacket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EnumStatuTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statu_EnumStatuType_EnumStatuTypeId",
                        column: x => x.EnumStatuTypeId,
                        principalTable: "EnumStatuType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleAuthority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AuthorityId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAuthority", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleAuthority_Authority_AuthorityId",
                        column: x => x.AuthorityId,
                        principalTable: "Authority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleAuthority_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarDetailInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertInfoId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NotaryId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CommissionId = table.Column<int>(type: "int", nullable: false),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetailInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetailInfo_AdvertInfo_AdvertInfoId",
                        column: x => x.AdvertInfoId,
                        principalTable: "AdvertInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetailInfo_AdvertInfo_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "AdvertInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarDetailInfo_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetailInfo_Commission_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "Commission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarDetailInfo_Commission_CommissionId",
                        column: x => x.CommissionId,
                        principalTable: "Commission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetailInfo_Notary_NotaryId",
                        column: x => x.NotaryId,
                        principalTable: "Notary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetailInfo_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorporateDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    District = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnumCompanyTypeId = table.Column<int>(type: "int", nullable: false),
                    EnumPacketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorporateDetail_EnumCompanyType_EnumCompanyTypeId",
                        column: x => x.EnumCompanyTypeId,
                        principalTable: "EnumCompanyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorporateDetail_EnumPacket_EnumPacketId",
                        column: x => x.EnumPacketId,
                        principalTable: "EnumPacket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorporateDetail_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertInfoId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorite_AdvertInfo_AdvertInfoId",
                        column: x => x.AdvertInfoId,
                        principalTable: "AdvertInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    LogProcessId = table.Column<int>(type: "int", nullable: false),
                    Page = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Log_LogProcess_LogProcessId",
                        column: x => x.LogProcessId,
                        principalTable: "LogProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Log_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareId = table.Column<int>(type: "int", nullable: false),
                    FavoriteSearchCriteriaId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteFeature_FavoriteSearchCriteria_FavoriteSearchCriteriaId",
                        column: x => x.FavoriteSearchCriteriaId,
                        principalTable: "FavoriteSearchCriteria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteFeature_Hardware_HardwareId",
                        column: x => x.HardwareId,
                        principalTable: "Hardware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteFeature_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualVehicleSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: false),
                    TenEvaluationPrice = table.Column<decimal>(type: "money", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OfficialOffer = table.Column<decimal>(type: "money", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualVehicleSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualVehicleSales_CarDetailInfo_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "CarDetailInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndividualVehicleSales_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerUserId = table.Column<int>(type: "int", nullable: false),
                    BuyerUserId = table.Column<int>(type: "int", nullable: true),
                    isItTender = table.Column<bool>(type: "bit", nullable: true),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedVehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasedVehicle_CarDetailInfo_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "CarDetailInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasedVehicle_User_SellerUserId",
                        column: x => x.SellerUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_CarDetailInfo_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "CarDetailInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stock_User_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TenderVehicleSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatuId = table.Column<int>(type: "int", nullable: false),
                    TenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: false),
                    TenderStartingPrice = table.Column<decimal>(type: "money", nullable: true),
                    TenderMinumumPrice = table.Column<decimal>(type: "money", nullable: true),
                    TenderEndHour = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TenderEndDate = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    isItCorporate = table.Column<bool>(type: "bit", nullable: true),
                    TargetPrice = table.Column<decimal>(type: "money", nullable: true),
                    FavoriteCount = table.Column<int>(type: "int", nullable: true),
                    TenderDuration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenderVehicleSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenderVehicleSales_CarDetailInfo_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "CarDetailInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TenderVehicleSales_Statu_StatuId",
                        column: x => x.StatuId,
                        principalTable: "Statu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleStatuHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatuId = table.Column<int>(type: "int", nullable: false),
                    CarDetailInfoId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleStatuHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleStatuHistory_CarDetailInfo_CarDetailInfoId",
                        column: x => x.CarDetailInfoId,
                        principalTable: "CarDetailInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleStatuHistory_Statu_StatuId",
                        column: x => x.StatuId,
                        principalTable: "Statu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualVehiclePurchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserIdBuyer = table.Column<int>(type: "int", nullable: true),
                    IndividualVehicleSalesId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualVehiclePurchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualVehiclePurchase_IndividualVehicleSales_IndividualVehicleSalesId",
                        column: x => x.IndividualVehicleSalesId,
                        principalTable: "IndividualVehicleSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndividualVehiclePurchase_User_UserIdBuyer",
                        column: x => x.UserIdBuyer,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BuyingTenderVehicle",
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyingTenderVehicle_TenderVehicleSalesId",
                table: "BuyingTenderVehicle",
                column: "TenderVehicleSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyingTenderVehicle_UserId",
                table: "BuyingTenderVehicle",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailInfo_AdvertInfoId",
                table: "CarDetailInfo",
                column: "AdvertInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailInfo_CarDetailInfoId",
                table: "CarDetailInfo",
                column: "CarDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailInfo_CarId",
                table: "CarDetailInfo",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailInfo_CommissionId",
                table: "CarDetailInfo",
                column: "CommissionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailInfo_NotaryId",
                table: "CarDetailInfo",
                column: "NotaryId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailInfo_UserId",
                table: "CarDetailInfo",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateDetail_EnumCompanyTypeId",
                table: "CorporateDetail",
                column: "EnumCompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateDetail_EnumPacketId",
                table: "CorporateDetail",
                column: "EnumPacketId");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateDetail_UserId",
                table: "CorporateDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_AdvertInfoId",
                table: "Favorite",
                column: "AdvertInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteFeature_FavoriteSearchCriteriaId",
                table: "FavoriteFeature",
                column: "FavoriteSearchCriteriaId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteFeature_HardwareId",
                table: "FavoriteFeature",
                column: "HardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteFeature_UserId",
                table: "FavoriteFeature",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hardware_CarId",
                table: "Hardware",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualVehiclePurchase_IndividualVehicleSalesId",
                table: "IndividualVehiclePurchase",
                column: "IndividualVehicleSalesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualVehiclePurchase_UserIdBuyer",
                table: "IndividualVehiclePurchase",
                column: "UserIdBuyer");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualVehicleSales_CarDetailInfoId",
                table: "IndividualVehicleSales",
                column: "CarDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualVehicleSales_UserId",
                table: "IndividualVehicleSales",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_LogProcessId",
                table: "Log",
                column: "LogProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_UserId",
                table: "Log",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                table: "Message",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PacketAuthority_EnumPacketId",
                table: "PacketAuthority",
                column: "EnumPacketId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_AdvertInfoId",
                table: "Picture",
                column: "AdvertInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedVehicle_CarDetailInfoId",
                table: "PurchasedVehicle",
                column: "CarDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedVehicle_SellerUserId",
                table: "PurchasedVehicle",
                column: "SellerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAuthority_AuthorityId",
                table: "RoleAuthority",
                column: "AuthorityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAuthority_RoleId",
                table: "RoleAuthority",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_RoleId",
                table: "RoleUser",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UserId",
                table: "RoleUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Statu_EnumStatuTypeId",
                table: "Statu",
                column: "EnumStatuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_CarDetailInfoId",
                table: "Stock",
                column: "CarDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_CustomerId",
                table: "Stock",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderVehicleSales_CarDetailInfoId",
                table: "TenderVehicleSales",
                column: "CarDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderVehicleSales_StatuId",
                table: "TenderVehicleSales",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleStatuHistory_CarDetailInfoId",
                table: "VehicleStatuHistory",
                column: "CarDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleStatuHistory_StatuId",
                table: "VehicleStatuHistory",
                column: "StatuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyingTenderVehicle");

            migrationBuilder.DropTable(
                name: "CorporateDetail");

            migrationBuilder.DropTable(
                name: "Expertise");

            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "FavoriteFeature");

            migrationBuilder.DropTable(
                name: "IndividualVehiclePurchase");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "PacketAuthority");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "PurchasedVehicle");

            migrationBuilder.DropTable(
                name: "RoleAuthority");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "VehicleStatuHistory");

            migrationBuilder.DropTable(
                name: "TenderVehicleSales");

            migrationBuilder.DropTable(
                name: "EnumCompanyType");

            migrationBuilder.DropTable(
                name: "FavoriteSearchCriteria");

            migrationBuilder.DropTable(
                name: "Hardware");

            migrationBuilder.DropTable(
                name: "IndividualVehicleSales");

            migrationBuilder.DropTable(
                name: "LogProcess");

            migrationBuilder.DropTable(
                name: "EnumPacket");

            migrationBuilder.DropTable(
                name: "Authority");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Statu");

            migrationBuilder.DropTable(
                name: "CarDetailInfo");

            migrationBuilder.DropTable(
                name: "EnumStatuType");

            migrationBuilder.DropTable(
                name: "AdvertInfo");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Commission");

            migrationBuilder.DropTable(
                name: "Notary");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
