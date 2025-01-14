﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RusRoads.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNews_DeleteFK3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Employees_EmployeeGuid",
                table: "News");

            migrationBuilder.DropColumn(
                name: "EmpoloyeeGuid",
                table: "News");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeGuid",
                table: "News",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Employees_EmployeeGuid",
                table: "News",
                column: "EmployeeGuid",
                principalTable: "Employees",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Employees_EmployeeGuid",
                table: "News");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeGuid",
                table: "News",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "EmpoloyeeGuid",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Employees_EmployeeGuid",
                table: "News",
                column: "EmployeeGuid",
                principalTable: "Employees",
                principalColumn: "Guid");
        }
    }
}
