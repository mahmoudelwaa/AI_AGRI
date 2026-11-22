using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTomatoSymptoms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Prevention", "Symptoms" },
                values: new object[] { "الري المنتظم، التسميد المتوازن، والمتابعة الدورية للنباتات.", "أوراق خضراء متجانسة بدون بقع أو اصفرار، ونمو طبيعي للساق والثمار." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Alternaria solani، ينتشر في الجو الدافئ الرطب.", "تدوير المحاصيل، تجنب الري بالرش، إزالة بقايا النباتات المصابة.", "بقع بنية داكنة على الأوراق السفلية بحلقات دائرية متداخلة (شكل الهدف) يحيط بها اصفرار، ثم تجف الأوراق وتسقط.", "رش مبيد فطري نحاسي أو كلوروثالونيل، وإزالة الأوراق المصابة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "الفطر الشبيه Phytophthora infestans، ينتشر في الطقس البارد الرطب.", "زراعة أصناف مقاومة، تهوية جيدة، وتجنب بلل الأوراق لفترات طويلة.", "بقع زيتية رمادية مخضرة على الأوراق والثمار تتحول لبنية، وعفن أبيض أسفل الورقة مع الرطوبة العالية.", "مبيدات فطرية وقائية قبل ظهور الإصابة، وإعدام النباتات شديدة الإصابة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Septoria lycopersici، ينتقل بالرذاذ والرطوبة.", "تدوير المحاصيل، تقليل رطوبة الأوراق، وتنظيف الحقل من البقايا.", "بقع صغيرة دائرية مركزها رمادي وحوافها بنية داكنة على الأوراق السفلية، وقد تظهر نقاط سوداء صغيرة في وسط البقعة.", "مبيدات فطرية وإزالة الأوراق المصابة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "بكتيريا Xanthomonas، تنتشر بالمطر والرذاذ والبذور الملوثة.", "استخدام بذور سليمة، تجنب الري بالرش، وتدوير المحاصيل.", "بقع صغيرة داكنة مائية المظهر على الأوراق، وبقع بنية خشنة مرتفعة قليلاً على الثمار.", "رش مركبات نحاسية، وإزالة النباتات شديدة الإصابة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Fusarium oxysporum يعيش في التربة سنوات طويلة.", "زراعة أصناف مقاومة، تعقيم التربة، وتدوير المحاصيل.", "اصفرار الأوراق السفلية يبدأ في جانب واحد من النبات، ثم ذبول عام، وتلون بني في الأوعية عند قطع الساق.", "لا يوجد علاج فعال بعد الإصابة؛ تُزال النباتات المصابة وتُعامل التربة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فيروس ينتقل بواسطة الذبابة البيضاء.", "مكافحة الذبابة البيضاء، استخدام شبك واقٍ، وزراعة أصناف مقاومة.", "تجعد الأوراق للأعلى واصفرار حوافها، وتقزم النبات وقلة الإثمار.", "لا يوجد علاج للفيروس؛ تُزال النباتات المصابة ويُكافح الناقل (الذبابة البيضاء)." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Prevention", "Symptoms" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });
        }
    }
}
