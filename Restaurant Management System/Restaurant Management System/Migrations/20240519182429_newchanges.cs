using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class newchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeatingPreferences_AspNetUsers_Id",
                table: "SeatingPreferences");

            migrationBuilder.DropIndex(
                name: "IX_SeatingPreferences_Id",
                table: "SeatingPreferences");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SeatingPreferences");

            migrationBuilder.AddColumn<Guid>(
                name: "SeatingPrefereceId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SeatingPreferenceId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatingPreferenceId",
                table: "Reservations",
                column: "SeatingPreferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_SeatingPreferences_SeatingPreferenceId",
                table: "Reservations",
                column: "SeatingPreferenceId",
                principalTable: "SeatingPreferences",
                principalColumn: "SeatingPreferenceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_SeatingPreferences_SeatingPreferenceId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_SeatingPreferenceId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "SeatingPrefereceId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "SeatingPreferenceId",
                table: "Reservations");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "SeatingPreferences",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SeatingPreferences_Id",
                table: "SeatingPreferences",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatingPreferences_AspNetUsers_Id",
                table: "SeatingPreferences",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
