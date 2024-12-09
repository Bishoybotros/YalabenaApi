using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_GuestUsers_UserId",
                table: "Activities_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_Itineraries_ItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Itineraries_GuestUsers_UserId",
                table: "Itineraries");

            migrationBuilder.DropForeignKey(
                name: "FK_Preferences_Users_GuestUsers_UserId",
                table: "Preferences_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Transportations_Preferences_Users_PreferencePrre_Id",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Transportations_PreferencePrre_Id",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Preferences_Users_UserId",
                table: "Preferences_Users");

            migrationBuilder.DropIndex(
                name: "IX_Itineraries_UserId",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Preferences_Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Itineraries");

            migrationBuilder.RenameColumn(
                name: "PreferencePrre_Id",
                table: "Transportations",
                newName: "Trans_activity_Fk");

            migrationBuilder.RenameColumn(
                name: "Act_Pref_Fk",
                table: "Transportations",
                newName: "Trans_Pref_Fk");

            migrationBuilder.AddColumn<int>(
                name: "Activity_Id",
                table: "Transportations",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Activities_Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItineraryID",
                table: "Activities_Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_Activity_Id",
                table: "Transportations",
                column: "Activity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_Trans_Pref_Fk",
                table: "Transportations",
                column: "Trans_Pref_Fk");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_Users_P_userid_fk",
                table: "Preferences_Users",
                column: "P_userid_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Itineraries_I_Userid_fk",
                table: "Itineraries",
                column: "I_Userid_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_GuestUsers_UserId",
                table: "Activities_Users",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_Itineraries_ItineraryID",
                table: "Activities_Users",
                column: "ItineraryID",
                principalTable: "Itineraries",
                principalColumn: "ItineraryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Itineraries_GuestUsers_I_Userid_fk",
                table: "Itineraries",
                column: "I_Userid_fk",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Users_GuestUsers_P_userid_fk",
                table: "Preferences_Users",
                column: "P_userid_fk",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportations_Activities_Users_Activity_Id",
                table: "Transportations",
                column: "Activity_Id",
                principalTable: "Activities_Users",
                principalColumn: "Activity_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transportations_Preferences_Users_Trans_Pref_Fk",
                table: "Transportations",
                column: "Trans_Pref_Fk",
                principalTable: "Preferences_Users",
                principalColumn: "Prre_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_GuestUsers_UserId",
                table: "Activities_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_Itineraries_ItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Itineraries_GuestUsers_I_Userid_fk",
                table: "Itineraries");

            migrationBuilder.DropForeignKey(
                name: "FK_Preferences_Users_GuestUsers_P_userid_fk",
                table: "Preferences_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Transportations_Activities_Users_Activity_Id",
                table: "Transportations");

            migrationBuilder.DropForeignKey(
                name: "FK_Transportations_Preferences_Users_Trans_Pref_Fk",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Transportations_Activity_Id",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Transportations_Trans_Pref_Fk",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Preferences_Users_P_userid_fk",
                table: "Preferences_Users");

            migrationBuilder.DropIndex(
                name: "IX_Itineraries_I_Userid_fk",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "Activity_Id",
                table: "Transportations");

            migrationBuilder.RenameColumn(
                name: "Trans_activity_Fk",
                table: "Transportations",
                newName: "PreferencePrre_Id");

            migrationBuilder.RenameColumn(
                name: "Trans_Pref_Fk",
                table: "Transportations",
                newName: "Act_Pref_Fk");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Preferences_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Itineraries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItineraryID",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_PreferencePrre_Id",
                table: "Transportations",
                column: "PreferencePrre_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_Users_UserId",
                table: "Preferences_Users",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Itineraries_UserId",
                table: "Itineraries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_GuestUsers_UserId",
                table: "Activities_Users",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_Itineraries_ItineraryID",
                table: "Activities_Users",
                column: "ItineraryID",
                principalTable: "Itineraries",
                principalColumn: "ItineraryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Itineraries_GuestUsers_UserId",
                table: "Itineraries",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Users_GuestUsers_UserId",
                table: "Preferences_Users",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportations_Preferences_Users_PreferencePrre_Id",
                table: "Transportations",
                column: "PreferencePrre_Id",
                principalTable: "Preferences_Users",
                principalColumn: "Prre_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
