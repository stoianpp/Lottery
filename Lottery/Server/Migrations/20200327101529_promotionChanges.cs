using Microsoft.EntityFrameworkCore.Migrations;

namespace Lottery.Server.Migrations
{
    public partial class promotionChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Promotions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "GiftsPromotions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "GiftsPromotions");
        }
    }
}
