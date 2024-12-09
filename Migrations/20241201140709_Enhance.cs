using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class Enhance : Migration
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
                name: "FK_Bookings_GuestUsers_B_Userid_fk",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Itineraries_B_Itineraryid_fk",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_PaymentMethods_B_PaymentMethodId",
                table: "Bookings");

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

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_Activities_Users_Rev_activity_fk",
                table: "UsersReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_GuestUsers_Rev_userid_fk",
                table: "UsersReviews");

            migrationBuilder.DropIndex(
                name: "IX_Transportations_Activity_Id",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Users_ItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Users_UserId",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "Activity_Id",
                table: "Transportations");

            migrationBuilder.DropColumn(
                name: "ItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Activities_Users");

            migrationBuilder.RenameColumn(
                name: "Rev_userid_fk",
                table: "UsersReviews",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Rev_activity_fk",
                table: "UsersReviews",
                newName: "Activity_Id");

            migrationBuilder.RenameIndex(
                name: "IX_UsersReviews_Rev_userid_fk",
                table: "UsersReviews",
                newName: "IX_UsersReviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersReviews_Rev_activity_fk",
                table: "UsersReviews",
                newName: "IX_UsersReviews_Activity_Id");

            migrationBuilder.RenameColumn(
                name: "Trans_activity_Fk",
                table: "Transportations",
                newName: "PreferencesPrre_Id");

            migrationBuilder.RenameColumn(
                name: "Trans_Pref_Fk",
                table: "Transportations",
                newName: "ActivitiesActivity_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Transportations_Trans_Pref_Fk",
                table: "Transportations",
                newName: "IX_Transportations_ActivitiesActivity_Id");

            migrationBuilder.RenameColumn(
                name: "P_userid_fk",
                table: "Preferences_Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Preferences_Users_P_userid_fk",
                table: "Preferences_Users",
                newName: "IX_Preferences_Users_UserId");

            migrationBuilder.RenameColumn(
                name: "I_Userid_fk",
                table: "Itineraries",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Itineraries_I_Userid_fk",
                table: "Itineraries",
                newName: "IX_Itineraries_UserId");

            migrationBuilder.RenameColumn(
                name: "B_Userid_fk",
                table: "Bookings",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "B_PaymentMethodId",
                table: "Bookings",
                newName: "PaymentMethodPayment_Id");

            migrationBuilder.RenameColumn(
                name: "B_Itineraryid_fk",
                table: "Bookings",
                newName: "ItineraryID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_B_Userid_fk",
                table: "Bookings",
                newName: "IX_Bookings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_B_PaymentMethodId",
                table: "Bookings",
                newName: "IX_Bookings_PaymentMethodPayment_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_B_Itineraryid_fk",
                table: "Bookings",
                newName: "IX_Bookings_ItineraryID");

            migrationBuilder.AddColumn<int>(
                name: "ItinerariesItineraryID",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_PreferencesPrre_Id",
                table: "Transportations",
                column: "PreferencesPrre_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Users_ItinerariesItineraryID",
                table: "Activities_Users",
                column: "ItinerariesItineraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Users_UsersUserId",
                table: "Activities_Users",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_GuestUsers_UsersUserId",
                table: "Activities_Users",
                column: "UsersUserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_Itineraries_ItinerariesItineraryID",
                table: "Activities_Users",
                column: "ItinerariesItineraryID",
                principalTable: "Itineraries",
                principalColumn: "ItineraryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_GuestUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Itineraries_ItineraryID",
                table: "Bookings",
                column: "ItineraryID",
                principalTable: "Itineraries",
                principalColumn: "ItineraryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_PaymentMethods_PaymentMethodPayment_Id",
                table: "Bookings",
                column: "PaymentMethodPayment_Id",
                principalTable: "PaymentMethods",
                principalColumn: "Payment_Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Itineraries_GuestUsers_UserId",
                table: "Itineraries",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Users_GuestUsers_UserId",
                table: "Preferences_Users",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportations_Activities_Users_ActivitiesActivity_Id",
                table: "Transportations",
                column: "ActivitiesActivity_Id",
                principalTable: "Activities_Users",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportations_Preferences_Users_PreferencesPrre_Id",
                table: "Transportations",
                column: "PreferencesPrre_Id",
                principalTable: "Preferences_Users",
                principalColumn: "Prre_Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_Activities_Users_Activity_Id",
                table: "UsersReviews",
                column: "Activity_Id",
                principalTable: "Activities_Users",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_GuestUsers_UserId",
                table: "UsersReviews",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_GuestUsers_UsersUserId",
                table: "Activities_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_Itineraries_ItinerariesItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_GuestUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Itineraries_ItineraryID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_PaymentMethods_PaymentMethodPayment_Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Itineraries_GuestUsers_UserId",
                table: "Itineraries");

            migrationBuilder.DropForeignKey(
                name: "FK_Preferences_Users_GuestUsers_UserId",
                table: "Preferences_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Transportations_Activities_Users_ActivitiesActivity_Id",
                table: "Transportations");

            migrationBuilder.DropForeignKey(
                name: "FK_Transportations_Preferences_Users_PreferencesPrre_Id",
                table: "Transportations");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_Activities_Users_Activity_Id",
                table: "UsersReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_GuestUsers_UserId",
                table: "UsersReviews");

            migrationBuilder.DropIndex(
                name: "IX_Transportations_PreferencesPrre_Id",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Users_ItinerariesItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Users_UsersUserId",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "ItinerariesItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Activities_Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UsersReviews",
                newName: "Rev_userid_fk");

            migrationBuilder.RenameColumn(
                name: "Activity_Id",
                table: "UsersReviews",
                newName: "Rev_activity_fk");

            migrationBuilder.RenameIndex(
                name: "IX_UsersReviews_UserId",
                table: "UsersReviews",
                newName: "IX_UsersReviews_Rev_userid_fk");

            migrationBuilder.RenameIndex(
                name: "IX_UsersReviews_Activity_Id",
                table: "UsersReviews",
                newName: "IX_UsersReviews_Rev_activity_fk");

            migrationBuilder.RenameColumn(
                name: "PreferencesPrre_Id",
                table: "Transportations",
                newName: "Trans_activity_Fk");

            migrationBuilder.RenameColumn(
                name: "ActivitiesActivity_Id",
                table: "Transportations",
                newName: "Trans_Pref_Fk");

            migrationBuilder.RenameIndex(
                name: "IX_Transportations_ActivitiesActivity_Id",
                table: "Transportations",
                newName: "IX_Transportations_Trans_Pref_Fk");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Preferences_Users",
                newName: "P_userid_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Preferences_Users_UserId",
                table: "Preferences_Users",
                newName: "IX_Preferences_Users_P_userid_fk");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Itineraries",
                newName: "I_Userid_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Itineraries_UserId",
                table: "Itineraries",
                newName: "IX_Itineraries_I_Userid_fk");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Bookings",
                newName: "B_Userid_fk");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodPayment_Id",
                table: "Bookings",
                newName: "B_PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "ItineraryID",
                table: "Bookings",
                newName: "B_Itineraryid_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                newName: "IX_Bookings_B_Userid_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_PaymentMethodPayment_Id",
                table: "Bookings",
                newName: "IX_Bookings_B_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_ItineraryID",
                table: "Bookings",
                newName: "IX_Bookings_B_Itineraryid_fk");

            migrationBuilder.AddColumn<int>(
                name: "Activity_Id",
                table: "Transportations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItineraryID",
                table: "Activities_Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Activities_Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_Activity_Id",
                table: "Transportations",
                column: "Activity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Users_ItineraryID",
                table: "Activities_Users",
                column: "ItineraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Users_UserId",
                table: "Activities_Users",
                column: "UserId");

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
                name: "FK_Bookings_GuestUsers_B_Userid_fk",
                table: "Bookings",
                column: "B_Userid_fk",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Itineraries_B_Itineraryid_fk",
                table: "Bookings",
                column: "B_Itineraryid_fk",
                principalTable: "Itineraries",
                principalColumn: "ItineraryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_PaymentMethods_B_PaymentMethodId",
                table: "Bookings",
                column: "B_PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Payment_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Itineraries_GuestUsers_I_Userid_fk",
                table: "Itineraries",
                column: "I_Userid_fk",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Users_GuestUsers_P_userid_fk",
                table: "Preferences_Users",
                column: "P_userid_fk",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.SetNull);

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
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_Activities_Users_Rev_activity_fk",
                table: "UsersReviews",
                column: "Rev_activity_fk",
                principalTable: "Activities_Users",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_GuestUsers_Rev_userid_fk",
                table: "UsersReviews",
                column: "Rev_userid_fk",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
