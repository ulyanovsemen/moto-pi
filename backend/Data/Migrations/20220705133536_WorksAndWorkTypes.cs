using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    public partial class WorksAndWorkTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "work_types",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false, comment: "Наименование")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_work_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "works",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    work_type_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false, comment: "Наименование")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_works", x => x.id);
                    table.ForeignKey(
                        name: "fk_works_work_types_work_type_id",
                        column: x => x.work_type_id,
                        principalTable: "work_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "work_types",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1L, "Подвеска" },
                    { 2L, "Двигатель" }
                });

            migrationBuilder.InsertData(
                table: "works",
                columns: new[] { "id", "name", "work_type_id" },
                values: new object[,]
                {
                    { 1L, "Замена стойки амортизатора", 1L },
                    { 2L, "Замена пружины", 1L },
                    { 3L, "Замена масла", 2L }
                });

            migrationBuilder.CreateIndex(
                name: "ix_works_work_type_id",
                table: "works",
                column: "work_type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "works");

            migrationBuilder.DropTable(
                name: "work_types");
        }
    }
}
