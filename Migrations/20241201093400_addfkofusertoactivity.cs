using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class addfkofusertoactivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Act_Userid_fk",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Users_UserId",
                table: "Activities_Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_GuestUsers_UserId",
                table: "Activities_Users",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_GuestUsers_UserId",
                table: "Activities_Users");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Users_UserId",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "Act_Userid_fk",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Activities_Users");
        }
    }
}
