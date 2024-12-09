using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationAndPasswordToAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "GuestUsers");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "GuestUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GuestUsers_AccountId",
                table: "GuestUsers",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_GuestUsers_Accounts_AccountId",
                table: "GuestUsers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuestUsers_Accounts_AccountId",
                table: "GuestUsers");

            migrationBuilder.DropIndex(
                name: "IX_GuestUsers_AccountId",
                table: "GuestUsers");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "GuestUsers");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "GuestUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
