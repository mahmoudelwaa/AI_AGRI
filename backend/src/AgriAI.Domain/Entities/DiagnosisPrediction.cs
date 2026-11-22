namespace AgriAI.Domain.Entities;

public class DiagnosisPrediction
{
    public int Id { get; set; }
    public int DiagnosisId { get; set; }
    public int DiseaseId { get; set; }
    public double Confidence { get; set; }
    public int Rank { get; set; }

    public Diagnosis Diagnosis { get; set; } = default!;
    public Disease Disease { get; set; } = default!;
}