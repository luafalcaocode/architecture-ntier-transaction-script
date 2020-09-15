using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class InsertData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "4805e7f5-15eb-4cd1-be77-e30022931d22");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "ebdcb390-af78-4cae-90eb-d41e18ca15ff");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "e742b213-b14a-453e-8f85-af4c1ff579b9");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "ee65a523-8a6d-4e99-a62e-70847cf6e439");

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 29, 21, 52, 41, 309, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 30, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 31, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 1, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 2, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 3, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 4, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 5, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 6, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 7, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 8, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 9, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 10, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 11, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 12, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 13, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17,
                column: "data_publicacao",
                value: new DateTime(2020, 9, 14, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "4805e7f5-15eb-4cd1-be77-e30022931d22", "ec241c7a-244e-401f-971c-04e25f51da8e", "Todos", "TODOS" },
                    { "ebdcb390-af78-4cae-90eb-d41e18ca15ff", "9feb4c92-062c-4ed4-ab7c-064796fa5232", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 21, 52, 41, 314, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 28, 21, 52, 41, 314, DateTimeKind.Local).AddTicks(7229));
        }
    }
}
