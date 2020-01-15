using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.API.Migrations
{
    public partial class LeaveAdditional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Leaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Leaves",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "HR",
                table: "Leaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Manager",
                table: "Leaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Leaves",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Leaves",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Leaves",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumberOfDays",
                table: "Leaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Leaves",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "HR",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "Manager",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "TotalNumberOfDays",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Leaves");
        }
    }
}
