using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class _454545 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Christ_Ryan@yahoo.com", "Christ", "Ryan", "EG/2023/2819" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Aleen.Watsica@yahoo.com", "Aleen", "Watsica", "EG/2023/4593" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Holden83@hotmail.com", "Holden", "Schuppe", "EG/2022/4582" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Korbin_Leffler@hotmail.com", "Korbin", "Leffler", "EG/2023/3615" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Germaine_Ruecker99@gmail.com", "Germaine", "Ruecker", "EG/2020/3826" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lyric.Krajcik53@hotmail.com", "Lyric", "Krajcik", "EG/2023/3044" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Emelie_Mosciski21@gmail.com", "Emelie", "Mosciski", "EG/2022/4675" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Christa_Nienow@gmail.com", "Christa", "Nienow", "EG/2023/2831" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Darius24@gmail.com", "Darius", "Rice", "EG/2020/2949" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Willa.Kris66@gmail.com", "Willa", "Kris", "EG/2021/3950" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Daisy_Medhurst@gmail.com", "Daisy", "Medhurst" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Zaria_Braun56@yahoo.com", "Zaria", "Braun" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Polly.Bergnaum77@yahoo.com", "Polly", "Bergnaum" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Nickolas.Hudson48@hotmail.com", "Nickolas", "Hudson" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Hosea69@hotmail.com", "Hosea", "Kuhn" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Donavon47@gmail.com", "Donavon", "Ruecker" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Alyson_Wilkinson27@gmail.com", "Alyson", "Wilkinson" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Titus_Blick52@hotmail.com", "Titus", "Blick" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Shaun.Feest37@yahoo.com", "Shaun", "Feest" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Bernadine.Hermiston28@yahoo.com", "Bernadine", "Hermiston" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComResults");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Josue_Kuphal65@gmail.com", "Josue", "Kuphal", "EG/2020/3054" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Melvina.Kulas62@hotmail.com", "Melvina", "Kulas", "EG/2020/2758" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Vada32@yahoo.com", "Vada", "Dickens", "EG/2020/3797" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Dustin.Dicki87@gmail.com", "Dustin", "Dicki", "EG/2021/2662" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jaylen.Connelly@gmail.com", "Jaylen", "Connelly", "EG/2021/2874" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Maribel.Flatley@yahoo.com", "Maribel", "Flatley", "EG/2020/3290" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kariane.Heidenreich@gmail.com", "Kariane", "Heidenreich", "EG/2022/2756" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ettie_Tillman@hotmail.com", "Ettie", "Tillman", "EG/2023/4221" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lourdes_Mills62@hotmail.com", "Lourdes", "Mills", "EG/2020/2487" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ethel37@hotmail.com", "Ethel", "Mosciski", "EG/2022/4597" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Nicole.Volkman@hotmail.com", "Nicole", "Volkman" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Daisha_Hauck94@hotmail.com", "Daisha", "Hauck" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Felipe_Rippin@yahoo.com", "Felipe", "Rippin" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Tommie.Reichert@hotmail.com", "Tommie", "Reichert" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Hulda13@gmail.com", "Hulda", "Rosenbaum" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Jewel_Altenwerth@hotmail.com", "Jewel", "Altenwerth" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Maverick_Bernhard98@hotmail.com", "Maverick", "Bernhard" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Lempi.Stiedemann@gmail.com", "Lempi", "Stiedemann" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Elbert_Hoeger89@gmail.com", "Elbert", "Hoeger" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Marjory52@yahoo.com", "Marjory", "Feest" });
        }
    }
}
