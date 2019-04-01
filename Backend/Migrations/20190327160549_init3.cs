using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address2",
                table: "Brokers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "addresss1",
                table: "Brokers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Brokers",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "commission",
                table: "Brokers",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Brokers",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Brokers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address2",
                table: "Brokers");

            migrationBuilder.DropColumn(
                name: "addresss1",
                table: "Brokers");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Brokers");

            migrationBuilder.DropColumn(
                name: "commission",
                table: "Brokers");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Brokers");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Brokers");
        }
    }
}
