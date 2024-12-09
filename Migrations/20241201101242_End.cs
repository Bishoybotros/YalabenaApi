using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class End : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Act_Itineraryid_fk",
                table: "Activities_Users");

            migrationBuilder.DropColumn(
                name: "Act_Userid_fk",
                table: "Activities_Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Act_Itineraryid_fk",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Act_Userid_fk",
                table: "Activities_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
