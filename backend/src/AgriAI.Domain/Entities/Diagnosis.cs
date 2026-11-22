namespace AgriAI.Domain.Entities;

public class Diagnosis
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CropId { get; set; }
    public int DiseaseId { get; set; }
    public int? FieldId { get; set; }
    public double Confidence { get; set; }
    public string ImagePath { get; set; } = default!;
    public string? ImageFileName { get; set; }
    public long? ImageSizeBytes { get; set; }
    public string? ModelVersion { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public DateTime DiagnosedAt { get; set; } = DateTime.UtcNow;
    public User User { get; set; } = default!;
    public Crop Crop { get; set; } = default!;
    public Disease Disease { get; set; } = default!;
    public Field? Field { get; set; }
    public ICollection<DiagnosisPrediction> Predictions { get; set; } = new List<DiagnosisPrediction>();
}