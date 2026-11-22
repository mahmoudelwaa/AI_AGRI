using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDiseaseComparisons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiseaseComparisons",
                columns: new[] { "Id", "DiseaseId", "IntroAr", "IntroEn", "SimilarDiseaseId" },
                values: new object[,]
                {
                    { 1, 302, "مقارنة حقلية دقيقة للتفريق بين صدأ القمح الأصفر (المخطط) وصدأ الأوراق البني.", "A close field comparison to tell stripe (yellow) rust from leaf (brown) rust.", 303 },
                    { 2, 303, "مقارنة للتفريق بين صدأ الأوراق وصدأ الساق في القمح.", "A comparison to tell leaf rust from stem rust in wheat.", 304 },
                    { 3, 102, "مقارنة للتفريق بين اللفحة المبكرة واللفحة المتأخرة في الطماطم.", "A comparison to tell early blight from late blight in tomato.", 103 },
                    { 4, 102, "مقارنة للتفريق بين اللفحة المبكرة وتبقع أوراق السبتوريا في الطماطم.", "A comparison to tell early blight from Septoria leaf spot in tomato.", 104 },
                    { 5, 105, "مقارنة للتفريق بين التبقع البكتيري وتبقع أوراق السبتوريا في الطماطم.", "A comparison to tell bacterial spot from Septoria leaf spot in tomato.", 104 },
                    { 6, 202, "مقارنة للتفريق بين لفحة الأرز والتبقع البني في الأرز.", "A comparison to tell rice blast from brown spot in rice.", 204 },
                    { 7, 204, "مقارنة للتفريق بين التبقع البني ولفحة غمد الأرز.", "A comparison to tell brown spot from sheath blight in rice.", 205 }
                });

            migrationBuilder.InsertData(
                table: "DiseaseComparisonRows",
                columns: new[] { "Id", "ComparisonId", "DiseaseValueAr", "DiseaseValueEn", "FeatureAr", "FeatureEn", "SimilarValueAr", "SimilarValueEn", "SortOrder" },
                values: new object[,]
                {
                    { 11, 1, "أصفر ليموني إلى برتقالي زاهٍ", "Lemon yellow to bright orange", "لون البقع", "Spot color", "بني محمر داكن إلى كستنائي", "Dark reddish-brown to chestnut", 1 },
                    { 12, 1, "نصل الورقة والسنابل والأغماد", "Leaf blade, heads and sheaths", "المكان الرئيسي", "Main location", "السطح العلوي لنصل الأوراق غالباً", "Mostly the upper surface of the leaf blade", 2 },
                    { 13, 1, "خطوط وأشرطة طولية متوازية", "Parallel longitudinal stripes and bands", "شكل البقع", "Spot shape", "بثرات دائرية أو بيضاوية مبعثرة", "Scattered round or oval pustules", 3 },
                    { 14, 1, "بداية الربيع مع الطقس البارد الرطب", "Early spring with cool, humid weather", "التوقيت", "Timing", "أواخر الموسم مع الطقس الأدفأ", "Later in the season with warmer weather", 4 },
                    { 21, 2, "برتقالي إلى بني", "Orange to brown", "لون البقع", "Spot color", "بني محمر داكن", "Dark reddish-brown", 1 },
                    { 22, 2, "السطح العلوي للأوراق", "Upper leaf surface", "المكان الرئيسي", "Main location", "السيقان والأغماد وأحياناً الأوراق", "Stems and sheaths, sometimes leaves", 2 },
                    { 23, 2, "بثرات صغيرة مستديرة متناثرة", "Small round scattered pustules", "شكل البقع", "Spot shape", "بثرات طويلة بارزة يتمزق الجلد فوقها", "Long raised pustules with torn skin over them", 3 },
                    { 24, 2, "من منتصف الموسم في الطقس المعتدل إلى الدافئ", "From mid-season in mild to warm weather", "التوقيت", "Timing", "أواخر الموسم في الطقس الدافئ الرطب", "Late season in warm, humid weather", 4 },
                    { 31, 3, "بني داكن بحلقات متداخلة وهالة صفراء", "Dark brown with concentric rings and a yellow halo", "لون البقع", "Spot color", "رمادي مخضر زيتي يتحول إلى بني", "Oily grey-green turning brown", 1 },
                    { 32, 3, "الأوراق السفلية الأكبر عمراً أولاً", "Older lower leaves first", "المكان الرئيسي", "Main location", "الأوراق والسيقان والثمار في أي جزء من النبات", "Leaves, stems and fruit anywhere on the plant", 2 },
                    { 33, 3, "بقع محددة بشكل الهدف", "Well-defined target-shaped spots", "شكل البقع", "Spot shape", "بقع كبيرة غير منتظمة تمتد بسرعة وعفن أبيض أسفل الورقة", "Large irregular blotches that spread fast, with white mold under the leaf", 3 },
                    { 34, 3, "طقس دافئ ورطب وغالباً في منتصف الموسم", "Warm, humid weather, often mid-season", "التوقيت", "Timing", "طقس بارد وغائم وممطر", "Cool, cloudy and rainy weather", 4 },
                    { 41, 4, "بني داكن بحلقات وهالة صفراء", "Dark brown with rings and a yellow halo", "لون البقع", "Spot color", "مركز رمادي وحواف بنية داكنة", "Grey center with dark brown edges", 1 },
                    { 42, 4, "الأوراق السفلية، وقد تصيب الساق والثمار", "Lower leaves; may also affect stems and fruit", "المكان الرئيسي", "Main location", "الأوراق السفلية غالباً ونادراً الثمار", "Mostly lower leaves, rarely fruit", 2 },
                    { 43, 4, "بقع كبيرة نسبياً بحلقات متداخلة", "Relatively large spots with concentric rings", "شكل البقع", "Spot shape", "بقع صغيرة كثيرة ونقاط سوداء في المركز", "Many small spots with black dots in the center", 3 },
                    { 44, 4, "طقس دافئ ورطب", "Warm, humid weather", "التوقيت", "Timing", "طقس معتدل مع أمطار ورذاذ متكرر", "Moderate weather with frequent rain and splashing", 4 },
                    { 51, 5, "داكن مائي المظهر", "Dark and water-soaked", "لون البقع", "Spot color", "مركز رمادي وحواف بنية داكنة", "Grey center with dark brown edges", 1 },
                    { 52, 5, "الأوراق والثمار", "Leaves and fruit", "المكان الرئيسي", "Main location", "الأوراق السفلية غالباً", "Mostly lower leaves", 2 },
                    { 53, 5, "بقع صغيرة متناثرة وبقع خشنة على الثمار", "Small scattered spots and rough raised spots on fruit", "شكل البقع", "Spot shape", "بقع دائرية بنقاط سوداء صغيرة في المركز", "Round spots with tiny black dots in the center", 3 },
                    { 54, 5, "طقس دافئ رطب مع أمطار ورياح", "Warm, humid weather with rain and wind", "التوقيت", "Timing", "طقس معتدل مع رذاذ المطر والري", "Moderate weather with splashing rain and irrigation", 4 },
                    { 61, 6, "مركز رمادي بحواف بنية", "Grey center with brown margins", "لون البقع", "Spot color", "بني إلى بني داكن وأحياناً بمركز رمادي", "Brown to dark brown, sometimes with a grey center", 1 },
                    { 62, 6, "الأوراق والعنق والسنابل", "Leaves, neck and panicles", "المكان الرئيسي", "Main location", "الأوراق والحبوب", "Leaves and grains", 2 },
                    { 63, 6, "بقع معينية أو مغزلية كبيرة", "Large diamond or spindle-shaped spots", "شكل البقع", "Spot shape", "بقع بيضاوية صغيرة متناثرة", "Small scattered oval spots", 3 },
                    { 64, 6, "رطوبة عالية وندى طويل وتسميد أزوتي زائد", "High humidity, long dew periods and excess nitrogen", "التوقيت", "Timing", "نقص التغذية والتربة الفقيرة", "Nutrient deficiency and poor soil", 4 },
                    { 71, 7, "بني إلى بني داكن", "Brown to dark brown", "لون البقع", "Spot color", "رمادي مخضر بحواف بنية", "Grey-green with brown margins", 1 },
                    { 72, 7, "نصل الورقة والحبوب", "Leaf blade and grains", "المكان الرئيسي", "Main location", "الغمد قرب خط الماء ثم الأوراق العليا", "Sheath near the water line, then upper leaves", 2 },
                    { 73, 7, "بقع بيضاوية صغيرة منفصلة", "Small separate oval spots", "شكل البقع", "Spot shape", "بقع بيضاوية كبيرة تتحد معاً", "Large oval lesions that merge together", 3 },
                    { 74, 7, "ضعف التربة وإجهاد النبات", "Poor soil and plant stress", "التوقيت", "Timing", "كثافة زراعة عالية مع حرارة ورطوبة عالية", "Dense planting with high heat and humidity", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisonRows",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DiseaseComparisons",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
