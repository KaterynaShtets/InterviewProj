using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewProject.Migrations
{
    public partial class AddDataToInterviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interviews",
                columns: new[] { "Id", "DateTime", "GradeId", "PositionId", "RoomId", "TechnologyId" },
                values: new object[] { 1, new DateTime(2020, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
