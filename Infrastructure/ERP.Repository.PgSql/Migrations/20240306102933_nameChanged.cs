using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class nameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_modules_Teachers_teacherId",
                table: "modules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_modules",
                table: "modules");

            migrationBuilder.RenameTable(
                name: "modules",
                newName: "Newmodules");

            migrationBuilder.RenameIndex(
                name: "IX_modules_teacherId",
                table: "Newmodules",
                newName: "IX_Newmodules_teacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Newmodules",
                table: "Newmodules",
                column: "ModuleId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kim_Gaylord77@hotmail.com", "Kim", "Gaylord", "EG/2021/1930" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Zena.Kling@hotmail.com", "Zena", "Kling", "EG/2021/2359" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Tristin50@yahoo.com", "Tristin", "Bauch", "EG/2022/2502" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kacie_Smitham21@yahoo.com", "Kacie", "Smitham", "EG/2021/7062" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kiley53@hotmail.com", "Kiley", "Kuhlman", "EG/2021/7192" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Elda49@gmail.com", "Elda", "Zulauf", "EG/2020/4265" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Godfrey79@gmail.com", "Godfrey", "O'Hara", "EG/2021/2192" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Maria2@gmail.com", "Maria", "Jacobs", "EG/2021/5800" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hans_Spinka@gmail.com", "Hans", "Spinka", "EG/2022/5972" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lottie24@yahoo.com", "Lottie", "O'Keefe", "EG/2022/5983" });

            migrationBuilder.AddForeignKey(
                name: "FK_Newmodules_Teachers_teacherId",
                table: "Newmodules",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newmodules_Teachers_teacherId",
                table: "Newmodules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Newmodules",
                table: "Newmodules");

            migrationBuilder.RenameTable(
                name: "Newmodules",
                newName: "modules");

            migrationBuilder.RenameIndex(
                name: "IX_Newmodules_teacherId",
                table: "modules",
                newName: "IX_modules_teacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_modules",
                table: "modules",
                column: "ModuleId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Nathanial.Boyer18@hotmail.com", "Nathanial", "Boyer", "EG/2023/1087" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Aglae.Wyman@hotmail.com", "Aglae", "Wyman", "EG/2021/2335" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Sierra88@yahoo.com", "Sierra", "Price", "EG/2023/3962" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Raymundo_Farrell@hotmail.com", "Raymundo", "Farrell", "EG/2020/8437" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Silas.Dicki2@hotmail.com", "Silas", "Dicki", "EG/2022/3817" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Enos.Langosh@hotmail.com", "Enos", "Langosh", "EG/2023/5364" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Zoe_Hoppe37@yahoo.com", "Zoe", "Hoppe", "EG/2020/4569" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Tillman_Moore36@yahoo.com", "Tillman", "Moore", "EG/2022/3348" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Oren.Lubowitz37@hotmail.com", "Oren", "Lubowitz", "EG/2020/2179" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Gisselle.Corwin83@yahoo.com", "Gisselle", "Corwin", "EG/2021/5287" });

            migrationBuilder.AddForeignKey(
                name: "FK_modules_Teachers_teacherId",
                table: "modules",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
