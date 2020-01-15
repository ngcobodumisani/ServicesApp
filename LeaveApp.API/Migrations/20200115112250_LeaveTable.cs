using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.API.Migrations
{
    public partial class LeaveTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LeaveType",
                table: "Leaves",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaveType",
                table: "Leaves");
        }
    }
}
