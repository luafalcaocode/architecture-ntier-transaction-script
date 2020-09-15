using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class NewPostsInserted2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "2ded0b5b-b33d-4a0f-911d-f0d350e845cb");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "457262b3-de6e-4368-a81e-1690407cb577");

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 835, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.InsertData(
                table: "artigo",
                columns: new[] { "id", "aqual_blog_pertence", "data_publicacao", "descricao", "numero_likes", "tags", "titulo" },
                values: new object[,]
                {
                    { 14, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1717), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 15, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1720), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 12, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1710), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 11, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1705), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 10, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1701), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 9, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1696), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 8, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1693), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 13, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 11, 40, 39, 837, DateTimeKind.Local).AddTicks(1714), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15);

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
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 134, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "457262b3-de6e-4368-a81e-1690407cb577", "0e09150a-d7c6-43e5-a639-552666a116da", "Administrador", "ADMINISTRADOR" },
                    { "2ded0b5b-b33d-4a0f-911d-f0d350e845cb", "314ee8b1-69b1-4cac-a5dd-cb985e75baad", "Todos", "TODOS" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 137, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 0, 30, 28, 137, DateTimeKind.Local).AddTicks(8225));
        }
    }
}
