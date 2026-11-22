using AgriAI.Domain.Entities;

namespace AgriAI.Infrastructure.Persistence.Seed;

public static class DiseaseRecommendationSeed
{
    public static readonly DiseaseRecommendation[] Data =
    {
        new DiseaseRecommendation
        {
            Id = 1011, DiseaseId = 101, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص النباتات أسبوعياً للتأكد من بقائها خالية من الأعراض.",
            BodyEn = "Inspect plants weekly to make sure they stay symptom-free."
        },
        new DiseaseRecommendation
        {
            Id = 1012, DiseaseId = 101, SortOrder = 2,
            TitleAr = "الوقاية",
            TitleEn = "Prevention",
            BodyAr = "حافظ على التسميد المتوازن وأزل الحشائش لتقليل فرص العدوى.",
            BodyEn = "Keep fertilization balanced and remove weeds to reduce infection risk."
        },
        new DiseaseRecommendation
        {
            Id = 1013, DiseaseId = 101, SortOrder = 3,
            TitleAr = "إدارة الري",
            TitleEn = "Irrigation management",
            BodyAr = "اروِ بانتظام وتجنب بلل الأوراق لفترات طويلة.",
            BodyEn = "Irrigate regularly and avoid keeping leaves wet for long periods."
        },
        new DiseaseRecommendation
        {
            Id = 1021, DiseaseId = 102, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأوراق السفلية كل بضعة أيام وسجّل أي بقع جديدة.",
            BodyEn = "Check the lower leaves every few days and note any new spots."
        },
        new DiseaseRecommendation
        {
            Id = 1022, DiseaseId = 102, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ابدأ برش مبيد فطري مناسب عند ظهور الأعراض الأولى واتبع تعليمات الملصق.",
            BodyEn = "Start a suitable fungicide spray at the first symptoms and follow the label instructions."
        },
        new DiseaseRecommendation
        {
            Id = 1023, DiseaseId = 102, SortOrder = 3,
            TitleAr = "إدارة الري",
            TitleEn = "Irrigation management",
            BodyAr = "اروِ عند قاعدة النبات وفي الصباح الباكر لتقليل رطوبة الأوراق.",
            BodyEn = "Water at the base of the plant in the early morning to reduce leaf wetness."
        },
        new DiseaseRecommendation
        {
            Id = 1031, DiseaseId = 103, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "تابع الحقل يومياً في الطقس البارد الرطب لأن الإصابة تنتشر بسرعة.",
            BodyEn = "Scout the field daily in cool, wet weather because infection spreads quickly."
        },
        new DiseaseRecommendation
        {
            Id = 1032, DiseaseId = 103, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً وقائياً وأزل النباتات شديدة الإصابة وتخلص منها بعيداً عن الحقل.",
            BodyEn = "Apply a protective fungicide and remove severely infected plants, disposing of them away from the field."
        },
        new DiseaseRecommendation
        {
            Id = 1033, DiseaseId = 103, SortOrder = 3,
            TitleAr = "إدارة الري",
            TitleEn = "Irrigation management",
            BodyAr = "تجنب الري بالرش وحسّن التهوية بين النباتات لتجف الأوراق سريعاً.",
            BodyEn = "Avoid overhead irrigation and improve airflow so leaves dry quickly."
        },
        new DiseaseRecommendation
        {
            Id = 1041, DiseaseId = 104, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأوراق السفلية بحثاً عن البقع ذات النقاط السوداء الصغيرة.",
            BodyEn = "Check the lower leaves for spots containing tiny black dots."
        },
        new DiseaseRecommendation
        {
            Id = 1042, DiseaseId = 104, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "أزل الأوراق المصابة وابدأ برنامج رش بمبيد فطري مناسب.",
            BodyEn = "Remove infected leaves and start a suitable fungicide program."
        },
        new DiseaseRecommendation
        {
            Id = 1043, DiseaseId = 104, SortOrder = 3,
            TitleAr = "إدارة الري",
            TitleEn = "Irrigation management",
            BodyAr = "قلل الرذاذ عند الري وغطِّ التربة بالمهاد لمنع انتقال الجراثيم.",
            BodyEn = "Reduce splashing when irrigating and mulch the soil to stop spores from spreading."
        },
        new DiseaseRecommendation
        {
            Id = 1051, DiseaseId = 105, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأوراق والثمار بعد الأمطار والرياح لأنها تنقل البكتيريا.",
            BodyEn = "Inspect leaves and fruit after rain and wind, which spread the bacteria."
        },
        new DiseaseRecommendation
        {
            Id = 1052, DiseaseId = 105, SortOrder = 2,
            TitleAr = "العلاج النحاسي",
            TitleEn = "Copper treatment",
            BodyAr = "ارش مركبات نحاسية وأزل النباتات شديدة الإصابة.",
            BodyEn = "Spray copper compounds and remove severely infected plants."
        },
        new DiseaseRecommendation
        {
            Id = 1053, DiseaseId = 105, SortOrder = 3,
            TitleAr = "إدارة الري",
            TitleEn = "Irrigation management",
            BodyAr = "تجنب الري بالرش ولا تعمل في الحقل والنباتات مبللة.",
            BodyEn = "Avoid overhead irrigation and do not work in the field while plants are wet."
        },
        new DiseaseRecommendation
        {
            Id = 1061, DiseaseId = 106, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "راقب ظهور الاصفرار من جانب واحد وافحص الأوعية عند قطع الساق.",
            BodyEn = "Watch for one-sided yellowing and check the vessels when the stem is cut."
        },
        new DiseaseRecommendation
        {
            Id = 1062, DiseaseId = 106, SortOrder = 2,
            TitleAr = "التخلص من النباتات المصابة",
            TitleEn = "Remove infected plants",
            BodyAr = "اقلع النباتات المصابة وتخلص منها، فالمرض لا يُعالج بالرش بعد الإصابة.",
            BodyEn = "Uproot and discard infected plants; spraying will not cure the disease once infected."
        },
        new DiseaseRecommendation
        {
            Id = 1063, DiseaseId = 106, SortOrder = 3,
            TitleAr = "إدارة التربة",
            TitleEn = "Soil management",
            BodyAr = "عقّم التربة وتجنب زراعة الطماطم في نفس المكان في الموسم التالي.",
            BodyEn = "Sterilize the soil and avoid planting tomatoes in the same spot next season."
        },
        new DiseaseRecommendation
        {
            Id = 1071, DiseaseId = 107, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص ظهر الأوراق بحثاً عن الذبابة البيضاء بشكل منتظم.",
            BodyEn = "Check the underside of the leaves for whiteflies regularly."
        },
        new DiseaseRecommendation
        {
            Id = 1072, DiseaseId = 107, SortOrder = 2,
            TitleAr = "التخلص من النباتات المصابة",
            TitleEn = "Remove infected plants",
            BodyAr = "اقلع النباتات المصابة فوراً لأنه لا يوجد علاج للفيروس.",
            BodyEn = "Remove infected plants immediately because there is no cure for the virus."
        },
        new DiseaseRecommendation
        {
            Id = 1073, DiseaseId = 107, SortOrder = 3,
            TitleAr = "مكافحة الناقل",
            TitleEn = "Vector control",
            BodyAr = "استخدم الشبك الواقي والمصائد الصفراء وكافح الذبابة البيضاء.",
            BodyEn = "Use protective netting and yellow sticky traps, and control whiteflies."
        },
        new DiseaseRecommendation
        {
            Id = 2011, DiseaseId = 201, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الحقل أسبوعياً وتابع لون الأوراق ونمو الأشطاء.",
            BodyEn = "Inspect the field weekly and watch leaf color and tiller growth."
        },
        new DiseaseRecommendation
        {
            Id = 2012, DiseaseId = 201, SortOrder = 2,
            TitleAr = "الوقاية",
            TitleEn = "Prevention",
            BodyAr = "حافظ على التسميد المتوازن وأزل الحشائش وبقايا المحصول.",
            BodyEn = "Keep fertilization balanced and remove weeds and crop residues."
        },
        new DiseaseRecommendation
        {
            Id = 2013, DiseaseId = 201, SortOrder = 3,
            TitleAr = "إدارة المياه",
            TitleEn = "Water management",
            BodyAr = "حافظ على مستوى مياه مناسب ولا تفرط في الغمر.",
            BodyEn = "Maintain an appropriate water level and avoid over-flooding."
        },
        new DiseaseRecommendation
        {
            Id = 2021, DiseaseId = 202, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأوراق والعنق بانتظام خاصة في الجو الرطب ومع الندى.",
            BodyEn = "Inspect leaves and the neck regularly, especially in humid weather with dew."
        },
        new DiseaseRecommendation
        {
            Id = 2022, DiseaseId = 202, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً مناسباً عند ظهور الأعراض الأولى وأزل بقايا القش المصاب.",
            BodyEn = "Apply a suitable fungicide at the first symptoms and remove infected straw."
        },
        new DiseaseRecommendation
        {
            Id = 2023, DiseaseId = 202, SortOrder = 3,
            TitleAr = "إدارة التسميد",
            TitleEn = "Fertilizer management",
            BodyAr = "خفف التسميد الأزوتي وقسّمه على دفعات.",
            BodyEn = "Reduce nitrogen fertilizer and split it into several applications."
        },
        new DiseaseRecommendation
        {
            Id = 2031, DiseaseId = 203, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "تابع حواف الأوراق بعد العواصف والأمطار لأنها تنقل البكتيريا.",
            BodyEn = "Check the leaf edges after storms and rain, which spread the bacteria."
        },
        new DiseaseRecommendation
        {
            Id = 2032, DiseaseId = 203, SortOrder = 2,
            TitleAr = "الوقاية والعزل",
            TitleEn = "Prevention and isolation",
            BodyAr = "لا يوجد علاج فعال بعد الانتشار، فركّز على الوقاية وعزل الحقول المصابة.",
            BodyEn = "There is no effective cure once it spreads, so focus on prevention and isolate infected fields."
        },
        new DiseaseRecommendation
        {
            Id = 2033, DiseaseId = 203, SortOrder = 3,
            TitleAr = "إدارة المياه",
            TitleEn = "Water management",
            BodyAr = "صرّف المياه من الحقول المصابة ولا تنقل مياه الري إلى حقول سليمة.",
            BodyEn = "Drain water from infected fields and do not move irrigation water to healthy fields."
        },
        new DiseaseRecommendation
        {
            Id = 2041, DiseaseId = 204, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأوراق والحبوب وتابع علامات نقص التغذية.",
            BodyEn = "Inspect leaves and grains and watch for signs of nutrient deficiency."
        },
        new DiseaseRecommendation
        {
            Id = 2042, DiseaseId = 204, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "عالج البذور بمطهر فطري وارش مبيداً فطرياً عند الحاجة.",
            BodyEn = "Treat seed with a fungicide and spray a fungicide when needed."
        },
        new DiseaseRecommendation
        {
            Id = 2043, DiseaseId = 204, SortOrder = 3,
            TitleAr = "إدارة التغذية",
            TitleEn = "Nutrition management",
            BodyAr = "عوّض نقص العناصر خاصة البوتاسيوم وحافظ على مياه كافية.",
            BodyEn = "Correct nutrient deficiencies, especially potassium, and keep the water supply sufficient."
        },
        new DiseaseRecommendation
        {
            Id = 2051, DiseaseId = 205, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأغماد قرب خط الماء وتابع اتساع البقع نحو الأوراق العليا.",
            BodyEn = "Inspect sheaths near the water line and watch spots spreading toward the upper leaves."
        },
        new DiseaseRecommendation
        {
            Id = 2052, DiseaseId = 205, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً مناسباً وأزل الحشائش وبقايا المحصول.",
            BodyEn = "Apply a suitable fungicide and remove weeds and crop residues."
        },
        new DiseaseRecommendation
        {
            Id = 2053, DiseaseId = 205, SortOrder = 3,
            TitleAr = "إدارة الكثافة والمياه",
            TitleEn = "Density and water management",
            BodyAr = "قلل كثافة الزراعة وصرّف المياه الزائدة لتحسين التهوية.",
            BodyEn = "Reduce planting density and drain excess water to improve airflow."
        },
        new DiseaseRecommendation
        {
            Id = 3011, DiseaseId = 301, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الحقل أسبوعياً بحثاً عن أي بثرات أو بقع جديدة.",
            BodyEn = "Inspect the field weekly for any new pustules or spots."
        },
        new DiseaseRecommendation
        {
            Id = 3012, DiseaseId = 301, SortOrder = 2,
            TitleAr = "الوقاية",
            TitleEn = "Prevention",
            BodyAr = "ازرع أصنافاً مقاومة وحافظ على التسميد المتوازن.",
            BodyEn = "Plant resistant varieties and keep fertilization balanced."
        },
        new DiseaseRecommendation
        {
            Id = 3013, DiseaseId = 301, SortOrder = 3,
            TitleAr = "إدارة الري",
            TitleEn = "Irrigation management",
            BodyAr = "اروِ حسب حاجة المحصول وتجنب الإفراط في الرطوبة.",
            BodyEn = "Irrigate according to crop needs and avoid excess moisture."
        },
        new DiseaseRecommendation
        {
            Id = 3021, DiseaseId = 302, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأوراق بحثاً عن الخطوط الصفراء، وراقب الحقل بعد كل ندى أو طقس بارد رطب.",
            BodyEn = "Look for yellow stripes on the leaves and scout the field after dew or cool, humid weather."
        },
        new DiseaseRecommendation
        {
            Id = 3022, DiseaseId = 302, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً مناسباً عند ظهور الأعراض الأولى لمنع انتشار الجراثيم.",
            BodyEn = "Apply a suitable fungicide at the first symptoms to stop spores from spreading."
        },
        new DiseaseRecommendation
        {
            Id = 3023, DiseaseId = 302, SortOrder = 3,
            TitleAr = "إدارة الري",
            TitleEn = "Irrigation management",
            BodyAr = "تجنب الري بالرش في الصباح الباكر وفترات الرطوبة العالية حتى لا تتوفر بيئة حاضنة للفطر.",
            BodyEn = "Avoid overhead irrigation in the early morning and in very humid periods so the fungus has no favorable environment."
        },
        new DiseaseRecommendation
        {
            Id = 3031, DiseaseId = 303, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "تابع الأوراق العليا وسجّل انتشار البثرات البرتقالية.",
            BodyEn = "Follow the upper leaves and record the spread of the orange pustules."
        },
        new DiseaseRecommendation
        {
            Id = 3032, DiseaseId = 303, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً مناسباً وواصل متابعة الحقل بعد الرش.",
            BodyEn = "Apply a suitable fungicide and keep scouting the field after spraying."
        },
        new DiseaseRecommendation
        {
            Id = 3033, DiseaseId = 303, SortOrder = 3,
            TitleAr = "ميعاد الزراعة",
            TitleEn = "Sowing time",
            BodyAr = "تجنب الزراعة المتأخرة والكثافة العالية في المواسم القادمة.",
            BodyEn = "Avoid late sowing and dense planting in future seasons."
        },
        new DiseaseRecommendation
        {
            Id = 3041, DiseaseId = 304, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص السيقان والأغماد بحثاً عن بثرات بنية محمرة، خاصة في الطقس الدافئ الرطب.",
            BodyEn = "Inspect stems and sheaths for reddish-brown pustules, especially in warm, humid weather."
        },
        new DiseaseRecommendation
        {
            Id = 3042, DiseaseId = 304, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً مناسباً فور ظهور الإصابة.",
            BodyEn = "Apply a suitable fungicide as soon as infection appears."
        },
        new DiseaseRecommendation
        {
            Id = 3043, DiseaseId = 304, SortOrder = 3,
            TitleAr = "الوقاية الموسمية",
            TitleEn = "Seasonal prevention",
            BodyAr = "ازرع مبكراً وأزل العوائل البديلة القريبة من الحقل.",
            BodyEn = "Sow early and remove alternate host plants near the field."
        },
        new DiseaseRecommendation
        {
            Id = 3051, DiseaseId = 305, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "افحص الأوراق السفلية بحثاً عن البقع ذات النقاط السوداء.",
            BodyEn = "Check the lower leaves for blotches with black dots."
        },
        new DiseaseRecommendation
        {
            Id = 3052, DiseaseId = 305, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً مناسباً عند بداية الإصابة.",
            BodyEn = "Apply a suitable fungicide at the start of infection."
        },
        new DiseaseRecommendation
        {
            Id = 3053, DiseaseId = 305, SortOrder = 3,
            TitleAr = "بقايا المحصول",
            TitleEn = "Crop residues",
            BodyAr = "تخلص من بقايا المحصول المصابة بعد الحصاد وطبّق دورة زراعية.",
            BodyEn = "Remove infected crop residues after harvest and rotate crops."
        },
        new DiseaseRecommendation
        {
            Id = 3061, DiseaseId = 306, SortOrder = 1,
            TitleAr = "المراقبة الدقيقة",
            TitleEn = "Close monitoring",
            BodyAr = "تابع ظهور الطبقة البيضاء المسحوقية على الأوراق والأغماد.",
            BodyEn = "Watch for white powdery growth on leaves and sheaths."
        },
        new DiseaseRecommendation
        {
            Id = 3062, DiseaseId = 306, SortOrder = 2,
            TitleAr = "العلاج الفطري",
            TitleEn = "Fungicide treatment",
            BodyAr = "ارش مبيداً فطرياً مناسباً وحسّن التهوية داخل الحقل.",
            BodyEn = "Apply a suitable fungicide and improve airflow in the field."
        },
        new DiseaseRecommendation
        {
            Id = 3063, DiseaseId = 306, SortOrder = 3,
            TitleAr = "إدارة التسميد",
            TitleEn = "Fertilizer management",
            BodyAr = "خفف التسميد الأزوتي وقلل كثافة الزراعة.",
            BodyEn = "Reduce nitrogen fertilizer and lower planting density."
        }
    };
}