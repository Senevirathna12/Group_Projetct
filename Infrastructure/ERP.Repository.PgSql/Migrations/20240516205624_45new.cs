using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class _45new : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address1", "Address2", "Department", "District", "Email", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber", "RegistrationNum" },
                values: new object[,]
                {
                    { 1001, "", "", "", "", "Christ_Ryan@yahoo.com", "Christ", "Ryan", "", "", "", "EG/2023/2819" },
                    { 1002, "", "", "", "", "Aleen.Watsica@yahoo.com", "Aleen", "Watsica", "", "", "", "EG/2023/4593" },
                    { 1003, "", "", "", "", "Holden83@hotmail.com", "Holden", "Schuppe", "", "", "", "EG/2022/4582" },
                    { 1004, "", "", "", "", "Korbin_Leffler@hotmail.com", "Korbin", "Leffler", "", "", "", "EG/2023/3615" },
                    { 1005, "", "", "", "", "Germaine_Ruecker99@gmail.com", "Germaine", "Ruecker", "", "", "", "EG/2020/3826" },
                    { 1006, "", "", "", "", "Lyric.Krajcik53@hotmail.com", "Lyric", "Krajcik", "", "", "", "EG/2023/3044" },
                    { 1007, "", "", "", "", "Emelie_Mosciski21@gmail.com", "Emelie", "Mosciski", "", "", "", "EG/2022/4675" },
                    { 1008, "", "", "", "", "Christa_Nienow@gmail.com", "Christa", "Nienow", "", "", "", "EG/2023/2831" },
                    { 1009, "", "", "", "", "Darius24@gmail.com", "Darius", "Rice", "", "", "", "EG/2020/2949" },
                    { 1010, "", "", "", "", "Willa.Kris66@gmail.com", "Willa", "Kris", "", "", "", "EG/2021/3950" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Address1", "Address2", "City", "Department", "District", "DoB", "Email", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[,]
                {
                    { 1001, "", "", "", "", "", new DateOnly(1, 1, 1), "Daisy_Medhurst@gmail.com", "Daisy", "Medhurst", "", "", "" },
                    { 1002, "", "", "", "", "", new DateOnly(1, 1, 1), "Zaria_Braun56@yahoo.com", "Zaria", "Braun", "", "", "" },
                    { 1003, "", "", "", "", "", new DateOnly(1, 1, 1), "Polly.Bergnaum77@yahoo.com", "Polly", "Bergnaum", "", "", "" },
                    { 1004, "", "", "", "", "", new DateOnly(1, 1, 1), "Nickolas.Hudson48@hotmail.com", "Nickolas", "Hudson", "", "", "" },
                    { 1005, "", "", "", "", "", new DateOnly(1, 1, 1), "Hosea69@hotmail.com", "Hosea", "Kuhn", "", "", "" },
                    { 1006, "", "", "", "", "", new DateOnly(1, 1, 1), "Donavon47@gmail.com", "Donavon", "Ruecker", "", "", "" },
                    { 1007, "", "", "", "", "", new DateOnly(1, 1, 1), "Alyson_Wilkinson27@gmail.com", "Alyson", "Wilkinson", "", "", "" },
                    { 1008, "", "", "", "", "", new DateOnly(1, 1, 1), "Titus_Blick52@hotmail.com", "Titus", "Blick", "", "", "" },
                    { 1009, "", "", "", "", "", new DateOnly(1, 1, 1), "Shaun.Feest37@yahoo.com", "Shaun", "Feest", "", "", "" },
                    { 1010, "", "", "", "", "", new DateOnly(1, 1, 1), "Bernadine.Hermiston28@yahoo.com", "Bernadine", "Hermiston", "", "", "" }
                });
        }
    }
}
