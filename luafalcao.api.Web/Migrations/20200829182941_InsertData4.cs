using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class InsertData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "e742b213-b14a-453e-8f85-af4c1ff579b9");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "ee65a523-8a6d-4e99-a62e-70847cf6e439");

            migrationBuilder.AddColumn<string>(
                name: "thumbnail",
                table: "artigo",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 30, 15, 29, 40, 674, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 31, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 1, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 2, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 3, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 4, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 5, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 6, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 7, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 8, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 9, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 10, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 11, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 12, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 13, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 14, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 15, 15, 29, 40, 677, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "7705cf5c-46a9-4627-9569-cc2b6d99e025", "edb40007-c036-4c07-9dbe-848148b08734", "Todos", "TODOS" },
                    { "27c7adaf-3cce-4460-b189-568c4c6e0f58", "839fbec5-8982-4e70-943d-56707805e68e", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 29, 15, 29, 40, 681, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 29, 15, 29, 40, 681, DateTimeKind.Local).AddTicks(8706));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "27c7adaf-3cce-4460-b189-568c4c6e0f58");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "7705cf5c-46a9-4627-9569-cc2b6d99e025");

            migrationBuilder.DropColumn(
                name: "thumbnail",
                table: "artigo");

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 29, 23, 25, 14, 528, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 30, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 31, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 1, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 2, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 3, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 4, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 5, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 6, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 7, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 8, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 9, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 10, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 11, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 12, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 13, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 14, 23, 25, 14, 531, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "ee65a523-8a6d-4e99-a62e-70847cf6e439", "5a92604c-b012-41a2-97e6-a9c5ed241d7d", "Todos", "TODOS" },
                    { "e742b213-b14a-453e-8f85-af4c1ff579b9", "f1fd8ee7-b787-4da1-87d4-5a379d98f3ff", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 23, 25, 14, 533, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 23, 25, 14, 534, DateTimeKind.Local).AddTicks(1607));
        }
    }
}
