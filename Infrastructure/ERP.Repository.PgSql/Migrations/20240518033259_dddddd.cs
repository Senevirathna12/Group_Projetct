using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class dddddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010);

            migrationBuilder.CreateTable(
                name: "ComResults",
                columns: table => new
                {
                    ComId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentName = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: false),
                    Semester = table.Column<string>(type: "text", nullable: false),
                    CE0001 = table.Column<string>(type: "text", nullable: true),
                    CE0002 = table.Column<string>(type: "text", nullable: true),
                    CE0003 = table.Column<string>(type: "text", nullable: true),
                    CE0004 = table.Column<string>(type: "text", nullable: true),
                    CE0005 = table.Column<string>(type: "text", nullable: true),
                    CE0006 = table.Column<string>(type: "text", nullable: true),
                    CE0007 = table.Column<string>(type: "text", nullable: true),
                    CE0008 = table.Column<string>(type: "text", nullable: true),
                    CE0009 = table.Column<string>(type: "text", nullable: true),
                    CE0010 = table.Column<string>(type: "text", nullable: true),
                    CE0011 = table.Column<string>(type: "text", nullable: true),
                    CE0012 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComResults", x => x.ComId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComResults");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address1", "Address2", "Department", "District", "Email", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber", "RegistrationNum" },
                values: new object[,]
                {
                    { 1001, "", "", "", "", "Lucie.Stanton53@gmail.com", "Lucie", "Stanton", "", "", "", "EG/2020/4855" },
                    { 1002, "", "", "", "", "Asa_Schneider46@gmail.com", "Asa", "Schneider", "", "", "", "EG/2023/2328" },
                    { 1003, "", "", "", "", "Velma.Bailey1@hotmail.com", "Velma", "Bailey", "", "", "", "EG/2021/4549" },
                    { 1004, "", "", "", "", "Barton_Casper@gmail.com", "Barton", "Casper", "", "", "", "EG/2020/2341" },
                    { 1005, "", "", "", "", "Roselyn_Roob@yahoo.com", "Roselyn", "Roob", "", "", "", "EG/2021/2094" },
                    { 1006, "", "", "", "", "Osborne_Walsh71@gmail.com", "Osborne", "Walsh", "", "", "", "EG/2023/3294" },
                    { 1007, "", "", "", "", "Josefa7@hotmail.com", "Josefa", "Bode", "", "", "", "EG/2021/4538" },
                    { 1008, "", "", "", "", "Lillian.Collins@gmail.com", "Lillian", "Collins", "", "", "", "EG/2021/3170" },
                    { 1009, "", "", "", "", "Maybell.Hudson7@yahoo.com", "Maybell", "Hudson", "", "", "", "EG/2023/4224" },
                    { 1010, "", "", "", "", "Deborah_Bauch67@yahoo.com", "Deborah", "Bauch", "", "", "", "EG/2023/4706" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Address1", "Address2", "City", "Department", "District", "DoB", "Email", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[,]
                {
                    { 1001, "", "", "", "", "", new DateOnly(1, 1, 1), "Jace35@yahoo.com", "Jace", "Watsica", "", "", "" },
                    { 1002, "", "", "", "", "", new DateOnly(1, 1, 1), "Gabrielle9@hotmail.com", "Gabrielle", "Rohan", "", "", "" },
                    { 1003, "", "", "", "", "", new DateOnly(1, 1, 1), "Zechariah82@yahoo.com", "Zechariah", "Schowalter", "", "", "" },
                    { 1004, "", "", "", "", "", new DateOnly(1, 1, 1), "Jayne.Steuber@yahoo.com", "Jayne", "Steuber", "", "", "" },
                    { 1005, "", "", "", "", "", new DateOnly(1, 1, 1), "Alexzander23@hotmail.com", "Alexzander", "Hand", "", "", "" },
                    { 1006, "", "", "", "", "", new DateOnly(1, 1, 1), "Wade84@hotmail.com", "Wade", "Morissette", "", "", "" },
                    { 1007, "", "", "", "", "", new DateOnly(1, 1, 1), "Shirley48@yahoo.com", "Shirley", "Zemlak", "", "", "" },
                    { 1008, "", "", "", "", "", new DateOnly(1, 1, 1), "Nola0@hotmail.com", "Nola", "Herzog", "", "", "" },
                    { 1009, "", "", "", "", "", new DateOnly(1, 1, 1), "Jerod.Littel36@yahoo.com", "Jerod", "Littel", "", "", "" },
                    { 1010, "", "", "", "", "", new DateOnly(1, 1, 1), "David_Sipes@hotmail.com", "David", "Sipes", "", "", "" }
                });
        }
    }
}
