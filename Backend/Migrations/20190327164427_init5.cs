using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "addresss1",
                table: "Brokers",
                newName: "address1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "address1",
                table: "Brokers",
                newName: "addresss1");
        }
    }
}
