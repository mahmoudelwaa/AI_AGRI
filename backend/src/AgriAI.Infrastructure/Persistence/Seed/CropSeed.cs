using AgriAI.Domain.Entities;

namespace AgriAI.Infrastructure.Persistence.Seed;

public static class CropSeed
{
    public static readonly Crop[] Data =
    {
        new Crop
        {
            Id = 1,
            NameAr = "طماطم",
            NameEn = "Tomato"
        },

        new Crop
        {
            Id = 2,
            NameAr = "أرز",
            NameEn = "Rice"
        },

        new Crop
        {
            Id = 3,
            NameAr = "قمح",
            NameEn = "Wheat"
        }
    };
}