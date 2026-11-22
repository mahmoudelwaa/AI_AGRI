namespace AgriAI.Domain.Entities;

public class DiseaseComparison
{
    public int Id { get; set; }
    public int DiseaseId { get; set; }
    public int SimilarDiseaseId { get; set; }
    public string? IntroAr { get; set; }
    public string? IntroEn { get; set; }

    public Disease Disease { get; set; } = default!;
    public Disease SimilarDisease { get; set; } = default!;
    public ICollection<DiseaseComparisonRow> Rows { get; set; } = new List<DiseaseComparisonRow>();
}