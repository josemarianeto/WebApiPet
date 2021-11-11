using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiPet.Migrations
{
    public partial class acess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "acessos",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "acessos",
                table: "User");
        }
    }
}
