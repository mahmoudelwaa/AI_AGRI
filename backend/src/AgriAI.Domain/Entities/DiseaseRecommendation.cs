namespace AgriAI.Domain.Entities;

public class DiseaseRecommendation
{
    public int Id { get; set; }
    public int DiseaseId { get; set; }
    public int SortOrder { get; set; }

    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string BodyAr { get; set; } = default!;
    public string BodyEn { get; set; } = default!;

    public Disease Disease { get; set; } = default!;
}