using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Infrastructure.Migrations
{
    public partial class AddFieldPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Sweetnesses",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Sweetnesses");
        }
    }
}
