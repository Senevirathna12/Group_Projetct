using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class sudhgsfjdhgfskdjf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CE0008",
                table: "ComResults");

            migrationBuilder.DropColumn(
                name: "CE0009",
                table: "ComResults");

            migrationBuilder.DropColumn(
                name: "CE0010",
                table: "ComResults");

            migrationBuilder.DropColumn(
                name: "CE0011",
                table: "ComResults");

            migrationBuilder.DropColumn(
                name: "CE0012",
                table: "ComResults");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "ComResults");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "ComResults");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CE0008",
                table: "ComResults",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CE0009",
                table: "ComResults",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CE0010",
                table: "ComResults",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CE0011",
                table: "ComResults",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CE0012",
                table: "ComResults",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "ComResults",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "ComResults",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
