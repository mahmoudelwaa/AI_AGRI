using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    NameEn = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CropId = table.Column<int>(type: "integer", nullable: false),
                    NameEn = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    NameAr = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    IsHealthy = table.Column<bool>(type: "boolean", nullable: false),
                    Symptoms = table.Column<string>(type: "text", nullable: true),
                    Causes = table.Column<string>(type: "text", nullable: true),
                    Prevention = table.Column<string>(type: "text", nullable: true),
                    Treatment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diseases_Crops_CropId",
                        column: x => x.CropId,
                        principalTable: "Crops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Crops",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "طماطم", "Tomato" },
                    { 2, "أرز", "Rice" },
                    { 3, "قمح", "Wheat" }
                });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "Id", "Causes", "CropId", "IsHealthy", "NameAr", "NameEn", "Prevention", "Symptoms", "Treatment" },
                values: new object[,]
                {
                    { 101, null, 1, true, "سليم", "Healthy", null, null, null },
                    { 102, null, 1, false, "اللفحة المبكرة", "Early Blight", null, null, null },
                    { 103, null, 1, false, "اللفحة المتأخرة", "Late Blight", null, null, null },
                    { 104, null, 1, false, "تبقع أوراق السبتوريا", "Septoria Leaf Spot", null, null, null },
                    { 105, null, 1, false, "التبقع البكتيري", "Bacterial Spot", null, null, null },
                    { 106, null, 1, false, "ذبول الفيوزاريوم", "Fusarium Wilt", null, null, null },
                    { 107, null, 1, false, "فيروس تجعد واصفرار أوراق الطماطم", "Tomato Yellow Leaf Curl Virus", null, null, null },
                    { 201, null, 2, true, "سليم", "Healthy", null, null, null },
                    { 202, null, 2, false, "لفحة الأرز", "Rice Blast", null, null, null },
                    { 203, null, 2, false, "اللفحة البكتيرية للأرز", "Bacterial Leaf Blight", null, null, null },
                    { 204, null, 2, false, "التبقع البني", "Brown Spot", null, null, null },
                    { 205, null, 2, false, "لفحة غمد الأرز", "Sheath Blight", null, null, null },
                    { 301, null, 3, true, "سليم", "Healthy", null, null, null },
                    { 302, null, 3, false, "الصدأ الأصفر", "Yellow Rust", null, null, null },
                    { 303, null, 3, false, "صدأ الأوراق", "Leaf Rust", null, null, null },
                    { 304, null, 3, false, "صدأ الساق", "Stem Rust", null, null, null },
                    { 305, null, 3, false, "تبقع أوراق السبتوريا", "Septoria Leaf Blotch", null, null, null },
                    { 306, null, 3, false, "البياض الدقيقي", "Powdery Mildew", null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_CropId",
                table: "Diseases",
                column: "CropId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Crops");
        }
    }
}
