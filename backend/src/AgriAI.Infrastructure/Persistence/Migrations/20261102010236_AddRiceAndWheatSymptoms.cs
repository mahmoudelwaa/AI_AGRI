using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRiceAndWheatSymptoms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Prevention", "Symptoms" },
                values: new object[] { "التسميد المتوازن، الحفاظ على مستوى مياه مناسب، والمتابعة الدورية للحقل.", "أوراق خضراء داكنة متجانسة، ونمو منتظم للأشطاء بدون بقع أو احتراق." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Magnaporthe oryzae، ينتشر مع الرطوبة العالية والإفراط في التسميد الأزوتي.", "زراعة أصناف مقاومة، الاعتدال في التسميد الأزوتي، وتجنب كثافة الزراعة العالية.", "بقع معينية أو مغزلية رمادية المركز بحواف بنية على الأوراق، وقد تصيب العنق والسنابل فتسبب جفافها وانكسارها.", "رش مبيدات فطرية مناسبة عند ظهور الأعراض الأولى، وإزالة بقايا القش المصاب." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "بكتيريا Xanthomonas oryzae، تنتشر بمياه الري والمطر والرياح.", "استخدام بذور سليمة وأصناف مقاومة، وتجنب الإفراط في التسميد الأزوتي.", "خطوط مائية صفراء إلى بيضاء تبدأ من حواف الأوراق وتمتد على طولها ثم تجف الورقة.", "لا يوجد علاج فعال بعد انتشارها؛ يُعتمد على الوقاية وتصريف المياه من الحقول المصابة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Bipolaris oryzae، يرتبط بنقص التغذية وضعف التربة.", "تسميد متوازن (خصوصاً البوتاسيوم)، استخدام بذور سليمة، وتحسين خصوبة التربة.", "بقع بنية بيضاوية صغيرة على الأوراق، وغالباً بمركز رمادي، وقد تصيب الحبوب.", "معاملة البذور بمطهر فطري، ورش مبيد فطري عند الحاجة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Rhizoctonia solani، ينتشر مع الكثافة العالية والرطوبة والحرارة.", "تقليل كثافة الزراعة، الاعتدال في التسميد الأزوتي، وإزالة الحشائش وبقايا المحصول.", "بقع بيضاوية رمادية مخضرة على غمد الورقة قرب خط الماء، تكبر وتتحد وقد تصل للأوراق العليا.", "رش مبيدات فطرية مناسبة، وتحسين التهوية وتصريف المياه." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Prevention", "Symptoms" },
                values: new object[] { "زراعة أصناف مقاومة، التسميد المتوازن، والمتابعة الدورية للحقل.", "أوراق خضراء متجانسة بدون بثرات أو بقع، وسنابل ممتلئة ونمو منتظم." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Puccinia striiformis، ينتشر في الجو البارد الرطب بواسطة الرياح.", "زراعة أصناف مقاومة، الزراعة في الميعاد المناسب، والتخلص من النباتات المتطوعة.", "بثرات صفراء على شكل خطوط طولية متوازية على الأوراق، يخرج منها مسحوق أصفر عند اللمس.", "رش مبيدات فطرية مناسبة عند ظهور الأعراض الأولى." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Puccinia triticina، ينتشر في الطقس الدافئ الرطب بالرياح.", "زراعة أصناف مقاومة، وتجنب الزراعة المتأخرة والكثافة العالية.", "بثرات صغيرة مستديرة برتقالية إلى بنية متناثرة على السطح العلوي للأوراق.", "رش مبيدات فطرية مناسبة، والمتابعة الدورية للحقل." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Puccinia graminis، ينتشر في الجو الدافئ الرطب بالرياح.", "زراعة أصناف مقاومة، والزراعة المبكرة، والتخلص من العوائل البديلة.", "بثرات طويلة بنية محمرة على السيقان والأغماد، وتمزق الجلد فوقها وخروج مسحوق بني.", "رش مبيدات فطرية مناسبة فور ظهور الإصابة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Zymoseptoria tritici، ينتشر بالرذاذ والرطوبة.", "تدوير المحاصيل، التخلص من بقايا المحصول، وزراعة أصناف مقاومة.", "بقع غير منتظمة صفراء إلى بنية على الأوراق السفلية، وتظهر بداخلها نقاط سوداء صغيرة.", "رش مبيدات فطرية مناسبة عند بداية الإصابة." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { "فطر Blumeria graminis، ينتشر مع الرطوبة العالية والكثافة الزائدة.", "تجنب الإفراط في التسميد الأزوتي، وتقليل كثافة الزراعة، وزراعة أصناف مقاومة.", "نموات بيضاء رمادية مسحوقية على الأوراق والأغماد، تتحول لاحقاً إلى بقع داكنة.", "رش مبيدات فطرية مناسبة، وتحسين التهوية." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Prevention", "Symptoms" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Prevention", "Symptoms" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Causes", "Prevention", "Symptoms", "Treatment" },
                values: new object[] { null, null, null, null });
        }
    }
}
