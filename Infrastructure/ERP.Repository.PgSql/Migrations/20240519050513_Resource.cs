using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class Resource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ResourceId);
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 4445, "Officia est odio eum ratione corrupti. Ratione sed quos et dolores facilis cum voluptatem quaerat. Unde dolor commodi nesciunt voluptas et sed dolorum.", "Eos nam eaque.", 0 },
                    { 4446, "Voluptates sequi consectetur aliquam explicabo nemo. A non dolor voluptatibus enim eum aut sunt temporibus. Ratione et expedita ea alias debitis minima qui maxime temporibus. Voluptas et odio.", "Rerum sit dolor explicabo.", 1 },
                    { 4447, "Dolorum eveniet facilis eum incidunt enim non dolor laborum. Temporibus reprehenderit non suscipit et magni. Exercitationem nobis fugit.", "Culpa sunt sunt odit blanditiis dolor odio facere dicta minus.", 2 },
                    { 4448, "Omnis eius quisquam voluptas et tempore. Pariatur aut et omnis atque. Fugit ut veritatis quia voluptate iusto dolores exercitationem consequuntur totam. Sunt odit mollitia deserunt quod rem cum doloribus.", "Excepturi vel modi cum illo.", 2 },
                    { 4449, "Magnam cupiditate cupiditate repellat. Sit rem quibusdam accusantium. Est quo quibusdam molestiae perferendis.", "Eum commodi ab inventore.", 0 },
                    { 4450, "Assumenda asperiores voluptas enim quasi vel est. Sunt nesciunt quia doloribus ut aspernatur sapiente aperiam. Recusandae deleniti odio in dolores eligendi deserunt. Ipsum perferendis eum. Velit alias sapiente possimus est ullam minus ea et.", "Sed minima numquam vitae ut.", 0 },
                    { 4451, "Hic nihil officia fuga minus ullam eos. Qui dolor corrupti quasi dolorum rerum. Quia libero architecto veniam. Voluptatem qui velit et consequatur deserunt eaque consequuntur quam. Sed fugiat vel est laborum. Porro voluptatem error illo eaque odit eveniet nemo.", "Molestiae sint quis qui voluptatum quis.", 1 },
                    { 4452, "Sunt eligendi deserunt est sed reprehenderit similique. At recusandae beatae accusantium porro cumque quasi perspiciatis voluptas eius. Labore porro hic corrupti quia qui at libero vel. Eum molestias alias possimus nihil consequatur iure suscipit. Aut est esse eos error qui esse eligendi.", "Non quo eius.", 2 },
                    { 4453, "Fuga accusamus quas voluptatem ullam ut sint ex quaerat. Aut eaque culpa recusandae debitis omnis asperiores ipsa provident. Est consequuntur et optio maxime voluptatibus ducimus.", "Eum laborum ex mollitia sit enim ut qui.", 1 },
                    { 4454, "Ullam sit temporibus et id expedita sed. Similique officia mollitia sed quae sint dolore aut. Adipisci aut cumque vitae vel vel velit omnis fugit.", "Ex aut aut ut autem unde corporis omnis.", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hadley.Bahringer@hotmail.com", "Hadley", "Bahringer", "EG/2022/2498" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Katarina_Legros@yahoo.com", "Katarina", "Legros", "EG/2020/3490" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Arch_Lowe18@gmail.com", "Arch", "Lowe", "EG/2020/4270" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Carmela0@gmail.com", "Carmela", "Gerhold", "EG/2021/2045" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Karl_Littel@gmail.com", "Karl", "Littel", "EG/2021/2553" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mateo.Lang@hotmail.com", "Mateo", "Lang", "EG/2023/4263" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Desmond.Schmeler5@yahoo.com", "Desmond", "Schmeler", "EG/2021/3125" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Aaliyah5@hotmail.com", "Aaliyah", "Zieme", "EG/2022/3097" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Daija.Skiles67@yahoo.com", "Daija", "Skiles", "EG/2021/2581" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Linnie_Lynch@hotmail.com", "Linnie", "Lynch", "EG/2022/3554" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Rowland41@gmail.com", "Rowland", "Hilll" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Augustine.Cassin@gmail.com", "Augustine", "Cassin" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Eloisa.Zemlak@hotmail.com", "Eloisa", "Zemlak" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Clemens8@hotmail.com", "Clemens", "Luettgen" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Meredith74@yahoo.com", "Meredith", "Kerluke" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Darian.Toy13@yahoo.com", "Darian", "Toy" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Makenna.Deckow20@yahoo.com", "Makenna", "Deckow" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Blanche.Stark69@hotmail.com", "Blanche", "Stark" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Donnie.Hyatt25@gmail.com", "Donnie", "Hyatt" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Breanne76@gmail.com", "Breanne", "Doyle" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Brant.Bruen19@hotmail.com", "Brant", "Bruen", "EG/2022/3058" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Fae34@hotmail.com", "Fae", "Nicolas", "EG/2020/4682" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Julien50@gmail.com", "Julien", "Balistreri", "EG/2020/2293" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Salma.Kiehn@gmail.com", "Salma", "Kiehn", "EG/2020/3541" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Dexter.Lueilwitz@gmail.com", "Dexter", "Lueilwitz", "EG/2022/2685" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Bradford.Ortiz64@gmail.com", "Bradford", "Ortiz", "EG/2022/2869" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Madisyn50@yahoo.com", "Madisyn", "Wyman", "EG/2021/3768" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Juana55@hotmail.com", "Juana", "Tromp", "EG/2023/3308" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Rosalyn.Howe@yahoo.com", "Rosalyn", "Howe", "EG/2021/4451" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Yvonne31@yahoo.com", "Yvonne", "Haley", "EG/2021/3186" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Gerhard93@gmail.com", "Gerhard", "Leannon" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Ervin.Bergstrom@yahoo.com", "Ervin", "Bergstrom" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Bernardo_Orn@hotmail.com", "Bernardo", "Orn" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Arvel48@hotmail.com", "Arvel", "Adams" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Gerson_Wintheiser15@hotmail.com", "Gerson", "Wintheiser" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Daryl_Turcotte37@gmail.com", "Daryl", "Turcotte" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Cecile.Goldner26@gmail.com", "Cecile", "Goldner" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Missouri10@gmail.com", "Missouri", "Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Delmer66@gmail.com", "Delmer", "Hartmann" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Jewel.Kreiger68@gmail.com", "Jewel", "Kreiger" });
        }
    }
}
