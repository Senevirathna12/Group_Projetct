using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class ebeuibejbfi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Madisen79@hotmail.com", "Madisen", "Frami", "EG/2020/2775" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Delilah.Hilll99@hotmail.com", "Delilah", "Hilll", "EG/2023/4056" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Simone91@yahoo.com", "Simone", "Lemke", "EG/2021/9306" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ivory2@yahoo.com", "Ivory", "Luettgen", "EG/2021/8259" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jackson90@gmail.com", "Jackson", "Cronin", "EG/2022/7549" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Rickey.Wilkinson@yahoo.com", "Rickey", "Wilkinson", "EG/2021/9589" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Cordelia51@hotmail.com", "Cordelia", "Torphy", "EG/2023/2089" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Terrance72@yahoo.com", "Terrance", "Considine", "EG/2023/8980" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Winston75@gmail.com", "Winston", "Schaden", "EG/2022/3423" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ova53@yahoo.com", "Ova", "Harvey", "EG/2020/2745" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Clinton57@gmail.com", "Clinton", "Sanford" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Hugh93@yahoo.com", "Hugh", "Quitzon" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Garett_Jones41@yahoo.com", "Garett", "Jones" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Bulah.Daugherty2@yahoo.com", "Bulah", "Daugherty" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Leone.Boehm43@yahoo.com", "Leone", "Boehm" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Kiarra_Nicolas@hotmail.com", "Kiarra", "Nicolas" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Ladarius.Gutmann59@yahoo.com", "Ladarius", "Gutmann" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Koby.Roob98@gmail.com", "Koby", "Roob" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Demond_Hartmann69@gmail.com", "Demond", "Hartmann" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Monica11@gmail.com", "Monica", "Heaney" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Marjorie_Beahan71@hotmail.com", "Marjorie", "Beahan", "EG/2023/9912" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Greyson.Volkman@gmail.com", "Greyson", "Volkman", "EG/2022/2335" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Sherwood.Gaylord@yahoo.com", "Sherwood", "Gaylord", "EG/2022/3172" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Sydni_Casper69@yahoo.com", "Sydni", "Casper", "EG/2023/4380" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Emmanuelle.Hansen28@hotmail.com", "Emmanuelle", "Hansen", "EG/2021/4103" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Garrett69@gmail.com", "Garrett", "Lesch", "EG/2023/6072" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Stephon_Marks@gmail.com", "Stephon", "Marks", "EG/2020/5369" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Neil73@gmail.com", "Neil", "Gutmann", "EG/2021/6364" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Carlos86@gmail.com", "Carlos", "Trantow", "EG/2021/5520" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alec.Bartoletti56@yahoo.com", "Alec", "Bartoletti", "EG/2022/2787" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Luther16@yahoo.com", "Luther", "Labadie" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Aglae_Hilpert33@hotmail.com", "Aglae", "Hilpert" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Zetta.Witting85@yahoo.com", "Zetta", "Witting" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Gregg_Wilkinson36@gmail.com", "Gregg", "Wilkinson" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Rubie_Maggio14@gmail.com", "Rubie", "Maggio" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Aaliyah.Flatley39@yahoo.com", "Aaliyah", "Flatley" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Andreanne_West@hotmail.com", "Andreanne", "West" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Mario.Marvin@hotmail.com", "Mario", "Marvin" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Maria.Hickle67@hotmail.com", "Maria", "Hickle" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Nikki.Dare34@yahoo.com", "Nikki", "Dare" });
        }
    }
}
