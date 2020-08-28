using Microsoft.EntityFrameworkCore.Migrations;

namespace ToKhaiYTe.Migrations
{
    public partial class fixTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TravelInfomation_MedicalDeclarationFormId",
                table: "TravelInfomation");

            migrationBuilder.DropIndex(
                name: "IX_PhatologicalSign_MedicalDeclarationFormId",
                table: "PhatologicalSign");

            migrationBuilder.DropIndex(
                name: "IX_HistoryOfExposure_MedicalDeclarationFormId",
                table: "HistoryOfExposure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelInfomation",
                table: "TravelInfomation",
                column: "MedicalDeclarationFormId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhatologicalSign",
                table: "PhatologicalSign",
                column: "MedicalDeclarationFormId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoryOfExposure",
                table: "HistoryOfExposure",
                column: "MedicalDeclarationFormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelInfomation",
                table: "TravelInfomation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhatologicalSign",
                table: "PhatologicalSign");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoryOfExposure",
                table: "HistoryOfExposure");

            migrationBuilder.CreateIndex(
                name: "IX_TravelInfomation_MedicalDeclarationFormId",
                table: "TravelInfomation",
                column: "MedicalDeclarationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_PhatologicalSign_MedicalDeclarationFormId",
                table: "PhatologicalSign",
                column: "MedicalDeclarationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryOfExposure_MedicalDeclarationFormId",
                table: "HistoryOfExposure",
                column: "MedicalDeclarationFormId");
        }
    }
}
