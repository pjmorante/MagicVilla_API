using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 14, 38, 37, 236, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 14, 38, 37, 237, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 14, 38, 37, 237, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villa_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villa_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 12, 38, 49, 78, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 12, 38, 49, 78, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 12, 38, 49, 78, DateTimeKind.Local).AddTicks(6901));
        }
    }
}
