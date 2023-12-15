using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVisitMedicalRecordRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_MedicalRecords_MedicalRecordId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_MedicalRecordId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "MedicalRecordId",
                table: "Visits");

            migrationBuilder.AddColumn<Guid>(
                name: "VisitId",
                table: "MedicalRecords",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_VisitId",
                table: "MedicalRecords",
                column: "VisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Visits_VisitId",
                table: "MedicalRecords",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Visits_VisitId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_VisitId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "MedicalRecords");

            migrationBuilder.AddColumn<Guid>(
                name: "MedicalRecordId",
                table: "Visits",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Visits_MedicalRecordId",
                table: "Visits",
                column: "MedicalRecordId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_MedicalRecords_MedicalRecordId",
                table: "Visits",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
