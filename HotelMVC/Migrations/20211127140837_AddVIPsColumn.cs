using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelMVC.Migrations
{
    public partial class AddVIPsColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VIPs",
                table: "Hotel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VIPs",
                table: "Hotel");
        }
    }
}
