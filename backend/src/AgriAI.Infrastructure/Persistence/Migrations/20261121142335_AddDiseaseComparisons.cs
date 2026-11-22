using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDiseaseComparisons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiseaseComparisons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DiseaseId = table.Column<int>(type: "integer", nullable: false),
                    SimilarDiseaseId = table.Column<int>(type: "integer", nullable: false),
                    IntroAr = table.Column<string>(type: "text", nullable: true),
                    IntroEn = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseComparisons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiseaseComparisons_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseComparisons_Diseases_SimilarDiseaseId",
                        column: x => x.SimilarDiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseComparisonRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ComparisonId = table.Column<int>(type: "integer", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    FeatureAr = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    FeatureEn = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DiseaseValueAr = table.Column<string>(type: "text", nullable: true),
                    DiseaseValueEn = table.Column<string>(type: "text", nullable: true),
                    SimilarValueAr = table.Column<string>(type: "text", nullable: true),
                    SimilarValueEn = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseComparisonRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiseaseComparisonRows_DiseaseComparisons_ComparisonId",
                        column: x => x.ComparisonId,
                        principalTable: "DiseaseComparisons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseComparisonRows_ComparisonId",
                table: "DiseaseComparisonRows",
                column: "ComparisonId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseComparisons_DiseaseId_SimilarDiseaseId",
                table: "DiseaseComparisons",
                columns: new[] { "DiseaseId", "SimilarDiseaseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseComparisons_SimilarDiseaseId",
                table: "DiseaseComparisons",
                column: "SimilarDiseaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseComparisonRows");

            migrationBuilder.DropTable(
                name: "DiseaseComparisons");
        }
    }
}
