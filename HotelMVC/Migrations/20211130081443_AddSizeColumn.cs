using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelMVC.Migrations
{
    public partial class AddSizeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Hotel");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Hotel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Hotel");

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Hotel",
                type: "decimal(3,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
