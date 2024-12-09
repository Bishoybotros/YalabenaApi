using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YalabenaApi.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "GuestUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "GuestUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "GuestUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "GuestUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "phone",
                table: "GuestUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "GuestUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "GuestUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "GuestUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "GuestUsers");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "GuestUsers");
        }
    }
}
