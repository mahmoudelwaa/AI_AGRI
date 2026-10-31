using AgriAI.Domain.Entities;

namespace AgriAI.Infrastructure.Persistence.Seed;

public static class DiseaseSeed
{
    public static readonly Disease[] Data =
    {
        // Tomato Diseases
        new Disease { Id = 101, NameEn = "Healthy", NameAr = "سليم", IsHealthy = true, CropId = 1 },
        new Disease { Id = 102, NameEn = "Early Blight", NameAr = "اللفحة المبكرة", IsHealthy = false, CropId = 1 },
        new Disease { Id = 103, NameEn = "Late Blight", NameAr = "اللفحة المتأخرة", IsHealthy = false, CropId = 1 },
        new Disease { Id = 104, NameEn = "Septoria Leaf Spot", NameAr = "تبقع أوراق السبتوريا", IsHealthy = false, CropId = 1 },
        new Disease { Id = 105, NameEn = "Bacterial Spot", NameAr = "التبقع البكتيري", IsHealthy = false, CropId = 1 },
        new Disease { Id = 106, NameEn = "Fusarium Wilt", NameAr = "ذبول الفيوزاريوم", IsHealthy = false, CropId = 1 },
        new Disease { Id = 107, NameEn = "Tomato Yellow Leaf Curl Virus", NameAr = "فيروس تجعد واصفرار أوراق الطماطم", IsHealthy = false, CropId = 1 },

        // Rice Diseases
        new Disease { Id = 201, NameEn = "Healthy", NameAr = "سليم", IsHealthy = true, CropId = 2 },
        new Disease { Id = 202, NameEn = "Rice Blast", NameAr = "لفحة الأرز", IsHealthy = false, CropId = 2 },
        new Disease { Id = 203, NameEn = "Bacterial Leaf Blight", NameAr = "اللفحة البكتيرية للأرز", IsHealthy = false, CropId = 2 },
        new Disease { Id = 204, NameEn = "Brown Spot", NameAr = "التبقع البني", IsHealthy = false, CropId = 2 },
        new Disease { Id = 205, NameEn = "Sheath Blight", NameAr = "لفحة غمد الأرز", IsHealthy = false, CropId = 2 },

        // Wheat Diseases
        new Disease { Id = 301, NameEn = "Healthy", NameAr = "سليم", IsHealthy = true, CropId = 3 },
        new Disease { Id = 302, NameEn = "Yellow Rust", NameAr = "الصدأ الأصفر", IsHealthy = false, CropId = 3 },
        new Disease { Id = 303, NameEn = "Leaf Rust", NameAr = "صدأ الأوراق", IsHealthy = false, CropId = 3 },
        new Disease { Id = 304, NameEn = "Stem Rust", NameAr = "صدأ الساق", IsHealthy = false, CropId = 3 },
        new Disease { Id = 305, NameEn = "Septoria Leaf Blotch", NameAr = "تبقع أوراق السبتوريا", IsHealthy = false, CropId = 3 },
        new Disease { Id = 306, NameEn = "Powdery Mildew", NameAr = "البياض الدقيقي", IsHealthy = false, CropId = 3 }
    };
}