namespace AgriAI.Domain.Entities;

public class Disease
{
    public int Id { get; set; }

    public string NameAr { get; set; } = string.Empty;

    public string NameEn { get; set; } = string.Empty;

    public bool IsHealthy { get; set; }

    public int CropId { get; set; }

    public Crop Crop { get; set; } = null!;
}