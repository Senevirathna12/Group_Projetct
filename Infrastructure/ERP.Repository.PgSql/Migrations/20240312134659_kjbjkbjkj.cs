using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class kjbjkbjkj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Teachers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Naomi.Kautzer56@yahoo.com", "Naomi", "Kautzer", "EG/2023/6965" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Warren34@hotmail.com", "Warren", "Veum", "EG/2023/9028" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Rosamond.Bins88@gmail.com", "Rosamond", "Bins", "EG/2020/9878" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Sabina_Orn@gmail.com", "Sabina", "Orn", "EG/2021/9926" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Vergie_Runolfsson28@gmail.com", "Vergie", "Runolfsson", "EG/2023/1215" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lorenz.Larkin@gmail.com", "Lorenz", "Larkin", "EG/2023/5164" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kendall_Herzog@hotmail.com", "Kendall", "Herzog", "EG/2021/2160" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Birdie86@gmail.com", "Birdie", "Weissnat", "EG/2022/7328" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Marlon65@yahoo.com", "Marlon", "Dietrich", "EG/2021/6024" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jaleel95@yahoo.com", "Jaleel", "Walter", "EG/2022/5587" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Onie.MacGyver@hotmail.com", "Onie", "MacGyver" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Berry.Little31@hotmail.com", "Berry", "Little" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Delphine.Bednar58@gmail.com", "Delphine", "Bednar" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Kendrick.McClure@hotmail.com", "Kendrick", "McClure" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Graciela98@gmail.com", "Graciela", "Goyette" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Bernhard37@gmail.com", "Bernhard", "Fahey" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Imogene_Halvorson@gmail.com", "Imogene", "Halvorson" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Elvera.Toy18@gmail.com", "Elvera", "Toy" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Art28@yahoo.com", "Art", "White" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "", "Betsy57@hotmail.com", "Betsy", "Walter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Teachers");

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

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Mayra10@yahoo.com", "Mayra", "Hammes" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Woodrow_DAmore@hotmail.com", "Woodrow", "D'Amore" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Deontae40@gmail.com", "Deontae", "Kulas" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Jeromy.Huels84@gmail.com", "Jeromy", "Huels" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Damon_Beahan@hotmail.com", "Damon", "Beahan" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Jammie_Mosciski63@hotmail.com", "Jammie", "Mosciski" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Annetta_Hills@yahoo.com", "Annetta", "Hills" });
        }
    }
}
