namespace AgriAI.Domain.Entities;

public class UserCrop
{
    public int UserId { get; set; }
    public int CropId { get; set; }
    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    public string? Variety { get; set; }
    public User User { get; set; } = default!;
    public Crop Crop { get; set; } = default!;
}