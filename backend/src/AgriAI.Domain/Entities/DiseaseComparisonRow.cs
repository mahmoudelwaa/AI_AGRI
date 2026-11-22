namespace AgriAI.Domain.Entities;

public class DiseaseComparisonRow
{
    public int Id { get; set; }
    public int ComparisonId { get; set; }
    public int SortOrder { get; set; }

    public string FeatureAr { get; set; } = default!;
    public string FeatureEn { get; set; } = default!;
    public string? DiseaseValueAr { get; set; }
    public string? DiseaseValueEn { get; set; }
    public string? SimilarValueAr { get; set; }
    public string? SimilarValueEn { get; set; }

    public DiseaseComparison Comparison { get; set; } = default!;
}