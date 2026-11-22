namespace AgriAI.Domain.Entities;

public class Field
{
    public int Id { get; set; }
    public int FarmId { get; set; }
    public int CropId { get; set; }
    public string Name { get; set; } = default!;
    public decimal? AreaFeddan { get; set; }
    public DateTime? PlantedAt { get; set; }

    public Farm Farm { get; set; } = default!;
    public Crop Crop { get; set; } = default!;
    public ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();
}