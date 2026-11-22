using AgriAI.Domain.Entities;

namespace AgriAI.Infrastructure.Persistence.Seed;

public static class DiseaseComparisonSeed
{
    public static readonly DiseaseComparison[] Comparisons =
    {
        new DiseaseComparison
        {
            Id = 1, DiseaseId = 302, SimilarDiseaseId = 303,
            IntroAr = "مقارنة حقلية دقيقة للتفريق بين صدأ القمح الأصفر (المخطط) وصدأ الأوراق البني.",
            IntroEn = "A close field comparison to tell stripe (yellow) rust from leaf (brown) rust."
        },
        new DiseaseComparison
        {
            Id = 2, DiseaseId = 303, SimilarDiseaseId = 304,
            IntroAr = "مقارنة للتفريق بين صدأ الأوراق وصدأ الساق في القمح.",
            IntroEn = "A comparison to tell leaf rust from stem rust in wheat."
        },
        new DiseaseComparison
        {
            Id = 3, DiseaseId = 102, SimilarDiseaseId = 103,
            IntroAr = "مقارنة للتفريق بين اللفحة المبكرة واللفحة المتأخرة في الطماطم.",
            IntroEn = "A comparison to tell early blight from late blight in tomato."
        },
        new DiseaseComparison
        {
            Id = 4, DiseaseId = 102, SimilarDiseaseId = 104,
            IntroAr = "مقارنة للتفريق بين اللفحة المبكرة وتبقع أوراق السبتوريا في الطماطم.",
            IntroEn = "A comparison to tell early blight from Septoria leaf spot in tomato."
        },
        new DiseaseComparison
        {
            Id = 5, DiseaseId = 105, SimilarDiseaseId = 104,
            IntroAr = "مقارنة للتفريق بين التبقع البكتيري وتبقع أوراق السبتوريا في الطماطم.",
            IntroEn = "A comparison to tell bacterial spot from Septoria leaf spot in tomato."
        },
        new DiseaseComparison
        {
            Id = 6, DiseaseId = 202, SimilarDiseaseId = 204,
            IntroAr = "مقارنة للتفريق بين لفحة الأرز والتبقع البني في الأرز.",
            IntroEn = "A comparison to tell rice blast from brown spot in rice."
        },
        new DiseaseComparison
        {
            Id = 7, DiseaseId = 204, SimilarDiseaseId = 205,
            IntroAr = "مقارنة للتفريق بين التبقع البني ولفحة غمد الأرز.",
            IntroEn = "A comparison to tell brown spot from sheath blight in rice."
        }
    };

    public static readonly DiseaseComparisonRow[] Rows =
    {
        new DiseaseComparisonRow
        {
            Id = 11, ComparisonId = 1, SortOrder = 1,
            FeatureAr = "لون البقع", FeatureEn = "Spot color",
            DiseaseValueAr = "أصفر ليموني إلى برتقالي زاهٍ",
            DiseaseValueEn = "Lemon yellow to bright orange",
            SimilarValueAr = "بني محمر داكن إلى كستنائي",
            SimilarValueEn = "Dark reddish-brown to chestnut"
        },
        new DiseaseComparisonRow
        {
            Id = 12, ComparisonId = 1, SortOrder = 2,
            FeatureAr = "المكان الرئيسي", FeatureEn = "Main location",
            DiseaseValueAr = "نصل الورقة والسنابل والأغماد",
            DiseaseValueEn = "Leaf blade, heads and sheaths",
            SimilarValueAr = "السطح العلوي لنصل الأوراق غالباً",
            SimilarValueEn = "Mostly the upper surface of the leaf blade"
        },
        new DiseaseComparisonRow
        {
            Id = 13, ComparisonId = 1, SortOrder = 3,
            FeatureAr = "شكل البقع", FeatureEn = "Spot shape",
            DiseaseValueAr = "خطوط وأشرطة طولية متوازية",
            DiseaseValueEn = "Parallel longitudinal stripes and bands",
            SimilarValueAr = "بثرات دائرية أو بيضاوية مبعثرة",
            SimilarValueEn = "Scattered round or oval pustules"
        },
        new DiseaseComparisonRow
        {
            Id = 14, ComparisonId = 1, SortOrder = 4,
            FeatureAr = "التوقيت", FeatureEn = "Timing",
            DiseaseValueAr = "بداية الربيع مع الطقس البارد الرطب",
            DiseaseValueEn = "Early spring with cool, humid weather",
            SimilarValueAr = "أواخر الموسم مع الطقس الأدفأ",
            SimilarValueEn = "Later in the season with warmer weather"
        },
        new DiseaseComparisonRow
        {
            Id = 21, ComparisonId = 2, SortOrder = 1,
            FeatureAr = "لون البقع", FeatureEn = "Spot color",
            DiseaseValueAr = "برتقالي إلى بني",
            DiseaseValueEn = "Orange to brown",
            SimilarValueAr = "بني محمر داكن",
            SimilarValueEn = "Dark reddish-brown"
        },
        new DiseaseComparisonRow
        {
            Id = 22, ComparisonId = 2, SortOrder = 2,
            FeatureAr = "المكان الرئيسي", FeatureEn = "Main location",
            DiseaseValueAr = "السطح العلوي للأوراق",
            DiseaseValueEn = "Upper leaf surface",
            SimilarValueAr = "السيقان والأغماد وأحياناً الأوراق",
            SimilarValueEn = "Stems and sheaths, sometimes leaves"
        },
        new DiseaseComparisonRow
        {
            Id = 23, ComparisonId = 2, SortOrder = 3,
            FeatureAr = "شكل البقع", FeatureEn = "Spot shape",
            DiseaseValueAr = "بثرات صغيرة مستديرة متناثرة",
            DiseaseValueEn = "Small round scattered pustules",
            SimilarValueAr = "بثرات طويلة بارزة يتمزق الجلد فوقها",
            SimilarValueEn = "Long raised pustules with torn skin over them"
        },
        new DiseaseComparisonRow
        {
            Id = 24, ComparisonId = 2, SortOrder = 4,
            FeatureAr = "التوقيت", FeatureEn = "Timing",
            DiseaseValueAr = "من منتصف الموسم في الطقس المعتدل إلى الدافئ",
            DiseaseValueEn = "From mid-season in mild to warm weather",
            SimilarValueAr = "أواخر الموسم في الطقس الدافئ الرطب",
            SimilarValueEn = "Late season in warm, humid weather"
        },
        new DiseaseComparisonRow
        {
            Id = 31, ComparisonId = 3, SortOrder = 1,
            FeatureAr = "لون البقع", FeatureEn = "Spot color",
            DiseaseValueAr = "بني داكن بحلقات متداخلة وهالة صفراء",
            DiseaseValueEn = "Dark brown with concentric rings and a yellow halo",
            SimilarValueAr = "رمادي مخضر زيتي يتحول إلى بني",
            SimilarValueEn = "Oily grey-green turning brown"
        },
        new DiseaseComparisonRow
        {
            Id = 32, ComparisonId = 3, SortOrder = 2,
            FeatureAr = "المكان الرئيسي", FeatureEn = "Main location",
            DiseaseValueAr = "الأوراق السفلية الأكبر عمراً أولاً",
            DiseaseValueEn = "Older lower leaves first",
            SimilarValueAr = "الأوراق والسيقان والثمار في أي جزء من النبات",
            SimilarValueEn = "Leaves, stems and fruit anywhere on the plant"
        },
        new DiseaseComparisonRow
        {
            Id = 33, ComparisonId = 3, SortOrder = 3,
            FeatureAr = "شكل البقع", FeatureEn = "Spot shape",
            DiseaseValueAr = "بقع محددة بشكل الهدف",
            DiseaseValueEn = "Well-defined target-shaped spots",
            SimilarValueAr = "بقع كبيرة غير منتظمة تمتد بسرعة وعفن أبيض أسفل الورقة",
            SimilarValueEn = "Large irregular blotches that spread fast, with white mold under the leaf"
        },
        new DiseaseComparisonRow
        {
            Id = 34, ComparisonId = 3, SortOrder = 4,
            FeatureAr = "التوقيت", FeatureEn = "Timing",
            DiseaseValueAr = "طقس دافئ ورطب وغالباً في منتصف الموسم",
            DiseaseValueEn = "Warm, humid weather, often mid-season",
            SimilarValueAr = "طقس بارد وغائم وممطر",
            SimilarValueEn = "Cool, cloudy and rainy weather"
        },
        new DiseaseComparisonRow
        {
            Id = 41, ComparisonId = 4, SortOrder = 1,
            FeatureAr = "لون البقع", FeatureEn = "Spot color",
            DiseaseValueAr = "بني داكن بحلقات وهالة صفراء",
            DiseaseValueEn = "Dark brown with rings and a yellow halo",
            SimilarValueAr = "مركز رمادي وحواف بنية داكنة",
            SimilarValueEn = "Grey center with dark brown edges"
        },
        new DiseaseComparisonRow
        {
            Id = 42, ComparisonId = 4, SortOrder = 2,
            FeatureAr = "المكان الرئيسي", FeatureEn = "Main location",
            DiseaseValueAr = "الأوراق السفلية، وقد تصيب الساق والثمار",
            DiseaseValueEn = "Lower leaves; may also affect stems and fruit",
            SimilarValueAr = "الأوراق السفلية غالباً ونادراً الثمار",
            SimilarValueEn = "Mostly lower leaves, rarely fruit"
        },
        new DiseaseComparisonRow
        {
            Id = 43, ComparisonId = 4, SortOrder = 3,
            FeatureAr = "شكل البقع", FeatureEn = "Spot shape",
            DiseaseValueAr = "بقع كبيرة نسبياً بحلقات متداخلة",
            DiseaseValueEn = "Relatively large spots with concentric rings",
            SimilarValueAr = "بقع صغيرة كثيرة ونقاط سوداء في المركز",
            SimilarValueEn = "Many small spots with black dots in the center"
        },
        new DiseaseComparisonRow
        {
            Id = 44, ComparisonId = 4, SortOrder = 4,
            FeatureAr = "التوقيت", FeatureEn = "Timing",
            DiseaseValueAr = "طقس دافئ ورطب",
            DiseaseValueEn = "Warm, humid weather",
            SimilarValueAr = "طقس معتدل مع أمطار ورذاذ متكرر",
            SimilarValueEn = "Moderate weather with frequent rain and splashing"
        },
        new DiseaseComparisonRow
        {
            Id = 51, ComparisonId = 5, SortOrder = 1,
            FeatureAr = "لون البقع", FeatureEn = "Spot color",
            DiseaseValueAr = "داكن مائي المظهر",
            DiseaseValueEn = "Dark and water-soaked",
            SimilarValueAr = "مركز رمادي وحواف بنية داكنة",
            SimilarValueEn = "Grey center with dark brown edges"
        },
        new DiseaseComparisonRow
        {
            Id = 52, ComparisonId = 5, SortOrder = 2,
            FeatureAr = "المكان الرئيسي", FeatureEn = "Main location",
            DiseaseValueAr = "الأوراق والثمار",
            DiseaseValueEn = "Leaves and fruit",
            SimilarValueAr = "الأوراق السفلية غالباً",
            SimilarValueEn = "Mostly lower leaves"
        },
        new DiseaseComparisonRow
        {
            Id = 53, ComparisonId = 5, SortOrder = 3,
            FeatureAr = "شكل البقع", FeatureEn = "Spot shape",
            DiseaseValueAr = "بقع صغيرة متناثرة وبقع خشنة على الثمار",
            DiseaseValueEn = "Small scattered spots and rough raised spots on fruit",
            SimilarValueAr = "بقع دائرية بنقاط سوداء صغيرة في المركز",
            SimilarValueEn = "Round spots with tiny black dots in the center"
        },
        new DiseaseComparisonRow
        {
            Id = 54, ComparisonId = 5, SortOrder = 4,
            FeatureAr = "التوقيت", FeatureEn = "Timing",
            DiseaseValueAr = "طقس دافئ رطب مع أمطار ورياح",
            DiseaseValueEn = "Warm, humid weather with rain and wind",
            SimilarValueAr = "طقس معتدل مع رذاذ المطر والري",
            SimilarValueEn = "Moderate weather with splashing rain and irrigation"
        },
        new DiseaseComparisonRow
        {
            Id = 61, ComparisonId = 6, SortOrder = 1,
            FeatureAr = "لون البقع", FeatureEn = "Spot color",
            DiseaseValueAr = "مركز رمادي بحواف بنية",
            DiseaseValueEn = "Grey center with brown margins",
            SimilarValueAr = "بني إلى بني داكن وأحياناً بمركز رمادي",
            SimilarValueEn = "Brown to dark brown, sometimes with a grey center"
        },
        new DiseaseComparisonRow
        {
            Id = 62, ComparisonId = 6, SortOrder = 2,
            FeatureAr = "المكان الرئيسي", FeatureEn = "Main location",
            DiseaseValueAr = "الأوراق والعنق والسنابل",
            DiseaseValueEn = "Leaves, neck and panicles",
            SimilarValueAr = "الأوراق والحبوب",
            SimilarValueEn = "Leaves and grains"
        },
        new DiseaseComparisonRow
        {
            Id = 63, ComparisonId = 6, SortOrder = 3,
            FeatureAr = "شكل البقع", FeatureEn = "Spot shape",
            DiseaseValueAr = "بقع معينية أو مغزلية كبيرة",
            DiseaseValueEn = "Large diamond or spindle-shaped spots",
            SimilarValueAr = "بقع بيضاوية صغيرة متناثرة",
            SimilarValueEn = "Small scattered oval spots"
        },
        new DiseaseComparisonRow
        {
            Id = 64, ComparisonId = 6, SortOrder = 4,
            FeatureAr = "التوقيت", FeatureEn = "Timing",
            DiseaseValueAr = "رطوبة عالية وندى طويل وتسميد أزوتي زائد",
            DiseaseValueEn = "High humidity, long dew periods and excess nitrogen",
            SimilarValueAr = "نقص التغذية والتربة الفقيرة",
            SimilarValueEn = "Nutrient deficiency and poor soil"
        },
        new DiseaseComparisonRow
        {
            Id = 71, ComparisonId = 7, SortOrder = 1,
            FeatureAr = "لون البقع", FeatureEn = "Spot color",
            DiseaseValueAr = "بني إلى بني داكن",
            DiseaseValueEn = "Brown to dark brown",
            SimilarValueAr = "رمادي مخضر بحواف بنية",
            SimilarValueEn = "Grey-green with brown margins"
        },
        new DiseaseComparisonRow
        {
            Id = 72, ComparisonId = 7, SortOrder = 2,
            FeatureAr = "المكان الرئيسي", FeatureEn = "Main location",
            DiseaseValueAr = "نصل الورقة والحبوب",
            DiseaseValueEn = "Leaf blade and grains",
            SimilarValueAr = "الغمد قرب خط الماء ثم الأوراق العليا",
            SimilarValueEn = "Sheath near the water line, then upper leaves"
        },
        new DiseaseComparisonRow
        {
            Id = 73, ComparisonId = 7, SortOrder = 3,
            FeatureAr = "شكل البقع", FeatureEn = "Spot shape",
            DiseaseValueAr = "بقع بيضاوية صغيرة منفصلة",
            DiseaseValueEn = "Small separate oval spots",
            SimilarValueAr = "بقع بيضاوية كبيرة تتحد معاً",
            SimilarValueEn = "Large oval lesions that merge together"
        },
        new DiseaseComparisonRow
        {
            Id = 74, ComparisonId = 7, SortOrder = 4,
            FeatureAr = "التوقيت", FeatureEn = "Timing",
            DiseaseValueAr = "ضعف التربة وإجهاد النبات",
            DiseaseValueEn = "Poor soil and plant stress",
            SimilarValueAr = "كثافة زراعة عالية مع حرارة ورطوبة عالية",
            SimilarValueEn = "Dense planting with high heat and humidity"
        }
    };
}