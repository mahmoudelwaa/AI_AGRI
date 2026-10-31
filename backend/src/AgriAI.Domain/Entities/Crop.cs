namespace AgriAI.Domain.Entities;

public class Crop
{
    public int Id { get; set; }

    public string NameAr { get; set; } = string.Empty;

    public string NameEn { get; set; } = string.Empty;
    
    public ICollection<Disease> Diseases { get; set; } = new List<Disease>();
}