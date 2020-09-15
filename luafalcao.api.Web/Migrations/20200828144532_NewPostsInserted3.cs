using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class NewPostsInserted3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "59757854-a4ab-4b2e-9262-dcc877a88ef6");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "c219c950-a274-4373-a2a5-3f0b9216a1cf");

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 78, DateTimeKind.Local).AddTicks(9477), "Artigo 1" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4772), "Artigo 2" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4850), "Artigo 3" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4854), "Artigo 4" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4857), "Artigo 5" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4860), "Artigo 6" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4862), "Artigo 7" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4865), "Artigo 8" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4867), "Artigo 9" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4870), "Artigo 10" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4872), "Artigo 11" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4875), "Artigo 12" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4878), "Artigo 13" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4880), "Artigo 14" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4882), "Artigo 15" });

            migrationBuilder.InsertData(
                table: "artigo",
                columns: new[] { "id", "aqual_blog_pertence", "data_publicacao", "descricao", "numero_likes", "tags", "titulo" },
                values: new object[,]
                {
                    { 17, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4889), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Artigo 17" },
                    { 16, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4885), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Artigo 16" }
                });

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "e72db08f-cd82-4041-b522-76e43356ad36", "2a1fe63c-c124-486c-bf22-17842f6b6843", "Todos", "TODOS" },
                    { "e74bfb95-d3c2-442d-8fe3-df02fa379d58", "ecd5b011-ed01-41ea-aea8-0ec1ab320d53", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 82, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 82, DateTimeKind.Local).AddTicks(3388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "e72db08f-cd82-4041-b522-76e43356ad36");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "e74bfb95-d3c2-442d-8fe3-df02fa379d58");

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 835, DateTimeKind.Local).AddTicks(3989), "Padrões de Projeto e onde habitam" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1570), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1675), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1680), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1684), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1687), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1690), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1693), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1696), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1701), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1705), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1710), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1714), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1717), "Design Patterns #5: Adapter" });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "data_publicacao", "titulo" },
                values: new object[] { new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1720), "Design Patterns #5: Adapter" });

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "59757854-a4ab-4b2e-9262-dcc877a88ef6", "8704f5d9-b803-4174-b57f-9e7eb9c7c51a", "Todos", "TODOS" },
                    { "c219c950-a274-4373-a2a5-3f0b9216a1cf", "171a9732-83b6-444f-a931-e78f5b019ca4", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 839, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 839, DateTimeKind.Local).AddTicks(4116));
        }
    }
}
