using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class nullableofreviewsfromuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_GuestUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Preference_GuestUsers_UserId",
                table: "Preference");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivities_GuestUsers_UserId",
                table: "UserActivities");

            migrationBuilder.DropIndex(
                name: "IX_Preference_UserId",
                table: "Preference");

            migrationBuilder.DropColumn(
                name: "Preferences",
                table: "GuestUsers");

            migrationBuilder.CreateIndex(
                name: "IX_Preference_UserId",
                table: "Preference",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_GuestUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preference_GuestUsers_UserId",
                table: "Preference",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivities_GuestUsers_UserId",
                table: "UserActivities",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_GuestUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Preference_GuestUsers_UserId",
                table: "Preference");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivities_GuestUsers_UserId",
                table: "UserActivities");

            migrationBuilder.DropIndex(
                name: "IX_Preference_UserId",
                table: "Preference");

            migrationBuilder.AddColumn<string>(
                name: "Preferences",
                table: "GuestUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Preference_UserId",
                table: "Preference",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_GuestUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Preference_GuestUsers_UserId",
                table: "Preference",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivities_GuestUsers_UserId",
                table: "UserActivities",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
