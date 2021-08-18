using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Infrastructure.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sweetnesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    ShelfLife = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SweetnessCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sweetnesses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sweetnesses");
        }
    }
}
