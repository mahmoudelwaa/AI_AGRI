using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDiseaseDescriptiveValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "حرارة دافئة (حوالي 24-29 م) ورطوبة عالية، وأمطار أو ري بالرش متكرر.", "Fungal", "Alternaria solani", "Medium", "Medium" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "طقس بارد معتدل (حوالي 10-24 م) ورطوبة عالية جداً وأجواء غائمة أو ممطرة.", "Fungal", "Phytophthora infestans", "High", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "حرارة معتدلة (حوالي 20-25 م) ورطوبة عالية، وانتقال العدوى برذاذ المطر والري.", "Fungal", "Septoria lycopersici", "Medium", "Medium" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "طقس دافئ ورطب (حوالي 24-30 م) مع أمطار ورياح وري بالرش.", "Bacterial", "Xanthomonas spp.", "Medium", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "تربة دافئة (حوالي 27-28 م) وتربة حمضية خفيفة، وجروح في الجذور.", "Fungal", "Fusarium oxysporum f. sp. lycopersici", "High", "Slow" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "طقس دافئ وجاف يزيد أعداد الذبابة البيضاء، خصوصاً في الزراعات المتجاورة.", "Viral", "Tomato yellow leaf curl virus (TYLCV)", "High", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "رطوبة عالية وندى طويل وحرارة معتدلة (حوالي 25-28 م)، مع إفراط في التسميد الأزوتي.", "Fungal", "Magnaporthe oryzae", "High", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "حرارة عالية (حوالي 25-34 م) مع أمطار ورياح وغمر الحقل بالمياه.", "Bacterial", "Xanthomonas oryzae pv. oryzae", "High", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "رطوبة عالية وحرارة دافئة (حوالي 25-30 م)، وتربة فقيرة أو إجهاد مائي ونقص تغذية.", "Fungal", "Bipolaris oryzae", "Medium", "Medium" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "حرارة ورطوبة عالية (حوالي 28-32 م)، وكثافة زراعة عالية وتسميد أزوتي زائد.", "Fungal", "Rhizoctonia solani", "High", "Medium" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "طقس بارد معتدل (حوالي 10-15 م) مع ندى ورطوبة عالية، وتنتشر الجراثيم بالرياح.", "Fungal", "Puccinia striiformis f. sp. tritici", "High", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "حرارة معتدلة إلى دافئة (حوالي 15-25 م) مع ندى أو رطوبة عالية.", "Fungal", "Puccinia triticina", "Medium", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "طقس دافئ ورطب (حوالي 20-30 م) مع ندى، وانتشار سريع بالرياح.", "Fungal", "Puccinia graminis f. sp. tritici", "High", "Fast" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "حرارة معتدلة (حوالي 15-25 م) وأمطار أو رطوبة عالية مع رذاذ يحمل الجراثيم.", "Fungal", "Zymoseptoria tritici", "Medium", "Medium" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { "رطوبة عالية وحرارة معتدلة (حوالي 15-22 م)، وكثافة زراعة عالية وتسميد أزوتي زائد.", "Fungal", "Blumeria graminis f. sp. tritici", "Medium", "Medium" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Conditions", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, "None", null, "None", "None" });
        }
    }
}
