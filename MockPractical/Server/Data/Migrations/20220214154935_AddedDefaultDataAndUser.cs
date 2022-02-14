using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MockPractical.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DueDate", "IsCompleted", "TaskName" },
                values: new object[] { 1, "Esther Ching", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), false, "Eat frog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
