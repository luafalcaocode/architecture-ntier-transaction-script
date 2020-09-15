using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class NewPostsInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "405475b9-5957-455c-af79-79e44877fe01");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "8e44290b-5b52-42f4-9c57-395be1f8ada0");

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

            migrationBuilder.InsertData(
                table: "artigo",
                columns: new[] { "id", "aqual_blog_pertence", "data_publicacao", "descricao", "numero_likes", "tags", "titulo" },
                values: new object[,]
                {
                    { 3, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8766), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 4, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8770), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 5, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8772), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 6, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8775), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" },
                    { 7, "DiarioEngenheiroSoftware", new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8959), "Lorem ipsum....", 5, new[] { "Engenharia de Software", "Design Patterns", "Programação" }, "Design Patterns #5: Adapter" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7);

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
                value: new DateTime(2020, 8, 26, 10, 16, 42, 69, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 26, 10, 16, 42, 71, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "8e44290b-5b52-42f4-9c57-395be1f8ada0", "19ceb1b4-2f0e-4bae-80f8-b30a7e57dbd6", "Administrador", "ADMINISTRADOR" },
                    { "405475b9-5957-455c-af79-79e44877fe01", "cdc708fa-85d5-4495-bb4d-a85a1ff2f685", "Todos", "TODOS" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 26, 10, 16, 42, 73, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 26, 10, 16, 42, 73, DateTimeKind.Local).AddTicks(8045));
        }
    }
}
