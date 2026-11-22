namespace AgriAI.Domain.Entities;

public class Crop
{
    public int Id { get; set; }
    public string NameEn { get; set; } = default!;
    public string NameAr { get; set; } = default!;
    public string? ImageUrl { get; set; }
    
    public ICollection<Disease> Diseases { get; set; } = new List<Disease>();
    public ICollection<UserCrop> UserCrops { get; set; } = new List<UserCrop>();
}