using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedInfectionPatternsAndRecommendations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiseaseRecommendations",
                columns: new[] { "Id", "BodyAr", "BodyEn", "DiseaseId", "SortOrder", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { 1011, "افحص النباتات أسبوعياً للتأكد من بقائها خالية من الأعراض.", "Inspect plants weekly to make sure they stay symptom-free.", 101, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 1012, "حافظ على التسميد المتوازن وأزل الحشائش لتقليل فرص العدوى.", "Keep fertilization balanced and remove weeds to reduce infection risk.", 101, 2, "الوقاية", "Prevention" },
                    { 1013, "اروِ بانتظام وتجنب بلل الأوراق لفترات طويلة.", "Irrigate regularly and avoid keeping leaves wet for long periods.", 101, 3, "إدارة الري", "Irrigation management" },
                    { 1021, "افحص الأوراق السفلية كل بضعة أيام وسجّل أي بقع جديدة.", "Check the lower leaves every few days and note any new spots.", 102, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 1022, "ابدأ برش مبيد فطري مناسب عند ظهور الأعراض الأولى واتبع تعليمات الملصق.", "Start a suitable fungicide spray at the first symptoms and follow the label instructions.", 102, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 1023, "اروِ عند قاعدة النبات وفي الصباح الباكر لتقليل رطوبة الأوراق.", "Water at the base of the plant in the early morning to reduce leaf wetness.", 102, 3, "إدارة الري", "Irrigation management" },
                    { 1031, "تابع الحقل يومياً في الطقس البارد الرطب لأن الإصابة تنتشر بسرعة.", "Scout the field daily in cool, wet weather because infection spreads quickly.", 103, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 1032, "ارش مبيداً فطرياً وقائياً وأزل النباتات شديدة الإصابة وتخلص منها بعيداً عن الحقل.", "Apply a protective fungicide and remove severely infected plants, disposing of them away from the field.", 103, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 1033, "تجنب الري بالرش وحسّن التهوية بين النباتات لتجف الأوراق سريعاً.", "Avoid overhead irrigation and improve airflow so leaves dry quickly.", 103, 3, "إدارة الري", "Irrigation management" },
                    { 1041, "افحص الأوراق السفلية بحثاً عن البقع ذات النقاط السوداء الصغيرة.", "Check the lower leaves for spots containing tiny black dots.", 104, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 1042, "أزل الأوراق المصابة وابدأ برنامج رش بمبيد فطري مناسب.", "Remove infected leaves and start a suitable fungicide program.", 104, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 1043, "قلل الرذاذ عند الري وغطِّ التربة بالمهاد لمنع انتقال الجراثيم.", "Reduce splashing when irrigating and mulch the soil to stop spores from spreading.", 104, 3, "إدارة الري", "Irrigation management" },
                    { 1051, "افحص الأوراق والثمار بعد الأمطار والرياح لأنها تنقل البكتيريا.", "Inspect leaves and fruit after rain and wind, which spread the bacteria.", 105, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 1052, "ارش مركبات نحاسية وأزل النباتات شديدة الإصابة.", "Spray copper compounds and remove severely infected plants.", 105, 2, "العلاج النحاسي", "Copper treatment" },
                    { 1053, "تجنب الري بالرش ولا تعمل في الحقل والنباتات مبللة.", "Avoid overhead irrigation and do not work in the field while plants are wet.", 105, 3, "إدارة الري", "Irrigation management" },
                    { 1061, "راقب ظهور الاصفرار من جانب واحد وافحص الأوعية عند قطع الساق.", "Watch for one-sided yellowing and check the vessels when the stem is cut.", 106, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 1062, "اقلع النباتات المصابة وتخلص منها، فالمرض لا يُعالج بالرش بعد الإصابة.", "Uproot and discard infected plants; spraying will not cure the disease once infected.", 106, 2, "التخلص من النباتات المصابة", "Remove infected plants" },
                    { 1063, "عقّم التربة وتجنب زراعة الطماطم في نفس المكان في الموسم التالي.", "Sterilize the soil and avoid planting tomatoes in the same spot next season.", 106, 3, "إدارة التربة", "Soil management" },
                    { 1071, "افحص ظهر الأوراق بحثاً عن الذبابة البيضاء بشكل منتظم.", "Check the underside of the leaves for whiteflies regularly.", 107, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 1072, "اقلع النباتات المصابة فوراً لأنه لا يوجد علاج للفيروس.", "Remove infected plants immediately because there is no cure for the virus.", 107, 2, "التخلص من النباتات المصابة", "Remove infected plants" },
                    { 1073, "استخدم الشبك الواقي والمصائد الصفراء وكافح الذبابة البيضاء.", "Use protective netting and yellow sticky traps, and control whiteflies.", 107, 3, "مكافحة الناقل", "Vector control" },
                    { 2011, "افحص الحقل أسبوعياً وتابع لون الأوراق ونمو الأشطاء.", "Inspect the field weekly and watch leaf color and tiller growth.", 201, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 2012, "حافظ على التسميد المتوازن وأزل الحشائش وبقايا المحصول.", "Keep fertilization balanced and remove weeds and crop residues.", 201, 2, "الوقاية", "Prevention" },
                    { 2013, "حافظ على مستوى مياه مناسب ولا تفرط في الغمر.", "Maintain an appropriate water level and avoid over-flooding.", 201, 3, "إدارة المياه", "Water management" },
                    { 2021, "افحص الأوراق والعنق بانتظام خاصة في الجو الرطب ومع الندى.", "Inspect leaves and the neck regularly, especially in humid weather with dew.", 202, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 2022, "ارش مبيداً فطرياً مناسباً عند ظهور الأعراض الأولى وأزل بقايا القش المصاب.", "Apply a suitable fungicide at the first symptoms and remove infected straw.", 202, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 2023, "خفف التسميد الأزوتي وقسّمه على دفعات.", "Reduce nitrogen fertilizer and split it into several applications.", 202, 3, "إدارة التسميد", "Fertilizer management" },
                    { 2031, "تابع حواف الأوراق بعد العواصف والأمطار لأنها تنقل البكتيريا.", "Check the leaf edges after storms and rain, which spread the bacteria.", 203, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 2032, "لا يوجد علاج فعال بعد الانتشار، فركّز على الوقاية وعزل الحقول المصابة.", "There is no effective cure once it spreads, so focus on prevention and isolate infected fields.", 203, 2, "الوقاية والعزل", "Prevention and isolation" },
                    { 2033, "صرّف المياه من الحقول المصابة ولا تنقل مياه الري إلى حقول سليمة.", "Drain water from infected fields and do not move irrigation water to healthy fields.", 203, 3, "إدارة المياه", "Water management" },
                    { 2041, "افحص الأوراق والحبوب وتابع علامات نقص التغذية.", "Inspect leaves and grains and watch for signs of nutrient deficiency.", 204, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 2042, "عالج البذور بمطهر فطري وارش مبيداً فطرياً عند الحاجة.", "Treat seed with a fungicide and spray a fungicide when needed.", 204, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 2043, "عوّض نقص العناصر خاصة البوتاسيوم وحافظ على مياه كافية.", "Correct nutrient deficiencies, especially potassium, and keep the water supply sufficient.", 204, 3, "إدارة التغذية", "Nutrition management" },
                    { 2051, "افحص الأغماد قرب خط الماء وتابع اتساع البقع نحو الأوراق العليا.", "Inspect sheaths near the water line and watch spots spreading toward the upper leaves.", 205, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 2052, "ارش مبيداً فطرياً مناسباً وأزل الحشائش وبقايا المحصول.", "Apply a suitable fungicide and remove weeds and crop residues.", 205, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 2053, "قلل كثافة الزراعة وصرّف المياه الزائدة لتحسين التهوية.", "Reduce planting density and drain excess water to improve airflow.", 205, 3, "إدارة الكثافة والمياه", "Density and water management" },
                    { 3011, "افحص الحقل أسبوعياً بحثاً عن أي بثرات أو بقع جديدة.", "Inspect the field weekly for any new pustules or spots.", 301, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 3012, "ازرع أصنافاً مقاومة وحافظ على التسميد المتوازن.", "Plant resistant varieties and keep fertilization balanced.", 301, 2, "الوقاية", "Prevention" },
                    { 3013, "اروِ حسب حاجة المحصول وتجنب الإفراط في الرطوبة.", "Irrigate according to crop needs and avoid excess moisture.", 301, 3, "إدارة الري", "Irrigation management" },
                    { 3021, "افحص الأوراق بحثاً عن الخطوط الصفراء، وراقب الحقل بعد كل ندى أو طقس بارد رطب.", "Look for yellow stripes on the leaves and scout the field after dew or cool, humid weather.", 302, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 3022, "ارش مبيداً فطرياً مناسباً عند ظهور الأعراض الأولى لمنع انتشار الجراثيم.", "Apply a suitable fungicide at the first symptoms to stop spores from spreading.", 302, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 3023, "تجنب الري بالرش في الصباح الباكر وفترات الرطوبة العالية حتى لا تتوفر بيئة حاضنة للفطر.", "Avoid overhead irrigation in the early morning and in very humid periods so the fungus has no favorable environment.", 302, 3, "إدارة الري", "Irrigation management" },
                    { 3031, "تابع الأوراق العليا وسجّل انتشار البثرات البرتقالية.", "Follow the upper leaves and record the spread of the orange pustules.", 303, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 3032, "ارش مبيداً فطرياً مناسباً وواصل متابعة الحقل بعد الرش.", "Apply a suitable fungicide and keep scouting the field after spraying.", 303, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 3033, "تجنب الزراعة المتأخرة والكثافة العالية في المواسم القادمة.", "Avoid late sowing and dense planting in future seasons.", 303, 3, "ميعاد الزراعة", "Sowing time" },
                    { 3041, "افحص السيقان والأغماد بحثاً عن بثرات بنية محمرة، خاصة في الطقس الدافئ الرطب.", "Inspect stems and sheaths for reddish-brown pustules, especially in warm, humid weather.", 304, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 3042, "ارش مبيداً فطرياً مناسباً فور ظهور الإصابة.", "Apply a suitable fungicide as soon as infection appears.", 304, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 3043, "ازرع مبكراً وأزل العوائل البديلة القريبة من الحقل.", "Sow early and remove alternate host plants near the field.", 304, 3, "الوقاية الموسمية", "Seasonal prevention" },
                    { 3051, "افحص الأوراق السفلية بحثاً عن البقع ذات النقاط السوداء.", "Check the lower leaves for blotches with black dots.", 305, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 3052, "ارش مبيداً فطرياً مناسباً عند بداية الإصابة.", "Apply a suitable fungicide at the start of infection.", 305, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 3053, "تخلص من بقايا المحصول المصابة بعد الحصاد وطبّق دورة زراعية.", "Remove infected crop residues after harvest and rotate crops.", 305, 3, "بقايا المحصول", "Crop residues" },
                    { 3061, "تابع ظهور الطبقة البيضاء المسحوقية على الأوراق والأغماد.", "Watch for white powdery growth on leaves and sheaths.", 306, 1, "المراقبة الدقيقة", "Close monitoring" },
                    { 3062, "ارش مبيداً فطرياً مناسباً وحسّن التهوية داخل الحقل.", "Apply a suitable fungicide and improve airflow in the field.", 306, 2, "العلاج الفطري", "Fungicide treatment" },
                    { 3063, "خفف التسميد الأزوتي وقلل كثافة الزراعة.", "Reduce nitrogen fertilizer and lower planting density.", 306, 3, "إدارة التسميد", "Fertilizer management" }
                });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع دائرية بحلقات متداخلة على الأوراق السفلية", "Circular spots with concentric rings on the lower leaves" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع زيتية كبيرة غير منتظمة تمتد بسرعة", "Large irregular oily blotches that spread rapidly" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع صغيرة كثيرة بمراكز رمادية", "Many small spots with grey centers" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع صغيرة داكنة مائية متناثرة", "Small scattered dark water-soaked spots" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "ذبول يبدأ من جانب واحد من النبات", "Wilting that starts on one side of the plant" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "تجعد الأوراق وتقزم عام للنبات", "General leaf curling and plant stunting" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع معينية أو مغزلية على الأوراق والسنابل", "Diamond or spindle-shaped spots on leaves and panicles" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "خطوط مائية تمتد من حواف الأوراق", "Water-soaked streaks extending from the leaf edges" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع بيضاوية صغيرة متناثرة على الأوراق", "Small scattered oval spots on the leaves" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع بيضاوية كبيرة على الغمد قرب سطح الماء", "Large oval lesions on the sheath near the water line" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع طولية متوازية", "Parallel longitudinal stripes" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بثرات دائرية متناثرة على السطح العلوي", "Scattered round pustules on the upper surface" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بثرات طويلة على السيقان والأغماد", "Elongated pustules on stems and sheaths" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "بقع غير منتظمة تحتوي نقاطاً سوداء صغيرة", "Irregular blotches containing tiny black dots" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { "نموات مسحوقية بيضاء على السطح", "White powdery growth on the surface" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3011);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3012);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3013);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3031);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3032);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3033);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3041);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3042);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3043);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3051);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3052);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3053);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3061);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3062);

            migrationBuilder.DeleteData(
                table: "DiseaseRecommendations",
                keyColumn: "Id",
                keyValue: 3063);

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });
        }
    }
}
