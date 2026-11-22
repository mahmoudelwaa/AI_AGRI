using AgriAI.Domain.Enums;

namespace AgriAI.Domain.Entities;

public class Disease
{
    public int Id { get; set; }
    public int CropId { get; set; }
    public string NameEn { get; set; } = default!;
    public string NameAr { get; set; } = default!;
    public bool IsHealthy { get; set; }

    public string? Symptoms { get; set; }
    public string? Causes { get; set; }
    public string? Prevention { get; set; }
    public string? Treatment { get; set; }

    public string? ScientificName { get; set; }
    public PathogenType PathogenType { get; set; } = PathogenType.None;
    public SeverityLevel Severity { get; set; } = SeverityLevel.None;
    public SpreadRate SpreadRate { get; set; } = SpreadRate.None;
    public string? Conditions { get; set; }
    public string? ImageUrl { get; set; }
    
    public string? InfectionPatternAr { get; set; }
    public string? InfectionPatternEn { get; set; }
    public string? SymptomsEn { get; set; }
    public string? CausesEn { get; set; }
    public string? PreventionEn { get; set; }
    public string? TreatmentEn { get; set; }
    public string? ConditionsEn { get; set; }
    public Crop Crop { get; set; } = default!;
}