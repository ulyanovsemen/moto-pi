using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "part_types",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false, comment: "Наименование")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_part_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parts",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    part_type_id = table.Column<long>(type: "bigint", nullable: false),
                    model = table.Column<string>(type: "text", nullable: true),
                    number = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: false, comment: "Наименование")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parts", x => x.id);
                    table.ForeignKey(
                        name: "fk_parts_part_types_part_type_id",
                        column: x => x.part_type_id,
                        principalTable: "part_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "part_types",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1L, "Подвеска" },
                    { 2L, "Двигатель" }
                });

            migrationBuilder.InsertData(
                table: "parts",
                columns: new[] { "id", "model", "name", "number", "part_type_id" },
                values: new object[,]
                {
                    { 1L, "BMW", "Стойка амортизатора", "12345QWE", 1L },
                    { 2L, "BMW", "Пружина", "ZXC123", 1L },
                    { 3L, "Bosh", "Поршень", "ZXC123", 2L }
                });

            migrationBuilder.CreateIndex(
                name: "ix_parts_part_type_id",
                table: "parts",
                column: "part_type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "parts");

            migrationBuilder.DropTable(
                name: "part_types");
        }
    }
}
