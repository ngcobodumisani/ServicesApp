using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.API.Migrations
{
    public partial class LeaveAvalable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveAvailables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AvailableNumberOfDays = table.Column<int>(nullable: false),
                    LeaveType = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAvailables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAvailables_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAvailables_UserId",
                table: "LeaveAvailables",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAvailables");
        }
    }
}
