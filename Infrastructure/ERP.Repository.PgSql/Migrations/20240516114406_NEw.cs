using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class NEw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_Teachers_TeacherId",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_Teachers_TeacherId",
                table: "ModuleSecondExaminers");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId1",
                table: "ModuleSecondExaminers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId1",
                table: "ModuleFirstExaminers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Amely_Koelpin@yahoo.com", "Amely", "Koelpin", "EG/2022/4998" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Veda29@yahoo.com", "Veda", "Boehm", "EG/2023/1999" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Marvin.Swaniawski98@hotmail.com", "Marvin", "Swaniawski", "EG/2020/9485" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hillard73@hotmail.com", "Hillard", "Mante", "EG/2023/6892" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Berry.Gulgowski@yahoo.com", "Berry", "Gulgowski", "EG/2022/3428" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Caleb_Boyer@gmail.com", "Caleb", "Boyer", "EG/2020/4102" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Susie64@yahoo.com", "Susie", "Schmidt", "EG/2020/1127" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Harold89@hotmail.com", "Harold", "Morar", "EG/2020/7729" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Sierra4@yahoo.com", "Sierra", "McCullough", "EG/2020/3811" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jewel_Lemke46@gmail.com", "Jewel", "Lemke", "EG/2020/1921" });

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
                name: "IX_ModuleSecondExaminers_TeacherId1",
                table: "ModuleSecondExaminers",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleFirstExaminers_TeacherId1",
                table: "ModuleFirstExaminers",
                column: "TeacherId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_Teachers_TeacherId1",
                table: "ModuleFirstExaminers",
                column: "TeacherId1",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleSecondExaminers_Teachers_TeacherId1",
                table: "ModuleSecondExaminers",
                column: "TeacherId1",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_Teachers_TeacherId1",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_Teachers_TeacherId1",
                table: "ModuleSecondExaminers");

            migrationBuilder.DropIndex(
                name: "IX_ModuleSecondExaminers_TeacherId1",
                table: "ModuleSecondExaminers");

            migrationBuilder.DropIndex(
                name: "IX_ModuleFirstExaminers_TeacherId1",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropColumn(
                name: "TeacherId1",
                table: "ModuleSecondExaminers");

            migrationBuilder.DropColumn(
                name: "TeacherId1",
                table: "ModuleFirstExaminers");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Maci_Mills@hotmail.com", "Maci", "Mills", "EG/2021/8827" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kassandra4@hotmail.com", "Kassandra", "Rippin", "EG/2023/8041" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Shayna30@yahoo.com", "Shayna", "Dach", "EG/2021/5872" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Beaulah.Ankunding@yahoo.com", "Beaulah", "Ankunding", "EG/2023/3250" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Myriam38@yahoo.com", "Myriam", "Kris", "EG/2020/5624" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Katherine_Kunde@gmail.com", "Katherine", "Kunde", "EG/2021/8104" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Marjolaine32@gmail.com", "Marjolaine", "Ankunding", "EG/2021/8326" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alvera.Lubowitz@hotmail.com", "Alvera", "Lubowitz", "EG/2023/3638" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Carol.Terry2@hotmail.com", "Carol", "Terry", "EG/2022/8373" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Demarco29@hotmail.com", "Demarco", "Turner", "EG/2023/7535" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Chaim24@yahoo.com", "Chaim", "Casper" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Woodrow27@yahoo.com", "Woodrow", "Carroll" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Maryam_Connelly97@gmail.com", "Maryam", "Connelly" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Lue_Sauer@yahoo.com", "Lue", "Sauer" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Jaclyn_Lemke@yahoo.com", "Jaclyn", "Lemke" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Dorothy.Halvorson77@yahoo.com", "Dorothy", "Halvorson" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Sabrina.King6@hotmail.com", "Sabrina", "King" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Sheila.Kshlerin@gmail.com", "Sheila", "Kshlerin" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Maximillian_Sawayn@hotmail.com", "Maximillian", "Sawayn" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Tania47@hotmail.com", "Tania", "Rohan" });

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_Teachers_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleSecondExaminers_Teachers_TeacherId",
                table: "ModuleSecondExaminers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
