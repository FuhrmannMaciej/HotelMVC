using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    NumberOfFreeRooms = table.Column<int>(type: "int", nullable: false),
                    RoomPrice = table.Column<int>(type: "int", nullable: false),
                    FoundedIn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
