namespace AgriAI.Domain.Entities;

public class Farm
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; } = default!;
    public string? Governorate { get; set; }
    public string? SoilType { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User User { get; set; } = default!;
    public ICollection<Field> Fields { get; set; } = new List<Field>();
}