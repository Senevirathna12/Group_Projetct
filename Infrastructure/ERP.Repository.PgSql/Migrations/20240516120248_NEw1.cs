using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class NEw1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semester_Students_StudentId",
                table: "Semester");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Degree_DegreeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DegreeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Semester_StudentId",
                table: "Semester");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Semester");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mireille.Mayert@hotmail.com", "Mireille", "Mayert", "EG/2021/3329" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Retha99@yahoo.com", "Retha", "Corkery", "EG/2021/4412" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Olaf_Terry89@gmail.com", "Olaf", "Terry", "EG/2023/3473" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Juvenal_Koelpin@hotmail.com", "Juvenal", "Koelpin", "EG/2022/2245" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Chasity7@hotmail.com", "Chasity", "Smitham", "EG/2020/2219" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Elvie86@yahoo.com", "Elvie", "Upton", "EG/2020/3434" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Haleigh.Wiegand0@yahoo.com", "Haleigh", "Wiegand", "EG/2021/3672" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jannie.Sawayn@yahoo.com", "Jannie", "Sawayn", "EG/2022/3544" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jeffry23@hotmail.com", "Jeffry", "Rau", "EG/2020/2370" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Einar30@gmail.com", "Einar", "Waters", "EG/2023/3265" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Frederik29@yahoo.com", "Frederik", "Marvin" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Estefania54@gmail.com", "Estefania", "Casper" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Mose69@gmail.com", "Mose", "Beer" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Donny_Labadie9@hotmail.com", "Donny", "Labadie" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Erika59@hotmail.com", "Erika", "Haag" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Brooks.Funk53@gmail.com", "Brooks", "Funk" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Sam.Kautzer24@yahoo.com", "Sam", "Kautzer" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Mohammad_Lesch@yahoo.com", "Mohammad", "Lesch" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Kylee.Conn@gmail.com", "Kylee", "Conn" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Caterina35@yahoo.com", "Caterina", "Smith" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Students",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Semester",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Amely_Koelpin@yahoo.com", "Amely", "Koelpin", "EG/2022/4998" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Veda29@yahoo.com", "Veda", "Boehm", "EG/2023/1999" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Marvin.Swaniawski98@hotmail.com", "Marvin", "Swaniawski", "EG/2020/9485" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Hillard73@hotmail.com", "Hillard", "Mante", "EG/2023/6892" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Berry.Gulgowski@yahoo.com", "Berry", "Gulgowski", "EG/2022/3428" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Caleb_Boyer@gmail.com", "Caleb", "Boyer", "EG/2020/4102" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Susie64@yahoo.com", "Susie", "Schmidt", "EG/2020/1127" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Harold89@hotmail.com", "Harold", "Morar", "EG/2020/7729" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Sierra4@yahoo.com", "Sierra", "McCullough", "EG/2020/3811" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "DegreeId", "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { null, "Jewel_Lemke46@gmail.com", "Jewel", "Lemke", "EG/2020/1921" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Jermey33@yahoo.com", "Jermey", "Conn" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Agustina_Goldner58@yahoo.com", "Agustina", "Goldner" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Tobin_Hyatt67@hotmail.com", "Tobin", "Hyatt" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Eldora13@hotmail.com", "Eldora", "Hackett" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Kacie99@yahoo.com", "Kacie", "Weissnat" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Lizeth.Purdy41@hotmail.com", "Lizeth", "Purdy" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Maia_Barrows94@gmail.com", "Maia", "Barrows" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Kian.Hoeger@hotmail.com", "Kian", "Hoeger" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Sanford_Block44@hotmail.com", "Sanford", "Block" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Gene_Davis@yahoo.com", "Gene", "Davis" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DegreeId",
                table: "Students",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_StudentId",
                table: "Semester",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Semester_Students_StudentId",
                table: "Semester",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Degree_DegreeId",
                table: "Students",
                column: "DegreeId",
                principalTable: "Degree",
                principalColumn: "DegreeId");
        }
    }
}
