using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "data_publicacao",
                value: new DateTime(2020, 8, 29, 21, 49, 12, 264, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 30, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 31, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 1, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 2, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 3, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 4, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 5, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 6, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 7, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 8, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 9, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 10, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 11, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 12, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 13, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 14, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "2f59fb65-0eba-4c91-8791-aacbd9df99ad", "2a2c06d2-7d8f-41e5-9914-a360bfdd0b2f", "Todos", "TODOS" },
                    { "5359f7e4-6be7-41d3-ab2d-4a21b7e32cfe", "be63a77c-8ea1-4de1-940e-94773fac6757", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 21, 49, 12, 269, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 21, 49, 12, 269, DateTimeKind.Local).AddTicks(5619));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "2f59fb65-0eba-4c91-8791-aacbd9df99ad");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "5359f7e4-6be7-41d3-ab2d-4a21b7e32cfe");

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 78, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 11, 45, 32, 80, DateTimeKind.Local).AddTicks(4889));

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
    }
}
