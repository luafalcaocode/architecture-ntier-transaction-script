using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class RemovingPropertyByte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "0ddb7e6c-089f-4bf8-9481-f60afcfebf18");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "cc01cc58-24f8-4461-b3fa-8369c1b9557d");

            migrationBuilder.DropColumn(
                name: "thumbnail",
                table: "artigo");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "405475b9-5957-455c-af79-79e44877fe01");

            migrationBuilder.DeleteData(
                table: "asp_net_roles",
                keyColumn: "id",
                keyValue: "8e44290b-5b52-42f4-9c57-395be1f8ada0");

            migrationBuilder.AddColumn<byte[]>(
                name: "thumbnail",
                table: "artigo",
                type: "bytea",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "data_publicacao", "thumbnail" },
                values: new object[] { new DateTime(2020, 8, 26, 10, 8, 5, 510, DateTimeKind.Local).AddTicks(3383), new byte[] {  } });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "data_publicacao", "thumbnail" },
                values: new object[] { new DateTime(2020, 8, 26, 10, 8, 5, 512, DateTimeKind.Local).AddTicks(276), new byte[] {  } });

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "cc01cc58-24f8-4461-b3fa-8369c1b9557d", "1f13b321-5941-48fe-887a-4f866c9ff9bd", "Administrador", "ADMINISTRADOR" },
                    { "0ddb7e6c-089f-4bf8-9481-f60afcfebf18", "aaeceb9a-5948-4944-b774-8012da13ae47", "Todos", "TODOS" }
                });

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 1,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 26, 10, 8, 5, 513, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "comentario",
                keyColumn: "id",
                keyValue: 2,
                column: "data_publicacao",
                value: new DateTime(2020, 8, 26, 10, 8, 5, 514, DateTimeKind.Local).AddTicks(107));
        }
    }
}
