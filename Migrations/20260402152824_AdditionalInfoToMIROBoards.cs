using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageSchoolApp.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalInfoToMIROBoards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "BoardElements",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "BoardElements",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "BoardElements",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "BoardElements",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Points",
                table: "BoardElements",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "BoardElements",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "BoardElements",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "BoardElements",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "BoardElements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "BoardElements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "X",
                table: "BoardElements");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "BoardElements");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "BoardElements",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
