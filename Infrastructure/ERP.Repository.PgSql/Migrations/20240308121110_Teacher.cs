using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class Teacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Davonte_Heidenreich77@hotmail.com", "Davonte", "Heidenreich", "EG/2020/4709" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Shanelle.Hegmann85@hotmail.com", "Shanelle", "Hegmann", "EG/2021/9388" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Donny.Dicki27@yahoo.com", "Donny", "Dicki", "EG/2022/2805" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Anabel.Ernser55@gmail.com", "Anabel", "Ernser", "EG/2021/4604" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Maynard.Sanford@hotmail.com", "Maynard", "Sanford", "EG/2021/8014" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jermain_Marvin@hotmail.com", "Jermain", "Marvin", "EG/2021/1150" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mya.Greenfelder62@hotmail.com", "Mya", "Greenfelder", "EG/2023/4384" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kenna.Kreiger19@yahoo.com", "Kenna", "Kreiger", "EG/2023/5555" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Erica17@yahoo.com", "Erica", "Auer", "EG/2021/5067" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Xzavier.Kuhlman79@hotmail.com", "Xzavier", "Kuhlman", "EG/2022/4600" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Donny.Bayer@gmail.com", "Donny", "Bayer" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Irwin54@gmail.com", "Irwin", "Watsica" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Mack_Bins@yahoo.com", "Mack", "Bins" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Address1", "Address2", "City", "District", "DoB", "Email", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[,]
                {
                    { 1004, "", "", "", "", new DateOnly(1, 1, 1), "Mayra10@yahoo.com", "Mayra", "Hammes", "", "", "" },
                    { 1005, "", "", "", "", new DateOnly(1, 1, 1), "Woodrow_DAmore@hotmail.com", "Woodrow", "D'Amore", "", "", "" },
                    { 1006, "", "", "", "", new DateOnly(1, 1, 1), "Deontae40@gmail.com", "Deontae", "Kulas", "", "", "" },
                    { 1007, "", "", "", "", new DateOnly(1, 1, 1), "Jeromy.Huels84@gmail.com", "Jeromy", "Huels", "", "", "" },
                    { 1008, "", "", "", "", new DateOnly(1, 1, 1), "Damon_Beahan@hotmail.com", "Damon", "Beahan", "", "", "" },
                    { 1009, "", "", "", "", new DateOnly(1, 1, 1), "Jammie_Mosciski63@hotmail.com", "Jammie", "Mosciski", "", "", "" },
                    { 1010, "", "", "", "", new DateOnly(1, 1, 1), "Annetta_Hills@yahoo.com", "Annetta", "Hills", "", "", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Abner87@hotmail.com", "Abner", "Quigley", "EG/2023/3804" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Dawson.Hansen73@gmail.com", "Dawson", "Hansen", "EG/2021/9919" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Norberto.Monahan46@hotmail.com", "Norberto", "Monahan", "EG/2023/4050" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hayley.Heaney47@hotmail.com", "Hayley", "Heaney", "EG/2021/2841" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Raul.Schuppe@gmail.com", "Raul", "Schuppe", "EG/2022/6154" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Green77@yahoo.com", "Green", "Nolan", "EG/2021/4260" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Deontae.Balistreri3@hotmail.com", "Deontae", "Balistreri", "EG/2023/4955" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Caden76@gmail.com", "Caden", "Wehner", "EG/2023/8107" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jadon71@gmail.com", "Jadon", "Ruecker", "EG/2023/4667" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Chase14@gmail.com", "Chase", "Hills", "EG/2023/2218" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Brionna_Kub@yahoo.com", "Brionna", "Kub" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Leda_Jakubowski16@yahoo.com", "Leda", "Jakubowski" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Deonte_Dietrich30@hotmail.com", "Deonte", "Dietrich" });
        }
    }
}
