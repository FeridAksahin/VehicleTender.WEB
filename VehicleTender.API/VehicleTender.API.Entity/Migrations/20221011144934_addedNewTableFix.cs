using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleTender.API.Entity.Migrations
{
    public partial class addedNewTableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuyingTender_User_UserId",
                table: "BuyingTender");

            migrationBuilder.AddForeignKey(
                name: "FK_BuyingTender_User_UserId",
                table: "BuyingTender",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuyingTender_User_UserId",
                table: "BuyingTender");

            migrationBuilder.AddForeignKey(
                name: "FK_BuyingTender_User_UserId",
                table: "BuyingTender",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
