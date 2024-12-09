using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class updateschemasandrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_GuestUsers_UsersUserId",
                table: "Activities_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_Itineraries_ItinerariesItineraryID",
                table: "Activities_Users");

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

            migrationBuilder.DropIndex(
                name: "IX_Transportations_ActivitiesActivity_Id",
                table: "Transportations");

            migrationBuilder.DropIndex(
                name: "IX_Transportations_PreferencesPrre_Id",
                table: "Transportations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preferences_Users",
                table: "Preferences_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities_Users",
                table: "Activities_Users");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Users_ItinerariesItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Users_UsersUserId",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "ActivitiesActivity_Id",
                table: "Transportations");

            migrationBuilder.DropColumn(
                name: "PreferencesPrre_Id",
                table: "Transportations");

            migrationBuilder.DropColumn(
                name: "ItinerariesItineraryID",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Activities_Users");

            migrationBuilder.RenameTable(
                name: "Preferences_Users",
                newName: "Preference");

            migrationBuilder.RenameTable(
                name: "Activities_Users",
                newName: "Activities");

            migrationBuilder.RenameIndex(
                name: "IX_Preferences_Users_UserId",
                table: "Preference",
                newName: "IX_Preference_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preference",
                table: "Preference",
                column: "Prre_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "Activity_Id");

            migrationBuilder.CreateTable(
                name: "ActivityTransportations",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    TransportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTransportations", x => new { x.ActivityId, x.TransportId });
                    table.ForeignKey(
                        name: "FK_ActivityTransportations_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Activity_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityTransportations_Transportations_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transportations",
                        principalColumn: "Transport_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodPayment_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodPayment_Id",
                        column: x => x.PaymentMethodPayment_Id,
                        principalTable: "PaymentMethods",
                        principalColumn: "Payment_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreferenceTransportations",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(type: "int", nullable: false),
                    TransportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferenceTransportations", x => new { x.PreferenceId, x.TransportId });
                    table.ForeignKey(
                        name: "FK_PreferenceTransportations_Preference_PreferenceId",
                        column: x => x.PreferenceId,
                        principalTable: "Preference",
                        principalColumn: "Prre_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreferenceTransportations_Transportations_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transportations",
                        principalColumn: "Transport_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ItineraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => new { x.UserId, x.ActivityId, x.ItineraryId });
                    table.ForeignKey(
                        name: "FK_UserActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Activity_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserActivities_GuestUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "GuestUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserActivities_Itineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itineraries",
                        principalColumn: "ItineraryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTransportations_TransportId",
                table: "ActivityTransportations",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodPayment_Id",
                table: "Payments",
                column: "PaymentMethodPayment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PreferenceTransportations_TransportId",
                table: "PreferenceTransportations",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_ActivityId",
                table: "UserActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_ItineraryId",
                table: "UserActivities",
                column: "ItineraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preference_GuestUsers_UserId",
                table: "Preference",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_Activities_Activity_Id",
                table: "UsersReviews",
                column: "Activity_Id",
                principalTable: "Activities",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preference_GuestUsers_UserId",
                table: "Preference");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_Activities_Activity_Id",
                table: "UsersReviews");

            migrationBuilder.DropTable(
                name: "ActivityTransportations");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PreferenceTransportations");

            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preference",
                table: "Preference");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Preference",
                newName: "Preferences_Users");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "Activities_Users");

            migrationBuilder.RenameIndex(
                name: "IX_Preference_UserId",
                table: "Preferences_Users",
                newName: "IX_Preferences_Users_UserId");

            migrationBuilder.AddColumn<int>(
                name: "ActivitiesActivity_Id",
                table: "Transportations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PreferencesPrre_Id",
                table: "Transportations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preferences_Users",
                table: "Preferences_Users",
                column: "Prre_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities_Users",
                table: "Activities_Users",
                column: "Activity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_ActivitiesActivity_Id",
                table: "Transportations",
                column: "ActivitiesActivity_Id");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_Itineraries_ItinerariesItineraryID",
                table: "Activities_Users",
                column: "ItinerariesItineraryID",
                principalTable: "Itineraries",
                principalColumn: "ItineraryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Users_GuestUsers_UserId",
                table: "Preferences_Users",
                column: "UserId",
                principalTable: "GuestUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportations_Activities_Users_ActivitiesActivity_Id",
                table: "Transportations",
                column: "ActivitiesActivity_Id",
                principalTable: "Activities_Users",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportations_Preferences_Users_PreferencesPrre_Id",
                table: "Transportations",
                column: "PreferencesPrre_Id",
                principalTable: "Preferences_Users",
                principalColumn: "Prre_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_Activities_Users_Activity_Id",
                table: "UsersReviews",
                column: "Activity_Id",
                principalTable: "Activities_Users",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
