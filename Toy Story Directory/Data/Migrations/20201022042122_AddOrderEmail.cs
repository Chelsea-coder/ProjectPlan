using Microsoft.EntityFrameworkCore.Migrations;

namespace Toy_Story_Directory.Data.Migrations
{
    public partial class AddOrderEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Orders");
        }
    }
}
