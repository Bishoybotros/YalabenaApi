using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class InititalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuestUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preferences = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_of_method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Payment_Id);
                });

            migrationBuilder.CreateTable(
                name: "Itineraries",
                columns: table => new
                {
                    ItineraryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItineraryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItineraryActivities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    I_Userid_fk = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itineraries", x => x.ItineraryID);
                    table.ForeignKey(
                        name: "FK_Itineraries_GuestUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "GuestUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Preferences_Users",
                columns: table => new
                {
                    Prre_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_userid_fk = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Budget = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    TransportType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences_Users", x => x.Prre_Id);
                    table.ForeignKey(
                        name: "FK_Preferences_Users_GuestUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "GuestUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Activities_Users",
                columns: table => new
                {
                    Activity_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activity_Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activity_Price = table.Column<int>(type: "int", nullable: false),
                    Activity_Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Act_Itineraryid_fk = table.Column<int>(type: "int", nullable: false),
                    ItineraryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities_Users", x => x.Activity_Id);
                    table.ForeignKey(
                        name: "FK_Activities_Users_Itineraries_ItineraryID",
                        column: x => x.ItineraryID,
                        principalTable: "Itineraries",
                        principalColumn: "ItineraryID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_Userid_fk = table.Column<int>(type: "int", nullable: false),
                    B_Itineraryid_fk = table.Column<int>(type: "int", nullable: false),
                    B_PaymentMethodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_GuestUsers_B_Userid_fk",
                        column: x => x.B_Userid_fk,
                        principalTable: "GuestUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Itineraries_B_Itineraryid_fk",
                        column: x => x.B_Itineraryid_fk,
                        principalTable: "Itineraries",
                        principalColumn: "ItineraryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_PaymentMethods_B_PaymentMethodId",
                        column: x => x.B_PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Payment_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transportations",
                columns: table => new
                {
                    Transport_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transport_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport_Rout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport_Cost = table.Column<int>(type: "int", nullable: false),
                    Activity_Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Act_Pref_Fk = table.Column<int>(type: "int", nullable: false),
                    PreferencePrre_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportations", x => x.Transport_Id);
                    table.ForeignKey(
                        name: "FK_Transportations_Preferences_Users_PreferencePrre_Id",
                        column: x => x.PreferencePrre_Id,
                        principalTable: "Preferences_Users",
                        principalColumn: "Prre_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UsersReviews",
                columns: table => new
                {
                    Review_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review_Feedback = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rev_activity_fk = table.Column<int>(type: "int", nullable: false),
                    Rev_userid_fk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersReviews", x => x.Review_Id);
                    table.ForeignKey(
                        name: "FK_UsersReviews_Activities_Users_Rev_activity_fk",
                        column: x => x.Rev_activity_fk,
                        principalTable: "Activities_Users",
                        principalColumn: "Activity_Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsersReviews_GuestUsers_Rev_userid_fk",
                        column: x => x.Rev_userid_fk,
                        principalTable: "GuestUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Users_ItineraryID",
                table: "Activities_Users",
                column: "ItineraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_B_Itineraryid_fk",
                table: "Bookings",
                column: "B_Itineraryid_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_B_PaymentMethodId",
                table: "Bookings",
                column: "B_PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_B_Userid_fk",
                table: "Bookings",
                column: "B_Userid_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Itineraries_UserId",
                table: "Itineraries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_Users_UserId",
                table: "Preferences_Users",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_PreferencePrre_Id",
                table: "Transportations",
                column: "PreferencePrre_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsersReviews_Rev_activity_fk",
                table: "UsersReviews",
                column: "Rev_activity_fk");

            migrationBuilder.CreateIndex(
                name: "IX_UsersReviews_Rev_userid_fk",
                table: "UsersReviews",
                column: "Rev_userid_fk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Transportations");

            migrationBuilder.DropTable(
                name: "UsersReviews");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Preferences_Users");

            migrationBuilder.DropTable(
                name: "Activities_Users");

            migrationBuilder.DropTable(
                name: "Itineraries");

            migrationBuilder.DropTable(
                name: "GuestUsers");
        }
    }
}
