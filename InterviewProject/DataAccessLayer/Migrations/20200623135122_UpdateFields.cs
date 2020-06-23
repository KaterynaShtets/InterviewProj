using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InterviewProject.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Grade_GradeId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Positions_PositionId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Rooms_RoomId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Technologies_TechnologyId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_InterviewUsers_Interviews_InterviewId",
                table: "InterviewUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_InterviewUsers_Users_UserId",
                table: "InterviewUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_InterviewUsers_InterviewId",
                table: "InterviewUsers");

            migrationBuilder.DropIndex(
                name: "IX_InterviewUsers_UserId",
                table: "InterviewUsers");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_GradeId",
                table: "Interviews");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_PositionId",
                table: "Interviews");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_RoomId",
                table: "Interviews");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_TechnologyId",
                table: "Interviews");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Floor",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "Rooms");

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GradeTitle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewUsers_InterviewId",
                table: "InterviewUsers",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewUsers_UserId",
                table: "InterviewUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_GradeId",
                table: "Interviews",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_PositionId",
                table: "Interviews",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_RoomId",
                table: "Interviews",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_TechnologyId",
                table: "Interviews",
                column: "TechnologyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Grade_GradeId",
                table: "Interviews",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Positions_PositionId",
                table: "Interviews",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Rooms_RoomId",
                table: "Interviews",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Technologies_TechnologyId",
                table: "Interviews",
                column: "TechnologyId",
                principalTable: "Technologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InterviewUsers_Interviews_InterviewId",
                table: "InterviewUsers",
                column: "InterviewId",
                principalTable: "Interviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InterviewUsers_Users_UserId",
                table: "InterviewUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
