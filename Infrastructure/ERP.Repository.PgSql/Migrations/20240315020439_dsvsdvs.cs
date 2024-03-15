using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class dsvsdvs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Willard.Osinski66@hotmail.com", "Willard", "Osinski", "EG/2020/3819" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Tia_Bogan@gmail.com", "Tia", "Bogan", "EG/2021/2441" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Elaina_Bode65@hotmail.com", "Elaina", "Bode", "EG/2020/9932" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Josianne.Hegmann17@yahoo.com", "Josianne", "Hegmann", "EG/2023/8500" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Audreanne.Bednar@yahoo.com", "Audreanne", "Bednar", "EG/2021/3289" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Gust_Senger29@gmail.com", "Gust", "Senger", "EG/2021/2132" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hector72@yahoo.com", "Hector", "Schmitt", "EG/2021/9454" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Gerard_Haley@yahoo.com", "Gerard", "Haley", "EG/2020/1336" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Turner30@yahoo.com", "Turner", "Weber", "EG/2022/4587" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Harvey3@hotmail.com", "Harvey", "Greenfelder", "EG/2021/2553" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Florence55@hotmail.com", "Florence", "DuBuque" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Madelyn_Jast@hotmail.com", "Madelyn", "Jast" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Amara10@yahoo.com", "Amara", "Vandervort" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Alphonso.Shields@yahoo.com", "Alphonso", "Shields" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Electa_OHara@hotmail.com", "Electa", "O'Hara" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Jacques39@gmail.com", "Jacques", "Zemlak" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Eliane.Wyman@yahoo.com", "Eliane", "Wyman" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Darrin78@gmail.com", "Darrin", "Fisher" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Caitlyn37@yahoo.com", "Caitlyn", "Fahey" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Alanis_Ratke92@gmail.com", "Alanis", "Ratke" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jedidiah_Jaskolski93@gmail.com", "Jedidiah", "Jaskolski", "EG/2023/9303" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Keaton51@yahoo.com", "Keaton", "Hodkiewicz", "EG/2023/4555" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kaleb.Flatley@hotmail.com", "Kaleb", "Flatley", "EG/2020/2315" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Chadd_Wuckert@gmail.com", "Chadd", "Wuckert", "EG/2022/3797" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Salma.Kutch@yahoo.com", "Salma", "Kutch", "EG/2023/6710" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Sabryna.Larson@hotmail.com", "Sabryna", "Larson", "EG/2021/7855" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Isaias86@gmail.com", "Isaias", "Bashirian", "EG/2023/3356" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Zander_Jenkins@hotmail.com", "Zander", "Jenkins", "EG/2020/1967" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Amber_Labadie@hotmail.com", "Amber", "Labadie", "EG/2020/3092" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hettie83@yahoo.com", "Hettie", "Johnson", "EG/2022/7496" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Breana88@yahoo.com", "Breana", "Langosh" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Coralie52@hotmail.com", "Coralie", "Hayes" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Alessia_Boyer@gmail.com", "Alessia", "Boyer" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Max66@gmail.com", "Max", "Kutch" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Alysson_Nolan29@hotmail.com", "Alysson", "Nolan" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Mafalda30@gmail.com", "Mafalda", "Welch" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Alfreda_Strosin@yahoo.com", "Alfreda", "Strosin" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Hyman.Ankunding50@gmail.com", "Hyman", "Ankunding" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Landen.Schultz34@yahoo.com", "Landen", "Schultz" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Joe19@hotmail.com", "Joe", "Aufderhar" });
        }
    }
}
