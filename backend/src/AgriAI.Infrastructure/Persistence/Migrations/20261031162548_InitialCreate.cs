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
                    NameAr = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
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
                    NameAr = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    IsHealthy = table.Column<bool>(type: "boolean", nullable: false),
                    CropId = table.Column<int>(type: "integer", nullable: false)
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
                columns: new[] { "Id", "CropId", "IsHealthy", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 101, 1, true, "سليم", "Healthy" },
                    { 102, 1, false, "اللفحة المبكرة", "Early Blight" },
                    { 103, 1, false, "اللفحة المتأخرة", "Late Blight" },
                    { 104, 1, false, "تبقع أوراق السبتوريا", "Septoria Leaf Spot" },
                    { 105, 1, false, "التبقع البكتيري", "Bacterial Spot" },
                    { 106, 1, false, "ذبول الفيوزاريوم", "Fusarium Wilt" },
                    { 107, 1, false, "فيروس تجعد واصفرار أوراق الطماطم", "Tomato Yellow Leaf Curl Virus" },
                    { 201, 2, true, "سليم", "Healthy" },
                    { 202, 2, false, "لفحة الأرز", "Rice Blast" },
                    { 203, 2, false, "اللفحة البكتيرية للأرز", "Bacterial Leaf Blight" },
                    { 204, 2, false, "التبقع البني", "Brown Spot" },
                    { 205, 2, false, "لفحة غمد الأرز", "Sheath Blight" },
                    { 301, 3, true, "سليم", "Healthy" },
                    { 302, 3, false, "الصدأ الأصفر", "Yellow Rust" },
                    { 303, 3, false, "صدأ الأوراق", "Leaf Rust" },
                    { 304, 3, false, "صدأ الساق", "Stem Rust" },
                    { 305, 3, false, "تبقع أوراق السبتوريا", "Septoria Leaf Blotch" },
                    { 306, 3, false, "البياض الدقيقي", "Powdery Mildew" }
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
