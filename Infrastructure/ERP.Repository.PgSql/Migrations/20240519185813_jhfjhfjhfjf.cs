using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class jhfjhfjhfjf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deieresults",
                columns: table => new
                {
                    DEIEid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentName = table.Column<string>(type: "text", nullable: false),
                    EE0001 = table.Column<string>(type: "text", nullable: true),
                    EE0002 = table.Column<string>(type: "text", nullable: true),
                    EE0003 = table.Column<string>(type: "text", nullable: true),
                    EE0004 = table.Column<string>(type: "text", nullable: true),
                    EE0005 = table.Column<string>(type: "text", nullable: true),
                    EE0006 = table.Column<string>(type: "text", nullable: true),
                    EE0007 = table.Column<string>(type: "text", nullable: true),
                    EE0008 = table.Column<string>(type: "text", nullable: true),
                    EE0009 = table.Column<string>(type: "text", nullable: true),
                    EE0010 = table.Column<string>(type: "text", nullable: true),
                    EE0011 = table.Column<string>(type: "text", nullable: true),
                    EE0012 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deieresults", x => x.DEIEid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deieresults");
        }
    }
}
