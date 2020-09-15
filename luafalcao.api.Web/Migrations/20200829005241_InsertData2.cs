using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class InsertData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 8, 29, 21, 52, 41, 309, DateTimeKind.Local).AddTicks(3673), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 8, 30, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(7885), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 8, 31, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8240), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 1, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8250), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 2, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8259), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 3, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8263), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 4, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8267), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 5, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8275), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 6, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8279), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 7, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8283), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 8, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8288), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 9, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8292), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 10, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8296), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 11, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8300), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 12, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8304), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 13, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8308), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 14, 21, 52, 41, 311, DateTimeKind.Local).AddTicks(8312), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit.." });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 8, 29, 21, 49, 12, 264, DateTimeKind.Local).AddTicks(9556), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 8, 30, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(226), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 8, 31, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(345), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 1, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(352), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 2, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(357), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 3, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(361), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 4, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(365), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 5, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(369), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 6, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(375), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 7, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(379), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 8, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(383), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 9, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(388), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 10, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(393), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 11, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(396), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 12, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(402), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 13, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(407), "Lorem ipsum...." });

            migrationBuilder.UpdateData(
                table: "artigo",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "data_publicacao", "descricao" },
                values: new object[] { new DateTime(2020, 9, 14, 21, 49, 12, 267, DateTimeKind.Local).AddTicks(412), "Lorem ipsum...." });

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
    }
}
